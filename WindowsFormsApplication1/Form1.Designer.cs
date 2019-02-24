namespace WindowsFormsApplication1
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
            this.rtbdane = new System.Windows.Forms.RichTextBox();
            this.lsttab1 = new System.Windows.Forms.ListBox();
            this.lsttab2 = new System.Windows.Forms.ListBox();
            this.lstwyn = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsort = new System.Windows.Forms.Button();
            this.btnczyt = new System.Windows.Forms.Button();
            this.czysc = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.obliczToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.średniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liczWiekszeOdSrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wartośćMAXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wartośćMINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iloścLiczbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblsrednia = new System.Windows.Forms.Label();
            this.lblsuma = new System.Windows.Forms.Label();
            this.lstlis = new System.Windows.Forms.ListBox();
            this.lstdane = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblmax = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblliczby = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbdane
            // 
            this.rtbdane.Location = new System.Drawing.Point(21, 48);
            this.rtbdane.Name = "rtbdane";
            this.rtbdane.Size = new System.Drawing.Size(101, 110);
            this.rtbdane.TabIndex = 0;
            this.rtbdane.Text = "";
            // 
            // lsttab1
            // 
            this.lsttab1.FormattingEnabled = true;
            this.lsttab1.Location = new System.Drawing.Point(158, 48);
            this.lsttab1.Name = "lsttab1";
            this.lsttab1.Size = new System.Drawing.Size(102, 108);
            this.lsttab1.TabIndex = 1;
            // 
            // lsttab2
            // 
            this.lsttab2.FormattingEnabled = true;
            this.lsttab2.Location = new System.Drawing.Point(293, 48);
            this.lsttab2.Name = "lsttab2";
            this.lsttab2.Size = new System.Drawing.Size(102, 108);
            this.lsttab2.TabIndex = 2;
            // 
            // lstwyn
            // 
            this.lstwyn.FormattingEnabled = true;
            this.lstwyn.Location = new System.Drawing.Point(434, 50);
            this.lstwyn.Name = "lstwyn";
            this.lstwyn.Size = new System.Drawing.Size(102, 108);
            this.lstwyn.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wynik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dane z tab 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dane z tab 2";
            // 
            // btnsort
            // 
            this.btnsort.Location = new System.Drawing.Point(276, 200);
            this.btnsort.Name = "btnsort";
            this.btnsort.Size = new System.Drawing.Size(119, 41);
            this.btnsort.TabIndex = 9;
            this.btnsort.Text = "Sortowanie rosnace";
            this.btnsort.UseVisualStyleBackColor = true;
            this.btnsort.Click += new System.EventHandler(this.btnsort_Click);
            // 
            // btnczyt
            // 
            this.btnczyt.Location = new System.Drawing.Point(12, 200);
            this.btnczyt.Name = "btnczyt";
            this.btnczyt.Size = new System.Drawing.Size(119, 41);
            this.btnczyt.TabIndex = 10;
            this.btnczyt.Text = "Sortowanie malejace";
            this.btnczyt.UseVisualStyleBackColor = true;
            this.btnczyt.Click += new System.EventHandler(this.btnczyt_Click);
            // 
            // czysc
            // 
            this.czysc.Location = new System.Drawing.Point(141, 200);
            this.czysc.Name = "czysc";
            this.czysc.Size = new System.Drawing.Size(119, 41);
            this.czysc.TabIndex = 11;
            this.czysc.Text = "Czyśc";
            this.czysc.UseVisualStyleBackColor = true;
            this.czysc.Click += new System.EventHandler(this.czysc_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obliczToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // obliczToolStripMenuItem
            // 
            this.obliczToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumeToolStripMenuItem,
            this.średniaToolStripMenuItem,
            this.liczWiekszeOdSrToolStripMenuItem,
            this.wartośćMAXToolStripMenuItem,
            this.wartośćMINToolStripMenuItem,
            this.iloścLiczbToolStripMenuItem});
            this.obliczToolStripMenuItem.Name = "obliczToolStripMenuItem";
            this.obliczToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.obliczToolStripMenuItem.Text = "Oblicz";
            // 
            // sumeToolStripMenuItem
            // 
            this.sumeToolStripMenuItem.Name = "sumeToolStripMenuItem";
            this.sumeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.sumeToolStripMenuItem.Text = "Sume";
            this.sumeToolStripMenuItem.Click += new System.EventHandler(this.sumeToolStripMenuItem_Click);
            // 
            // średniaToolStripMenuItem
            // 
            this.średniaToolStripMenuItem.Name = "średniaToolStripMenuItem";
            this.średniaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.średniaToolStripMenuItem.Text = "Średnia";
            this.średniaToolStripMenuItem.Click += new System.EventHandler(this.średniaToolStripMenuItem_Click);
            // 
            // liczWiekszeOdSrToolStripMenuItem
            // 
            this.liczWiekszeOdSrToolStripMenuItem.Name = "liczWiekszeOdSrToolStripMenuItem";
            this.liczWiekszeOdSrToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.liczWiekszeOdSrToolStripMenuItem.Text = "Licz. wieksze od sr";
            this.liczWiekszeOdSrToolStripMenuItem.Click += new System.EventHandler(this.liczWiekszeOdSrToolStripMenuItem_Click);
            // 
            // wartośćMAXToolStripMenuItem
            // 
            this.wartośćMAXToolStripMenuItem.Name = "wartośćMAXToolStripMenuItem";
            this.wartośćMAXToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.wartośćMAXToolStripMenuItem.Text = "Wartość MAX";
            this.wartośćMAXToolStripMenuItem.Click += new System.EventHandler(this.wartośćMAXToolStripMenuItem_Click);
            // 
            // wartośćMINToolStripMenuItem
            // 
            this.wartośćMINToolStripMenuItem.Name = "wartośćMINToolStripMenuItem";
            this.wartośćMINToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.wartośćMINToolStripMenuItem.Text = "Wartość MIN";
            this.wartośćMINToolStripMenuItem.Click += new System.EventHandler(this.wartośćMINToolStripMenuItem_Click);
            // 
            // iloścLiczbToolStripMenuItem
            // 
            this.iloścLiczbToolStripMenuItem.Name = "iloścLiczbToolStripMenuItem";
            this.iloścLiczbToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.iloścLiczbToolStripMenuItem.Text = "Ilośc liczb";
            this.iloścLiczbToolStripMenuItem.Click += new System.EventHandler(this.iloścLiczbToolStripMenuItem_Click);
            // 
            // lblsrednia
            // 
            this.lblsrednia.AutoSize = true;
            this.lblsrednia.Location = new System.Drawing.Point(505, 241);
            this.lblsrednia.Name = "lblsrednia";
            this.lblsrednia.Size = new System.Drawing.Size(0, 13);
            this.lblsrednia.TabIndex = 13;
            // 
            // lblsuma
            // 
            this.lblsuma.AutoSize = true;
            this.lblsuma.Location = new System.Drawing.Point(505, 228);
            this.lblsuma.Name = "lblsuma";
            this.lblsuma.Size = new System.Drawing.Size(0, 13);
            this.lblsuma.TabIndex = 14;
            // 
            // lstlis
            // 
            this.lstlis.FormattingEnabled = true;
            this.lstlis.Location = new System.Drawing.Point(158, 267);
            this.lstlis.Name = "lstlis";
            this.lstlis.Size = new System.Drawing.Size(85, 108);
            this.lstlis.TabIndex = 15;
            // 
            // lstdane
            // 
            this.lstdane.FormattingEnabled = true;
            this.lstdane.Location = new System.Drawing.Point(37, 267);
            this.lstdane.Name = "lstdane";
            this.lstdane.Size = new System.Drawing.Size(85, 108);
            this.lstdane.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Średnia wynosi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Liczby wieksze od sredniej";
            // 
            // lblmax
            // 
            this.lblmax.AutoSize = true;
            this.lblmax.Location = new System.Drawing.Point(505, 254);
            this.lblmax.Name = "lblmax";
            this.lblmax.Size = new System.Drawing.Size(0, 13);
            this.lblmax.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(415, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Wartość MIN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(415, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Wartość MAX :";
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Location = new System.Drawing.Point(505, 267);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(0, 13);
            this.lblmin.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(415, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Suma wynosi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ilość Liczb :";
            // 
            // lblliczby
            // 
            this.lblliczby.AutoSize = true;
            this.lblliczby.Location = new System.Drawing.Point(505, 280);
            this.lblliczby.Name = "lblliczby";
            this.lblliczby.Size = new System.Drawing.Size(0, 13);
            this.lblliczby.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Wprowadź dane";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(633, 387);
            this.Controls.Add(this.lblliczby);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblmin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblmax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstdane);
            this.Controls.Add(this.lstlis);
            this.Controls.Add(this.lblsuma);
            this.Controls.Add(this.lblsrednia);
            this.Controls.Add(this.czysc);
            this.Controls.Add(this.btnczyt);
            this.Controls.Add(this.btnsort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstwyn);
            this.Controls.Add(this.lsttab2);
            this.Controls.Add(this.lsttab1);
            this.Controls.Add(this.rtbdane);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbdane;
        private System.Windows.Forms.ListBox lsttab1;
        private System.Windows.Forms.ListBox lsttab2;
        private System.Windows.Forms.ListBox lstwyn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsort;
        private System.Windows.Forms.Button btnczyt;
        private System.Windows.Forms.Button czysc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem obliczToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem średniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iloścLiczbToolStripMenuItem;
        private System.Windows.Forms.Label lblsrednia;
        private System.Windows.Forms.Label lblsuma;
        private System.Windows.Forms.ToolStripMenuItem liczWiekszeOdSrToolStripMenuItem;
        private System.Windows.Forms.ListBox lstlis;
        private System.Windows.Forms.ListBox lstdane;
        private System.Windows.Forms.ToolStripMenuItem wartośćMAXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wartośćMINToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblmax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblliczby;
        private System.Windows.Forms.Label label5;
    }
}

