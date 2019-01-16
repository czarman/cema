namespace ReadFromFIle
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
            this.DaneOsobowe = new System.Windows.Forms.Label();
            this.DaneFinansowe = new System.Windows.Forms.Label();
            this.PersonFilePath = new System.Windows.Forms.TextBox();
            this.FinanseFilePath = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PlikOsobowy = new System.Windows.Forms.Button();
            this.PlikFinansowy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DaneOsobowe
            // 
            this.DaneOsobowe.AutoSize = true;
            this.DaneOsobowe.Location = new System.Drawing.Point(26, 31);
            this.DaneOsobowe.Name = "DaneOsobowe";
            this.DaneOsobowe.Size = new System.Drawing.Size(81, 13);
            this.DaneOsobowe.TabIndex = 0;
            this.DaneOsobowe.Text = "Dane Osobowe";
            // 
            // DaneFinansowe
            // 
            this.DaneFinansowe.AutoSize = true;
            this.DaneFinansowe.Location = new System.Drawing.Point(23, 123);
            this.DaneFinansowe.Name = "DaneFinansowe";
            this.DaneFinansowe.Size = new System.Drawing.Size(87, 13);
            this.DaneFinansowe.TabIndex = 1;
            this.DaneFinansowe.Text = "Dane Finansowe";
            // 
            // PersonFilePath
            // 
            this.PersonFilePath.Location = new System.Drawing.Point(29, 88);
            this.PersonFilePath.Name = "PersonFilePath";
            this.PersonFilePath.Size = new System.Drawing.Size(272, 20);
            this.PersonFilePath.TabIndex = 2;
            // 
            // FinanseFilePath
            // 
            this.FinanseFilePath.Location = new System.Drawing.Point(26, 178);
            this.FinanseFilePath.Name = "FinanseFilePath";
            this.FinanseFilePath.Size = new System.Drawing.Size(272, 20);
            this.FinanseFilePath.TabIndex = 3;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(63, 228);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(192, 23);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start!";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PlikOsobowy
            // 
            this.PlikOsobowy.Location = new System.Drawing.Point(29, 61);
            this.PlikOsobowy.Name = "PlikOsobowy";
            this.PlikOsobowy.Size = new System.Drawing.Size(109, 21);
            this.PlikOsobowy.TabIndex = 5;
            this.PlikOsobowy.Text = "Wybierz plik";
            this.PlikOsobowy.UseVisualStyleBackColor = true;
            this.PlikOsobowy.Click += new System.EventHandler(this.PlikOsobowy_Click);
            // 
            // PlikFinansowy
            // 
            this.PlikFinansowy.Location = new System.Drawing.Point(26, 150);
            this.PlikFinansowy.Name = "PlikFinansowy";
            this.PlikFinansowy.Size = new System.Drawing.Size(109, 22);
            this.PlikFinansowy.TabIndex = 6;
            this.PlikFinansowy.Text = "Wybierz plik";
            this.PlikFinansowy.UseVisualStyleBackColor = true;
            this.PlikFinansowy.Click += new System.EventHandler(this.PlikFinansowy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wynik";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(60, 309);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(0, 13);
            this.Output.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 450);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlikFinansowy);
            this.Controls.Add(this.PlikOsobowy);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.FinanseFilePath);
            this.Controls.Add(this.PersonFilePath);
            this.Controls.Add(this.DaneFinansowe);
            this.Controls.Add(this.DaneOsobowe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DaneOsobowe;
        private System.Windows.Forms.Label DaneFinansowe;
        private System.Windows.Forms.TextBox PersonFilePath;
        private System.Windows.Forms.TextBox FinanseFilePath;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button PlikOsobowy;
        private System.Windows.Forms.Button PlikFinansowy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Output;
    }
}

