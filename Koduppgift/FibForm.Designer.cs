namespace Koduppgift
{
    partial class FibForm
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
            this.bOk = new System.Windows.Forms.Button();
            this.tbTal = new System.Windows.Forms.TextBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.lInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(12, 55);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 0;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // tbTal
            // 
            this.tbTal.Location = new System.Drawing.Point(12, 29);
            this.tbTal.Name = "tbTal";
            this.tbTal.Size = new System.Drawing.Size(178, 20);
            this.tbTal.TabIndex = 1;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(115, 55);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = true;
            this.lInfo.Location = new System.Drawing.Point(12, 9);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(99, 13);
            this.lInfo.TabIndex = 3;
            this.lInfo.Text = "Ange hur många tal";
            // 
            // FibForm
            // 
            this.AcceptButton = this.bOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 85);
            this.Controls.Add(this.lInfo);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.tbTal);
            this.Controls.Add(this.bOk);
            this.Name = "FibForm";
            this.Text = "Fibonacci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.TextBox tbTal;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label lInfo;
    }
}