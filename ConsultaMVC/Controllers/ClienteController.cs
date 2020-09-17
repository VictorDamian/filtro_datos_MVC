using System;
using ConsultaMVC.Models.DAO;
using ConsultaMVC.Views;

namespace ConsultaMVC.Controllers
{
    class ClienteController
    {
        //ATRIBUTOS 
        ClienteView vista;
        //constructor
        public ClienteController(ClienteView View)
        {
            vista = View;//sirve como instancia para acceder a los elemetos de ClientVIew
            //inicializar eventos
            //+= manejador de evento
            vista.Load += new EventHandler(ClientList);
            vista.btnBuscar.Click += new EventHandler(ClientList);
            vista.txtBuscar.TextChanged += new EventHandler(ClientList);
        }
        public void ClientList(object sender, EventArgs e)
        {
            ClienteDAO db = new ClienteDAO();
            vista.gridClientes.DataSource = db.verRegistros(vista.txtBuscar.Text);
        }
    }
}
