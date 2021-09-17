
namespace CoresRGB
{
    partial class CoresRGB
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
            this.lblPaleta = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblNumRed = new System.Windows.Forms.Label();
            this.lblPainel = new System.Windows.Forms.Label();
            this.lblNumGreen = new System.Windows.Forms.Label();
            this.lblNumBlue = new System.Windows.Forms.Label();
            this.hScrollBarRed = new System.Windows.Forms.HScrollBar();
            this.hScrollBarBlue = new System.Windows.Forms.HScrollBar();
            this.hScrollBarGreen = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // lblPaleta
            // 
            this.lblPaleta.AutoSize = true;
            this.lblPaleta.Font = new System.Drawing.Font("Anton", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaleta.Location = new System.Drawing.Point(170, 9);
            this.lblPaleta.Name = "lblPaleta";
            this.lblPaleta.Size = new System.Drawing.Size(319, 76);
            this.lblPaleta.TabIndex = 0;
            this.lblPaleta.Text = "Paleta de Cores";
            // 
            // lblRed
            // 
            this.lblRed.BackColor = System.Drawing.Color.Red;
            this.lblRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRed.Location = new System.Drawing.Point(86, 127);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(60, 25);
            this.lblRed.TabIndex = 1;
            // 
            // lblGreen
            // 
            this.lblGreen.BackColor = System.Drawing.Color.Green;
            this.lblGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGreen.Location = new System.Drawing.Point(86, 177);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(60, 25);
            this.lblGreen.TabIndex = 2;
            // 
            // lblBlue
            // 
            this.lblBlue.BackColor = System.Drawing.Color.Blue;
            this.lblBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBlue.Location = new System.Drawing.Point(86, 231);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(60, 25);
            this.lblBlue.TabIndex = 8;
            // 
            // lblNumRed
            // 
            this.lblNumRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRed.Location = new System.Drawing.Point(196, 127);
            this.lblNumRed.Name = "lblNumRed";
            this.lblNumRed.Size = new System.Drawing.Size(62, 25);
            this.lblNumRed.TabIndex = 4;
            this.lblNumRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPainel
            // 
            this.lblPainel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPainel.Location = new System.Drawing.Point(86, 293);
            this.lblPainel.Name = "lblPainel";
            this.lblPainel.Size = new System.Drawing.Size(513, 143);
            this.lblPainel.TabIndex = 9;
            // 
            // lblNumGreen
            // 
            this.lblNumGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumGreen.Location = new System.Drawing.Point(196, 177);
            this.lblNumGreen.Name = "lblNumGreen";
            this.lblNumGreen.Size = new System.Drawing.Size(62, 25);
            this.lblNumGreen.TabIndex = 10;
            this.lblNumGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumBlue
            // 
            this.lblNumBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumBlue.Location = new System.Drawing.Point(196, 231);
            this.lblNumBlue.Name = "lblNumBlue";
            this.lblNumBlue.Size = new System.Drawing.Size(62, 25);
            this.lblNumBlue.TabIndex = 11;
            this.lblNumBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hScrollBarRed
            // 
            this.hScrollBarRed.LargeChange = 1;
            this.hScrollBarRed.Location = new System.Drawing.Point(305, 129);
            this.hScrollBarRed.Maximum = 255;
            this.hScrollBarRed.Minimum = 1;
            this.hScrollBarRed.Name = "hScrollBarRed";
            this.hScrollBarRed.Size = new System.Drawing.Size(294, 21);
            this.hScrollBarRed.TabIndex = 12;
            this.hScrollBarRed.Value = 1;
            this.hScrollBarRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarRed_Scroll);
            // 
            // hScrollBarBlue
            // 
            this.hScrollBarBlue.LargeChange = 1;
            this.hScrollBarBlue.Location = new System.Drawing.Point(305, 231);
            this.hScrollBarBlue.Maximum = 255;
            this.hScrollBarBlue.Minimum = 1;
            this.hScrollBarBlue.Name = "hScrollBarBlue";
            this.hScrollBarBlue.Size = new System.Drawing.Size(294, 21);
            this.hScrollBarBlue.TabIndex = 13;
            this.hScrollBarBlue.Value = 1;
            this.hScrollBarBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarBlue_Scroll);
            // 
            // hScrollBarGreen
            // 
            this.hScrollBarGreen.LargeChange = 1;
            this.hScrollBarGreen.Location = new System.Drawing.Point(305, 179);
            this.hScrollBarGreen.Maximum = 255;
            this.hScrollBarGreen.Minimum = 1;
            this.hScrollBarGreen.Name = "hScrollBarGreen";
            this.hScrollBarGreen.Size = new System.Drawing.Size(294, 21);
            this.hScrollBarGreen.TabIndex = 14;
            this.hScrollBarGreen.Value = 1;
            this.hScrollBarGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarGreen_Scroll);
            // 
            // CoresRGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(680, 463);
            this.Controls.Add(this.hScrollBarGreen);
            this.Controls.Add(this.hScrollBarBlue);
            this.Controls.Add(this.hScrollBarRed);
            this.Controls.Add(this.lblNumBlue);
            this.Controls.Add(this.lblNumGreen);
            this.Controls.Add(this.lblPainel);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblNumRed);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblPaleta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CoresRGB";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cores em RGB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPaleta;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblNumRed;
        private System.Windows.Forms.Label lblPainel;
        private System.Windows.Forms.Label lblNumGreen;
        private System.Windows.Forms.Label lblNumBlue;
        private System.Windows.Forms.HScrollBar hScrollBarRed;
        private System.Windows.Forms.HScrollBar hScrollBarBlue;
        private System.Windows.Forms.HScrollBar hScrollBarGreen;
    }
}

