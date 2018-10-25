namespace MVC
{
    partial class Form1
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
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.proteinasTextBox = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comidasList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.carbohidratosTextBox = new System.Windows.Forms.TextBox();
            this.grasasTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(106, 35);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 0;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            // 
            // proteinasTextBox
            // 
            this.proteinasTextBox.Location = new System.Drawing.Point(106, 66);
            this.proteinasTextBox.Name = "proteinasTextBox";
            this.proteinasTextBox.Size = new System.Drawing.Size(100, 20);
            this.proteinasTextBox.TabIndex = 1;
            this.proteinasTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(22, 35);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(44, 13);
            this.nombreLabel.TabIndex = 2;
            this.nombreLabel.Text = "Nombre";
            this.nombreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(22, 73);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(51, 13);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Proteinas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comidasList
            // 
            this.comidasList.FormattingEnabled = true;
            this.comidasList.Location = new System.Drawing.Point(433, 48);
            this.comidasList.Name = "comidasList";
            this.comidasList.Size = new System.Drawing.Size(249, 160);
            this.comidasList.TabIndex = 5;
            this.comidasList.SelectedIndexChanged += new System.EventHandler(this.contactosList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Carbohidratos";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Grasas";
            // 
            // carbohidratosTextBox
            // 
            this.carbohidratosTextBox.Location = new System.Drawing.Point(106, 150);
            this.carbohidratosTextBox.Name = "carbohidratosTextBox";
            this.carbohidratosTextBox.Size = new System.Drawing.Size(100, 20);
            this.carbohidratosTextBox.TabIndex = 7;
            // 
            // grasasTextBox
            // 
            this.grasasTextBox.Location = new System.Drawing.Point(106, 107);
            this.grasasTextBox.Name = "grasasTextBox";
            this.grasasTextBox.Size = new System.Drawing.Size(100, 20);
            this.grasasTextBox.TabIndex = 6;
            this.grasasTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Listado";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(522, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.carbohidratosTextBox);
            this.Controls.Add(this.grasasTextBox);
            this.Controls.Add(this.comidasList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.proteinasTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox proteinasTextBox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox comidasList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox carbohidratosTextBox;
        private System.Windows.Forms.TextBox grasasTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

