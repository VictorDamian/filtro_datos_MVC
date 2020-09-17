using System;
using System.Windows.Forms;
using ConsultaMVC.Controllers;

namespace ConsultaMVC.Views
{
    public partial class ClienteView : Form
    {
        public ClienteView()
        {
            InitializeComponent();
            ClienteController ctrl = new ClienteController(this);
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
