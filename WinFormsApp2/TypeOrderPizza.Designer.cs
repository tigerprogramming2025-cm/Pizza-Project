namespace WinFormsApp2
{
    partial class TypeOrderPizza
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCloseTypeorder = new System.Windows.Forms.Label();
            this.btReady_madepizza = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btMakeP = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 144);
            this.label1.TabIndex = 2;
            this.label1.Text = "HOW WOULD YOU\r\nLIKE YOUR PIZZA ?\r\n";
            // 
            // lbCloseTypeorder
            // 
            this.lbCloseTypeorder.AutoSize = true;
            this.lbCloseTypeorder.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbCloseTypeorder.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCloseTypeorder.ForeColor = System.Drawing.Color.Brown;
            this.lbCloseTypeorder.Location = new System.Drawing.Point(492, 0);
            this.lbCloseTypeorder.Name = "lbCloseTypeorder";
            this.lbCloseTypeorder.Size = new System.Drawing.Size(38, 41);
            this.lbCloseTypeorder.TabIndex = 6;
            this.lbCloseTypeorder.Text = "X";
            this.lbCloseTypeorder.Click += new System.EventHandler(this.label3_Click);
            this.lbCloseTypeorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            // 
            // btReady_madepizza
            // 
            this.btReady_madepizza.BackColor = System.Drawing.Color.Transparent;
            this.btReady_madepizza.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btReady_madepizza.BorderRadius = 20;
            this.btReady_madepizza.BorderThickness = 2;
            this.btReady_madepizza.CustomizableEdges = customizableEdges1;
            this.btReady_madepizza.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btReady_madepizza.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btReady_madepizza.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btReady_madepizza.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btReady_madepizza.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btReady_madepizza.FillColor = System.Drawing.Color.Black;
            this.btReady_madepizza.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btReady_madepizza.FocusedColor = System.Drawing.Color.Red;
            this.btReady_madepizza.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btReady_madepizza.ForeColor = System.Drawing.Color.Yellow;
            this.btReady_madepizza.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btReady_madepizza.Location = new System.Drawing.Point(57, 537);
            this.btReady_madepizza.Name = "btReady_madepizza";
            this.btReady_madepizza.PressedColor = System.Drawing.Color.White;
            this.btReady_madepizza.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btReady_madepizza.Size = new System.Drawing.Size(392, 75);
            this.btReady_madepizza.TabIndex = 7;
            this.btReady_madepizza.Text = "Ready-Made Menu";
            this.btReady_madepizza.UseTransparentBackground = true;
            this.btReady_madepizza.Click += new System.EventHandler(this.btReady_madepizza_Click);
            // 
            // btMakeP
            // 
            this.btMakeP.BackColor = System.Drawing.Color.Transparent;
            this.btMakeP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btMakeP.BorderRadius = 20;
            this.btMakeP.BorderThickness = 2;
            this.btMakeP.CustomizableEdges = customizableEdges3;
            this.btMakeP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btMakeP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btMakeP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btMakeP.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btMakeP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btMakeP.FillColor = System.Drawing.Color.Black;
            this.btMakeP.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btMakeP.FocusedColor = System.Drawing.Color.Red;
            this.btMakeP.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btMakeP.ForeColor = System.Drawing.Color.Yellow;
            this.btMakeP.Location = new System.Drawing.Point(57, 675);
            this.btMakeP.Name = "btMakeP";
            this.btMakeP.PressedColor = System.Drawing.Color.White;
            this.btMakeP.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.btMakeP.Size = new System.Drawing.Size(392, 75);
            this.btMakeP.TabIndex = 8;
            this.btMakeP.Text = "Make My own Pizza";
            this.btMakeP.UseTransparentBackground = true;
            this.btMakeP.Click += new System.EventHandler(this.btMakeP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WinFormsApp2.Properties.Resources.images__3_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(530, 852);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // TypeOrderPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(530, 852);
            this.Controls.Add(this.btMakeP);
            this.Controls.Add(this.btReady_madepizza);
            this.Controls.Add(this.lbCloseTypeorder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TypeOrderPizza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TypeOrderPizza";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbCloseTypeorder;
        private Guna.UI2.WinForms.Guna2GradientButton btReady_madepizza;
        private Guna.UI2.WinForms.Guna2GradientButton btMakeP;
        private PictureBox pictureBox1;
    }
}