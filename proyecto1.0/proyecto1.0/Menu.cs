using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1._0
{
    public partial class Menu : Form
    {
        public Menu(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private string username;

        private void Menu_Load(object sender, EventArgs e)
        {
            lblUser.Text = lblUser.Text + username;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
