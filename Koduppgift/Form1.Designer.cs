namespace Koduppgift
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
            this.bFib = new System.Windows.Forms.Button();
            this.bOrdlista = new System.Windows.Forms.Button();
            this.bLon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bFib
            // 
            this.bFib.Location = new System.Drawing.Point(12, 12);
            this.bFib.Name = "bFib";
            this.bFib.Size = new System.Drawing.Size(217, 31);
            this.bFib.TabIndex = 0;
            this.bFib.Text = "Fibonacci";
            this.bFib.UseVisualStyleBackColor = true;
            this.bFib.Click += new System.EventHandler(this.button1_Click);
            // 
            // bOrdlista
            // 
            this.bOrdlista.Location = new System.Drawing.Point(12, 49);
            this.bOrdlista.Name = "bOrdlista";
            this.bOrdlista.Size = new System.Drawing.Size(217, 31);
            this.bOrdlista.TabIndex = 1;
            this.bOrdlista.Text = "Ordlista";
            this.bOrdlista.UseVisualStyleBackColor = true;
            this.bOrdlista.Click += new System.EventHandler(this.bOrdlista_Click);
            // 
            // bLon
            // 
            this.bLon.Location = new System.Drawing.Point(12, 86);
            this.bLon.Name = "bLon";
            this.bLon.Size = new System.Drawing.Size(217, 31);
            this.bLon.TabIndex = 2;
            this.bLon.Text = "Lönesystem";
            this.bLon.UseVisualStyleBackColor = true;
            this.bLon.Click += new System.EventHandler(this.bLon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 262);
            this.Controls.Add(this.bLon);
            this.Controls.Add(this.bOrdlista);
            this.Controls.Add(this.bFib);
            this.Name = "Form1";
            this.Text = "Arbetsprov";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bFib;
        private System.Windows.Forms.Button bOrdlista;
        private System.Windows.Forms.Button bLon;
    }
}

