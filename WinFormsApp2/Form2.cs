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
    public partial class Form2 : Form
    {
        void ChangeForeColorRadios(RadioButton b)
        {
            if (b.Checked)
                b.ForeColor = Color.Yellow;
            else
                b.ForeColor = Color.Lime;



        }
      
        public Form2()
        {
            InitializeComponent();
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.SendToBack();
        }
           
        public string UpdateCheesePizzaSize()
        {
            if (rdLargeCheesePizza.Checked)
            {
                return rdLargeCheesePizza.Text;
            }

            if (rdSmallCheesePizza.Checked)
            {
                return rdSmallCheesePizza.Text;
            }
            if (rdMediumCheesePizza.Checked)
            {
                return rdMediumCheesePizza.Text;
            }
            return "";

        }

        public string GetTypeChosePizza()
        {
            string TypeP = "";
            if(rdSmallCheesePizza.Checked|| rdMediumCheesePizza.Checked
                || rdLargeCheesePizza.Checked)
            {
                TypeP += "Cheese ";
            }

           if(rdLargeVegePizza.Checked|| rdMediumVegePizza.Checked || rdLargeVegePizza.Checked)
            {
               
                TypeP += "Vegetalble";
            }

           if(TypeP != "")
            {
                TypeP += " Pizza";
            }
          
           return TypeP; 
        }

        public string UpdateVegetablePizzaSize()
        {
            if (rdSmallVegePizza.Checked)
            {
                return rdSmallVegePizza.Text;
            }

            if (rdMediumVegePizza.Checked)
            {
                return rdMediumVegePizza.Text;
            }
            if (rdLargeVegePizza.Checked)
            {
                return rdLargeVegePizza.Text;
            }
            return "";

        }
        public string GetSizeOfPizza()
        {
            return UpdateCheesePizzaSize() +" "+ UpdateVegetablePizzaSize();
        }
        private float CalculateCheesePizza()
        {

            if (rdSmallCheesePizza.Checked)
            {
                return (Convert.ToSingle(rdSmallCheesePizza.Tag));
            }

            if (rdMediumCheesePizza.Checked)
                return (Convert.ToSingle(rdMediumCheesePizza.Tag));

            if (rdLargeCheesePizza.Checked)
            {
                return (Convert.ToSingle(rdLargeCheesePizza.Tag));
            }

            return 0;
        }
        private float CalculateVagetablPizza()
        {

            if (rdSmallVegePizza.Checked)
            {
                return (Convert.ToSingle(rdSmallVegePizza.Tag));
            }

            if (rdMediumVegePizza.Checked)
                return (Convert.ToSingle(rdMediumVegePizza.Tag));

            if (rdLargeVegePizza.Checked)
            {
                return (Convert.ToSingle(rdLargeVegePizza.Tag));
            }

            return 0;
        }

        public float UpdateTotalPrice()
        {
            return CalculateCheesePizza() + CalculateVagetablPizza();
        }
        void UpdatePrice()
        {
            CbTotalPrice.Text = "$" + Convert.ToString(UpdateTotalPrice());
        }
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

            Form TypOrder;
            TypOrder = new TypeOrderPizza();
            TypOrder.ShowDialog();
            this.Hide();
        }

     

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form FReadMade = new OrderSummary(this);
            FReadMade.Show();
        }

       

        private void lbCloseTypeorder_Click(object sender, EventArgs e)
        {
            lbCloseTypeorder.BackColor = Color.Red;
            Application.Exit();
        }

        private void lbCloseTypeorder_MouseHover(object sender, EventArgs e)
        {
            lbCloseTypeorder.BackColor = Color.Red;
        }

       
       




        private void ChangeColorChecked(object sender, EventArgs e)
        {
          
            ChangeForeColorRadios((RadioButton)sender);
            UpdatePrice();
        }

       
    }
}
