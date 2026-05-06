namespace WinFormsApp2
{
    public partial class Form1 : Form

    {

        void ChangeForeColorRadio(RadioButton b)
        {
            if(b.Checked)
              b.ForeColor = Color.Yellow;
            else
                b.ForeColor = Color.Lime;

            
            
        }

        void ChangeForeColorCheckBox(CheckBox b)
        {
            if (b.Checked)
                b.ForeColor = Color.Yellow;
            else
                b.ForeColor = Color.Lime;



        }
    
        public Form1()
        {
            InitializeComponent();
           
        }

        public void ReSetOrder()
        {
            rbTakeOut.Checked = false;
            rbEatin.Checked = true;


            rbCrustOnin.Checked = true;
            rbCurstThik.Checked = false;

            cbExtraCheese.Checked = false;
            cbToppingGreenPeppers.Checked = false;
            cbToppingMushroom.Checked = false;
            cbToppingOlives.Checked = false;
            cbToppingOnin.Checked=false;
            cbToppingTomaose.Checked=false;

        }

       public string UpdateTopping()
        {
            string Toppinh = "";
            if(cbExtraCheese.Checked)
            {
                Toppinh += "\n"+cbExtraCheese.Text;
            } 

            if(cbToppingTomaose.Checked)
            {
                Toppinh += "\n"+ cbToppingTomaose.Text;
            }

            if(cbToppingMushroom.Checked)
            {
                Toppinh += "\n"+ cbToppingMushroom.Text;
            }

             if(cbToppingOlives.Checked)
            {
                Toppinh += "\n"+ cbToppingOlives.Text;
            }

              if(cbToppingOnin.Checked)
            {
                Toppinh += "\n"+ cbToppingOnin.Text;
            }

            
            if(cbToppingGreenPeppers.Checked)
            {
                Toppinh += "\n"+ cbToppingOnin.Text;
            }

            if(Toppinh=="")
            {
                return "No Toppings";
            }

          return  Toppinh.Substring(1,Toppinh.Length-1);



        }

        public string UpdateSize()
        {
           
            if (rdMediumPizza.Checked)
            {
               // rdMediumPizza.ForeColor=Color.Red;
                
                return rdMediumPizza.Text;
            }

            if(rdLargePizza.Checked)
            {
               
                return rdLargePizza.Text;

            }
       
            return rdSmallPizza.Text;
               
        }

       public float CalculateTopping()
        {
            float Total = 0;
            if (cbExtraCheese.Checked)
            {
                Total += Convert.ToSingle( cbExtraCheese.Tag);
            }

            if (cbToppingTomaose.Checked)
            {
                Total += Convert.ToSingle(cbToppingTomaose.Tag);
            }

            if (cbToppingMushroom.Checked)
            {
                Total += Convert.ToSingle(cbToppingMushroom.Tag);
            }

            if (cbToppingOlives.Checked)
            {
                Total += Convert.ToSingle(cbToppingOlives.Tag);
            }

            if (cbToppingOnin.Checked)
            {
                Total += Convert.ToSingle(cbToppingOnin.Tag);
            }


            if (cbToppingGreenPeppers.Checked)
            {
                Total += Convert.ToSingle(cbToppingGreenPeppers.Tag);
            }

            
                return Total;
       
        }

        float CalculatePriceCrust()
        {
            float Total = 0;
            if (rbCrustOnin.Checked)
            {
                Total += Convert.ToSingle(rbCrustOnin.Tag);

            }

          
            if (rbCurstThik.Checked)
            {

                Total += Convert.ToSingle(rbCurstThik.Tag);

            }

            return Total;
        }

       public string UptaseWhereEat()
        {
           
            if (rbEatin.Checked)
            {
                return rbEatin.Text;

            }

           if(rbTakeOut.Checked)
            {
                return rbTakeOut.Text;

            }
            return "";
;
        }

         public string UptaseCrust()
        {
           
            if (rbCrustOnin.Checked)
            {
                return rbCrustOnin.Text;

            }


            

            return rbCurstThik.Text;
        }


        float CalculatePriceSize()
        {
            float Total = 0;
            if (rdMediumPizza.Checked)
            {
                Total += Convert.ToSingle(rdMediumPizza.Tag);

            }

            if (rdLargePizza.Checked)
            {

                Total += Convert.ToSingle(rdLargePizza.Tag);

            }
            if (rdSmallPizza.Checked)
            {

                Total += Convert.ToSingle(rdSmallPizza.Tag);

            }

            return Total;
        }


        public float CalculateAllPrice()
        {

            return CalculateTopping() + CalculatePriceSize()+ CalculatePriceCrust();
        }
        void TotalPrice()
        {
            CbTotalPrice.Text = Convert.ToString(CalculateAllPrice()) + "$";
        }
        private void lbClose_Click(object sender, EventArgs e)
        {
            lbClose.BackColor = Color.Red;
            Application.Exit();
        }

        private void btGetBack_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form TypOrder = new TypeOrderPizza();
            TypOrder.ShowDialog();
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
          
           Form OrderSumm = new OrderSummary(this);
            
            OrderSumm.ShowDialog();
            this.Close();   
           


        }

        private void lbClose_MouseDown(object sender, MouseEventArgs e)
        {
            lbClose.BackColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReSetOrder();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            ReSetOrder();
        }

        private void ChangeToppings(object sender, EventArgs e)
        {
            ChangeForeColorCheckBox((CheckBox)sender);
            TotalPrice();
        }

        private void changeForeColorAllRadiob(object sender, EventArgs e)
        {
            ChangeForeColorRadio((RadioButton)sender);
            TotalPrice();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}