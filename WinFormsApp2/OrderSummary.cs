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
    public partial class OrderSummary : Form
    {

        bool _GetbackToForm;
        public OrderSummary()
        {
            InitializeComponent();
        }
        public OrderSummary(Form1 FormMakeownp)
        {
            InitializeComponent();

            _GetbackToForm = true;
            lbTypeForFill.Visible=false;
            lbTypePizza.Visible=false;


            lbToppins.Text = FormMakeownp.UpdateTopping();
            lbSizeForFill.Text = FormMakeownp.UpdateSize();
            lbCurstForFill.Text = FormMakeownp.UptaseCrust();
            lbWhereEatForFill.Text = FormMakeownp.UptaseWhereEat();
            lbTotalForFill.Text = Convert.ToString(FormMakeownp.CalculateAllPrice())+"$";

        }

        public OrderSummary(Form2 FormReadyMadeownp)
        {
            InitializeComponent();
            _GetbackToForm = false;
            lbTypeForFill.Visible = true;
            lbTypePizza.Visible = true;

            gbToppings.Visible = false;
            lbCurstForFill.Visible = false;
            LbCurstTyp.Visible = false; 
            lbWhereEat.Visible = false;
            lbWhereEatForFill.Visible = false;

            lbTypeForFill.Text = FormReadyMadeownp.GetTypeChosePizza();
            lbSizeForFill.Text = FormReadyMadeownp.GetSizeOfPizza();
            lbTotalForFill.Text = Convert.ToString (FormReadyMadeownp.UpdateTotalPrice()) + "$";

        }
      
        private void btConcel_Click(object sender, EventArgs e)
        {
            this.Close();
            if (_GetbackToForm == true)
            {
               
                Form form = new Form1();
                form.Show();
            }
            else
            {
                Form ReadMade=new Form2();
                ReadMade.Show();
            }

        }

       

        private void btConform_Click(object sender, EventArgs e)
        {
           if( guna2MessageDialog1.Show("Are you sure about order ?","Confirm")==DialogResult.Yes)
            {
               guna2MessageDialog1.Buttons= Guna.UI2.WinForms.MessageDialogButtons.OK;
                if (guna2MessageDialog1.Show("Confirm your chosse", "Confirm")==DialogResult.OK)
                {
                    this.Close();
                    Form TypeOrder = new TypeOrderPizza();
                    TypeOrder.Show();
                }
                
           }
           else
            {
                this.Close();
               

            }
                

        }
    }
}
