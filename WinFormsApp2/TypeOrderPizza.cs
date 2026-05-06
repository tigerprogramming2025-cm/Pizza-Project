using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class TypeOrderPizza : Form
    {
        public TypeOrderPizza()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
            Application.Exit();
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            lbCloseTypeorder.BackColor = Color.Red;
        }

        
        private void btMakeP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form MakeOwnPizz
                = new Form1();
            MakeOwnPizz.Show();


        }

        private void btReady_madepizza_Click(object sender, EventArgs e)
        {
            Form R = new Form2();
            this.Close();
            R.ShowDialog();
        }
    }
}
