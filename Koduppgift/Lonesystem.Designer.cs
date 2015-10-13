namespace Koduppgift
{
    partial class Lonesystem
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
            this.bAvg = new System.Windows.Forms.Button();
            this.bGrowth = new System.Windows.Forms.Button();
            this.lbAvg = new System.Windows.Forms.ListBox();
            this.bIncrease = new System.Windows.Forms.Button();
            this.bDifference = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.lbGrowth = new System.Windows.Forms.ListBox();
            this.lbIncrease = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bAvg
            // 
            this.bAvg.Location = new System.Drawing.Point(138, 28);
            this.bAvg.Name = "bAvg";
            this.bAvg.Size = new System.Drawing.Size(168, 54);
            this.bAvg.TabIndex = 2;
            this.bAvg.Text = "Genomsnitts- och Medianlön";
            this.bAvg.UseVisualStyleBackColor = true;
            this.bAvg.Click += new System.EventHandler(this.bAvg_Click);
            // 
            // bGrowth
            // 
            this.bGrowth.Location = new System.Drawing.Point(138, 116);
            this.bGrowth.Name = "bGrowth";
            this.bGrowth.Size = new System.Drawing.Size(168, 55);
            this.bGrowth.TabIndex = 4;
            this.bGrowth.Text = "Genomsnittlig ökning";
            this.bGrowth.UseVisualStyleBackColor = true;
            this.bGrowth.Click += new System.EventHandler(this.bGrowth_Click);
            // 
            // lbAvg
            // 
            this.lbAvg.FormattingEnabled = true;
            this.lbAvg.ItemHeight = 16;
            this.lbAvg.Location = new System.Drawing.Point(12, 12);
            this.lbAvg.Name = "lbAvg";
            this.lbAvg.Size = new System.Drawing.Size(120, 84);
            this.lbAvg.TabIndex = 4;
            // 
            // bIncrease
            // 
            this.bIncrease.Location = new System.Drawing.Point(138, 253);
            this.bIncrease.Name = "bIncrease";
            this.bIncrease.Size = new System.Drawing.Size(168, 71);
            this.bIncrease.TabIndex = 5;
            this.bIncrease.Text = "Beräkna ökning på 5 år för att få samma genomsnitt";
            this.bIncrease.UseVisualStyleBackColor = true;
            this.bIncrease.Click += new System.EventHandler(this.bIncrease_Click);
            // 
            // bDifference
            // 
            this.bDifference.Location = new System.Drawing.Point(12, 192);
            this.bDifference.Name = "bDifference";
            this.bDifference.Size = new System.Drawing.Size(120, 42);
            this.bDifference.TabIndex = 6;
            this.bDifference.Text = "Störst skillnad";
            this.bDifference.UseVisualStyleBackColor = true;
            this.bDifference.Click += new System.EventHandler(this.bDifference_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(224, 385);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(82, 33);
            this.bSave.TabIndex = 7;
            this.bSave.Text = "Spara";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // lbGrowth
            // 
            this.lbGrowth.FormattingEnabled = true;
            this.lbGrowth.ItemHeight = 16;
            this.lbGrowth.Location = new System.Drawing.Point(12, 102);
            this.lbGrowth.Name = "lbGrowth";
            this.lbGrowth.Size = new System.Drawing.Size(120, 84);
            this.lbGrowth.TabIndex = 8;
            // 
            // lbIncrease
            // 
            this.lbIncrease.FormattingEnabled = true;
            this.lbIncrease.ItemHeight = 16;
            this.lbIncrease.Location = new System.Drawing.Point(12, 240);
            this.lbIncrease.Name = "lbIncrease";
            this.lbIncrease.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbIncrease.Size = new System.Drawing.Size(120, 84);
            this.lbIncrease.TabIndex = 9;
            // 
            // Lonesystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 430);
            this.Controls.Add(this.lbIncrease);
            this.Controls.Add(this.lbGrowth);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bDifference);
            this.Controls.Add(this.bIncrease);
            this.Controls.Add(this.lbAvg);
            this.Controls.Add(this.bGrowth);
            this.Controls.Add(this.bAvg);
            this.Name = "Lonesystem";
            this.Text = "Lonesystem";
            this.Load += new System.EventHandler(this.Lonesystem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAvg;
        private System.Windows.Forms.Button bGrowth;
        private System.Windows.Forms.ListBox lbAvg;
        private System.Windows.Forms.Button bIncrease;
        private System.Windows.Forms.Button bDifference;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.ListBox lbGrowth;
        private System.Windows.Forms.ListBox lbIncrease;

    }
}