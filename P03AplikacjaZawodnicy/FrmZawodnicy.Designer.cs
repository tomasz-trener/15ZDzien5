﻿namespace P03AplikacjaZawodnicy
{
    partial class FrmZawodnicy
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
            this.lbDane = new System.Windows.Forms.ListBox();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLicznaZaimportowanychDanych = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKraj = new System.Windows.Forms.TextBox();
            this.btnSzczegoly = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(12, 81);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(279, 303);
            this.lbDane.TabIndex = 0;
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(12, 13);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zaimportowano rekordów:";
            // 
            // lblLicznaZaimportowanychDanych
            // 
            this.lblLicznaZaimportowanychDanych.AutoSize = true;
            this.lblLicznaZaimportowanychDanych.Location = new System.Drawing.Point(227, 19);
            this.lblLicznaZaimportowanychDanych.Name = "lblLicznaZaimportowanychDanych";
            this.lblLicznaZaimportowanychDanych.Size = new System.Drawing.Size(13, 13);
            this.lblLicznaZaimportowanychDanych.TabIndex = 3;
            this.lblLicznaZaimportowanychDanych.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kraj";
            // 
            // txtKraj
            // 
            this.txtKraj.Location = new System.Drawing.Point(43, 50);
            this.txtKraj.Name = "txtKraj";
            this.txtKraj.Size = new System.Drawing.Size(248, 20);
            this.txtKraj.TabIndex = 5;
            this.txtKraj.Text = "pol";
            // 
            // btnSzczegoly
            // 
            this.btnSzczegoly.Location = new System.Drawing.Point(297, 81);
            this.btnSzczegoly.Name = "btnSzczegoly";
            this.btnSzczegoly.Size = new System.Drawing.Size(75, 23);
            this.btnSzczegoly.TabIndex = 6;
            this.btnSzczegoly.Text = "Szczegóły";
            this.btnSzczegoly.UseVisualStyleBackColor = true;
            this.btnSzczegoly.Click += new System.EventHandler(this.btnSzczegoly_Click);
            // 
            // FrmZawodnicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 397);
            this.Controls.Add(this.btnSzczegoly);
            this.Controls.Add(this.txtKraj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLicznaZaimportowanychDanych);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.lbDane);
            this.Name = "FrmZawodnicy";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLicznaZaimportowanychDanych;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKraj;
        private System.Windows.Forms.Button btnSzczegoly;
    }
}

