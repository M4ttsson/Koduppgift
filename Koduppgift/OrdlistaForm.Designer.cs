namespace Koduppgift
{
    partial class OrdlistaForm
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
            this.tbLista = new System.Windows.Forms.TextBox();
            this.bBokOrdning = new System.Windows.Forms.Button();
            this.bLangd = new System.Windows.Forms.Button();
            this.bVokal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLista
            // 
            this.tbLista.AcceptsReturn = true;
            this.tbLista.Location = new System.Drawing.Point(12, 12);
            this.tbLista.Multiline = true;
            this.tbLista.Name = "tbLista";
            this.tbLista.Size = new System.Drawing.Size(183, 268);
            this.tbLista.TabIndex = 0;
            // 
            // bBokOrdning
            // 
            this.bBokOrdning.Location = new System.Drawing.Point(201, 12);
            this.bBokOrdning.Name = "bBokOrdning";
            this.bBokOrdning.Size = new System.Drawing.Size(182, 29);
            this.bBokOrdning.TabIndex = 1;
            this.bBokOrdning.Text = "Bokstavsordning";
            this.bBokOrdning.UseVisualStyleBackColor = true;
            this.bBokOrdning.Click += new System.EventHandler(this.bBokOrdning_Click);
            // 
            // bLangd
            // 
            this.bLangd.Location = new System.Drawing.Point(201, 47);
            this.bLangd.Name = "bLangd";
            this.bLangd.Size = new System.Drawing.Size(182, 29);
            this.bLangd.TabIndex = 2;
            this.bLangd.Text = "Längdordning";
            this.bLangd.UseVisualStyleBackColor = true;
            this.bLangd.Click += new System.EventHandler(this.bLangd_Click);
            // 
            // bVokal
            // 
            this.bVokal.Location = new System.Drawing.Point(201, 82);
            this.bVokal.Name = "bVokal";
            this.bVokal.Size = new System.Drawing.Size(182, 29);
            this.bVokal.TabIndex = 3;
            this.bVokal.Text = "Vokalsordning";
            this.bVokal.UseVisualStyleBackColor = true;
            this.bVokal.Click += new System.EventHandler(this.bVokal_Click);
            // 
            // OrdlistaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 291);
            this.Controls.Add(this.bVokal);
            this.Controls.Add(this.bLangd);
            this.Controls.Add(this.bBokOrdning);
            this.Controls.Add(this.tbLista);
            this.Name = "OrdlistaForm";
            this.Text = "Ordlista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLista;
        private System.Windows.Forms.Button bBokOrdning;
        private System.Windows.Forms.Button bLangd;
        private System.Windows.Forms.Button bVokal;
    }
}