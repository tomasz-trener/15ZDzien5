﻿namespace P02KomunikacjaPomiedzyFormularzami
{
    partial class FrmSzczegoly
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
            this.btnWyslij = new System.Windows.Forms.Button();
            this.txtDane = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnWyslij
            // 
            this.btnWyslij.Location = new System.Drawing.Point(37, 97);
            this.btnWyslij.Name = "btnWyslij";
            this.btnWyslij.Size = new System.Drawing.Size(75, 23);
            this.btnWyslij.TabIndex = 4;
            this.btnWyslij.Text = "Wyślij";
            this.btnWyslij.UseVisualStyleBackColor = true;
            this.btnWyslij.Click += new System.EventHandler(this.btnWyslij_Click);
            // 
            // txtDane
            // 
            this.txtDane.Location = new System.Drawing.Point(12, 71);
            this.txtDane.Name = "txtDane";
            this.txtDane.Size = new System.Drawing.Size(100, 20);
            this.txtDane.TabIndex = 3;
            // 
            // FrmSzczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 230);
            this.Controls.Add(this.btnWyslij);
            this.Controls.Add(this.txtDane);
            this.Name = "FrmSzczegoly";
            this.Text = "FrmSzczegoly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWyslij;
        private System.Windows.Forms.TextBox txtDane;
    }
}