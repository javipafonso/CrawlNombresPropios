namespace CrawlNombresPropios
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rMas = new System.Windows.Forms.RadioButton();
            this.rFem = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Obtener";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // textURL
            // 
            this.textURL.Location = new System.Drawing.Point(71, 10);
            this.textURL.Name = "textURL";
            this.textURL.Size = new System.Drawing.Size(356, 20);
            this.textURL.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Genero";
            // 
            // rMas
            // 
            this.rMas.AutoSize = true;
            this.rMas.Location = new System.Drawing.Point(90, 49);
            this.rMas.Name = "rMas";
            this.rMas.Size = new System.Drawing.Size(73, 17);
            this.rMas.TabIndex = 4;
            this.rMas.TabStop = true;
            this.rMas.Text = "Masculino";
            this.rMas.UseVisualStyleBackColor = true;
            // 
            // rFem
            // 
            this.rFem.AutoSize = true;
            this.rFem.Location = new System.Drawing.Point(188, 49);
            this.rFem.Name = "rFem";
            this.rFem.Size = new System.Drawing.Size(71, 17);
            this.rFem.TabIndex = 5;
            this.rFem.TabStop = true;
            this.rFem.Text = "Femenino";
            this.rFem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Matches";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 124);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rFem);
            this.Controls.Add(this.rMas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rMas;
        private System.Windows.Forms.RadioButton rFem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

