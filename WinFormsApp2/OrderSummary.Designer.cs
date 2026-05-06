namespace WinFormsApp2
{
    partial class OrderSummary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderSummary));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbWhereEatForFill = new System.Windows.Forms.Label();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.lbToppins = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.LbCurstTyp = new System.Windows.Forms.Label();
            this.lbWhereEat = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.lbSizeForFill = new System.Windows.Forms.Label();
            this.lbTypePizza = new System.Windows.Forms.Label();
            this.lbCurstForFill = new System.Windows.Forms.Label();
            this.lbTypeForFill = new System.Windows.Forms.Label();
            this.lbTotalForFill = new System.Windows.Forms.Label();
            this.btConcel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btConform = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(542, 790);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 87);
            this.label1.TabIndex = 14;
            this.label1.Text = "Order Summary\r\n";
            // 
            // lbWhereEatForFill
            // 
            this.lbWhereEatForFill.AutoSize = true;
            this.lbWhereEatForFill.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbWhereEatForFill.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbWhereEatForFill.ForeColor = System.Drawing.Color.Red;
            this.lbWhereEatForFill.Location = new System.Drawing.Point(180, 160);
            this.lbWhereEatForFill.Name = "lbWhereEatForFill";
            this.lbWhereEatForFill.Size = new System.Drawing.Size(77, 35);
            this.lbWhereEatForFill.TabIndex = 2;
            this.lbWhereEatForFill.Text = "Eat in";
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.SystemColors.WindowText;
            this.gbToppings.Controls.Add(this.lbToppins);
            this.gbToppings.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbToppings.ForeColor = System.Drawing.Color.Red;
            this.gbToppings.Location = new System.Drawing.Point(331, 475);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(199, 237);
            this.gbToppings.TabIndex = 18;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // lbToppins
            // 
            this.lbToppins.AutoSize = true;
            this.lbToppins.BackColor = System.Drawing.Color.Black;
            this.lbToppins.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbToppins.ForeColor = System.Drawing.Color.Yellow;
            this.lbToppins.Location = new System.Drawing.Point(21, 39);
            this.lbToppins.Name = "lbToppins";
            this.lbToppins.Size = new System.Drawing.Size(127, 31);
            this.lbToppins.TabIndex = 21;
            this.lbToppins.Text = "No Toppings";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.BackColor = System.Drawing.Color.Black;
            this.lbSize.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSize.ForeColor = System.Drawing.Color.Yellow;
            this.lbSize.Location = new System.Drawing.Point(21, 578);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(73, 35);
            this.lbSize.TabIndex = 0;
            this.lbSize.Text = ".Size :";
        
            // 
            // LbCurstTyp
            // 
            this.LbCurstTyp.AutoSize = true;
            this.LbCurstTyp.BackColor = System.Drawing.Color.Black;
            this.LbCurstTyp.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbCurstTyp.ForeColor = System.Drawing.Color.Yellow;
            this.LbCurstTyp.Location = new System.Drawing.Point(12, 459);
            this.LbCurstTyp.Name = "LbCurstTyp";
            this.LbCurstTyp.Size = new System.Drawing.Size(143, 35);
            this.LbCurstTyp.TabIndex = 1;
            this.LbCurstTyp.Text = ".Curst Type :";
            // 
            // lbWhereEat
            // 
            this.lbWhereEat.AutoSize = true;
            this.lbWhereEat.BackColor = System.Drawing.Color.Black;
            this.lbWhereEat.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbWhereEat.ForeColor = System.Drawing.Color.Yellow;
            this.lbWhereEat.Location = new System.Drawing.Point(14, 160);
            this.lbWhereEat.Name = "lbWhereEat";
            this.lbWhereEat.Size = new System.Drawing.Size(163, 35);
            this.lbWhereEat.TabIndex = 19;
            this.lbWhereEat.Text = ".Where to eat :";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.BackColor = System.Drawing.Color.Black;
            this.lbTotalPrice.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotalPrice.ForeColor = System.Drawing.Color.Yellow;
            this.lbTotalPrice.Location = new System.Drawing.Point(21, 640);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(153, 35);
            this.lbTotalPrice.TabIndex = 20;
            this.lbTotalPrice.Text = ".Totale Price :";
            // 
            // lbSizeForFill
            // 
            this.lbSizeForFill.AutoSize = true;
            this.lbSizeForFill.BackColor = System.Drawing.Color.Black;
            this.lbSizeForFill.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSizeForFill.ForeColor = System.Drawing.Color.Red;
            this.lbSizeForFill.Location = new System.Drawing.Point(100, 578);
            this.lbSizeForFill.Name = "lbSizeForFill";
            this.lbSizeForFill.Size = new System.Drawing.Size(72, 35);
            this.lbSizeForFill.TabIndex = 21;
            this.lbSizeForFill.Text = "Small";
            // 
            // lbTypePizza
            // 
            this.lbTypePizza.AutoSize = true;
            this.lbTypePizza.BackColor = System.Drawing.Color.Black;
            this.lbTypePizza.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTypePizza.ForeColor = System.Drawing.Color.Yellow;
            this.lbTypePizza.Location = new System.Drawing.Point(21, 520);
            this.lbTypePizza.Name = "lbTypePizza";
            this.lbTypePizza.Size = new System.Drawing.Size(142, 35);
            this.lbTypePizza.TabIndex = 22;
            this.lbTypePizza.Text = ".Type Pizza :";
            // 
            // lbCurstForFill
            // 
            this.lbCurstForFill.AutoSize = true;
            this.lbCurstForFill.BackColor = System.Drawing.Color.Black;
            this.lbCurstForFill.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCurstForFill.ForeColor = System.Drawing.Color.Red;
            this.lbCurstForFill.Location = new System.Drawing.Point(161, 459);
            this.lbCurstForFill.Name = "lbCurstForFill";
            this.lbCurstForFill.Size = new System.Drawing.Size(164, 35);
            this.lbCurstForFill.TabIndex = 23;
            this.lbCurstForFill.Text = "Thin Curst ..2$";
            // 
            // lbTypeForFill
            // 
            this.lbTypeForFill.AutoSize = true;
            this.lbTypeForFill.BackColor = System.Drawing.Color.Black;
            this.lbTypeForFill.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTypeForFill.ForeColor = System.Drawing.Color.Red;
            this.lbTypeForFill.Location = new System.Drawing.Point(179, 520);
            this.lbTypeForFill.Name = "lbTypeForFill";
            this.lbTypeForFill.Size = new System.Drawing.Size(129, 35);
            this.lbTypeForFill.TabIndex = 24;
            this.lbTypeForFill.Text = "Chees Pizza";
            // 
            // lbTotalForFill
            // 
            this.lbTotalForFill.AutoSize = true;
            this.lbTotalForFill.BackColor = System.Drawing.Color.Black;
            this.lbTotalForFill.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotalForFill.ForeColor = System.Drawing.Color.Red;
            this.lbTotalForFill.Location = new System.Drawing.Point(180, 640);
            this.lbTotalForFill.Name = "lbTotalForFill";
            this.lbTotalForFill.Size = new System.Drawing.Size(41, 35);
            this.lbTotalForFill.TabIndex = 25;
            this.lbTotalForFill.Text = "0$";
            // 
            // btConcel
            // 
            this.btConcel.BackColor = System.Drawing.Color.Transparent;
            this.btConcel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btConcel.BorderRadius = 20;
            this.btConcel.BorderThickness = 2;
            this.btConcel.CustomizableEdges = customizableEdges1;
            this.btConcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btConcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btConcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btConcel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btConcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btConcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btConcel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btConcel.FocusedColor = System.Drawing.Color.Red;
            this.btConcel.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btConcel.ForeColor = System.Drawing.Color.Yellow;
            this.btConcel.Location = new System.Drawing.Point(36, 718);
            this.btConcel.Name = "btConcel";
            this.btConcel.PressedColor = System.Drawing.Color.White;
            this.btConcel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btConcel.Size = new System.Drawing.Size(166, 60);
            this.btConcel.TabIndex = 27;
            this.btConcel.Text = "Cancel";
            this.btConcel.UseTransparentBackground = true;
            this.btConcel.Click += new System.EventHandler(this.btConcel_Click);
            // 
            // btConform
            // 
            this.btConform.BackColor = System.Drawing.Color.Transparent;
            this.btConform.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btConform.BorderRadius = 20;
            this.btConform.BorderThickness = 2;
            this.btConform.CustomizableEdges = customizableEdges3;
            this.btConform.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btConform.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btConform.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btConform.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btConform.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btConform.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btConform.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btConform.FocusedColor = System.Drawing.Color.Red;
            this.btConform.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btConform.ForeColor = System.Drawing.Color.Yellow;
            this.btConform.Location = new System.Drawing.Point(314, 718);
            this.btConform.Name = "btConform";
            this.btConform.PressedColor = System.Drawing.Color.White;
            this.btConform.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.btConform.Size = new System.Drawing.Size(174, 60);
            this.btConform.TabIndex = 28;
            this.btConform.Text = "Confirm";
            this.btConform.UseTransparentBackground = true;
            this.btConform.Click += new System.EventHandler(this.btConform_Click);
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.guna2MessageDialog1.Caption = null;
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.guna2MessageDialog1.Parent = this;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.guna2MessageDialog1.Text = null;
            // 
            // OrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 790);
            this.Controls.Add(this.btConform);
            this.Controls.Add(this.btConcel);
            this.Controls.Add(this.lbTotalForFill);
            this.Controls.Add(this.lbTypeForFill);
            this.Controls.Add(this.lbCurstForFill);
            this.Controls.Add(this.lbTypePizza);
            this.Controls.Add(this.lbSizeForFill);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.lbWhereEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.lbWhereEatForFill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbCurstTyp);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderSummary";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label lbWhereEatForFill;
        private Label LbCurstTyp;
        private GroupBox gbToppings;
        public Label lbSize;
        private Label lbToppins;
        private Label lbWhereEat;
        private Label lbTotalPrice;
        public Label lbSizeForFill;
        public Label lbTypePizza;
        public Label lbCurstForFill;
        public Label lbTypeForFill;
        public Label lbTotalForFill;
        private Guna.UI2.WinForms.Guna2GradientButton btConcel;
        private Guna.UI2.WinForms.Guna2GradientButton btConform;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
    }
}