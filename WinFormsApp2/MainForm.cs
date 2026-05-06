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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer,true);

         
        }

        
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Form TypOrder=new TypeOrderPizza();
            TypOrder.ShowDialog();
            this.Hide();
           
        }

       
        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
