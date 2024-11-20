namespace Vozilooo
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
            this.txtMarka = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.Label();
            this.txtGodinaProizvodnje = new System.Windows.Forms.Label();
            this.txtKilometraza = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtDodajVozilo = new System.Windows.Forms.Button();
            this.txtSortitaj = new System.Windows.Forms.Button();
            this.listBoxVozila = new System.Windows.Forms.ListBox();
            this.comboBoxSortiranje = new System.Windows.Forms.ComboBox();
            this.txtObrisiVozilo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMarka
            // 
            this.txtMarka.AutoSize = true;
            this.txtMarka.Location = new System.Drawing.Point(34, 35);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(53, 20);
            this.txtMarka.TabIndex = 0;
            this.txtMarka.Text = "Marka";
            // 
            // txtModel
            // 
            this.txtModel.AutoSize = true;
            this.txtModel.Location = new System.Drawing.Point(34, 74);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(52, 20);
            this.txtModel.TabIndex = 1;
            this.txtModel.Text = "Model";
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.AutoSize = true;
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(34, 118);
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(142, 20);
            this.txtGodinaProizvodnje.TabIndex = 2;
            this.txtGodinaProizvodnje.Text = "GodinaProizvodnje";
            // 
            // txtKilometraza
            // 
            this.txtKilometraza.AutoSize = true;
            this.txtKilometraza.Location = new System.Drawing.Point(34, 168);
            this.txtKilometraza.Name = "txtKilometraza";
            this.txtKilometraza.Size = new System.Drawing.Size(92, 20);
            this.txtKilometraza.TabIndex = 3;
            this.txtKilometraza.Text = "Kilometraza";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(182, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(182, 162);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 7;
            // 
            // txtDodajVozilo
            // 
            this.txtDodajVozilo.Location = new System.Drawing.Point(27, 224);
            this.txtDodajVozilo.Name = "txtDodajVozilo";
            this.txtDodajVozilo.Size = new System.Drawing.Size(111, 31);
            this.txtDodajVozilo.TabIndex = 8;
            this.txtDodajVozilo.Text = "DodajVozilo";
            this.txtDodajVozilo.UseVisualStyleBackColor = true;
            this.txtDodajVozilo.Click += new System.EventHandler(this.txtDodajVozilo_Click);
            // 
            // txtSortitaj
            // 
            this.txtSortitaj.Location = new System.Drawing.Point(438, 103);
            this.txtSortitaj.Name = "txtSortitaj";
            this.txtSortitaj.Size = new System.Drawing.Size(75, 23);
            this.txtSortitaj.TabIndex = 9;
            this.txtSortitaj.Text = "Sortiraj";
            this.txtSortitaj.UseVisualStyleBackColor = true;
            this.txtSortitaj.Click += new System.EventHandler(this.txtSortitaj_Click);
            // 
            // listBoxVozila
            // 
            this.listBoxVozila.FormattingEnabled = true;
            this.listBoxVozila.ItemHeight = 20;
            this.listBoxVozila.Location = new System.Drawing.Point(27, 298);
            this.listBoxVozila.Name = "listBoxVozila";
            this.listBoxVozila.Size = new System.Drawing.Size(120, 84);
            this.listBoxVozila.TabIndex = 10;
            this.listBoxVozila.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBoxSortiranje
            // 
            this.comboBoxSortiranje.FormattingEnabled = true;
            this.comboBoxSortiranje.Location = new System.Drawing.Point(452, 218);
            this.comboBoxSortiranje.Name = "comboBoxSortiranje";
            this.comboBoxSortiranje.Size = new System.Drawing.Size(121, 28);
            this.comboBoxSortiranje.TabIndex = 11;
            // 
            // txtObrisiVozilo
            // 
            this.txtObrisiVozilo.Location = new System.Drawing.Point(182, 224);
            this.txtObrisiVozilo.Name = "txtObrisiVozilo";
            this.txtObrisiVozilo.Size = new System.Drawing.Size(109, 31);
            this.txtObrisiVozilo.TabIndex = 12;
            this.txtObrisiVozilo.Text = "ObrisiVozilo";
            this.txtObrisiVozilo.UseVisualStyleBackColor = true;
            this.txtObrisiVozilo.Click += new System.EventHandler(this.txtObrisiVozilo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtObrisiVozilo);
            this.Controls.Add(this.comboBoxSortiranje);
            this.Controls.Add(this.listBoxVozila);
            this.Controls.Add(this.txtSortitaj);
            this.Controls.Add(this.txtDodajVozilo);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtKilometraza);
            this.Controls.Add(this.txtGodinaProizvodnje);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtMarka;
        private System.Windows.Forms.Label txtModel;
        private System.Windows.Forms.Label txtGodinaProizvodnje;
        private System.Windows.Forms.Label txtKilometraza;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button txtDodajVozilo;
        private System.Windows.Forms.Button txtSortitaj;
        private System.Windows.Forms.ListBox listBoxVozila;
        private System.Windows.Forms.ComboBox comboBoxSortiranje;
        private System.Windows.Forms.Button txtObrisiVozilo;
    }
}

