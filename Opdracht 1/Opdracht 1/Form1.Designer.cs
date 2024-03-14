namespace Opdracht_1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.overzicht = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioBox = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.naam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.aantalDeelnemerslabel = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.overzicht.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.radioBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Onderzoek gezondheid medestudenten";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.overzicht);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Location = new System.Drawing.Point(12, 66);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(659, 361);
            this.tabControlMain.TabIndex = 1;
            // 
            // overzicht
            // 
            this.overzicht.Controls.Add(this.aantalDeelnemerslabel);
            this.overzicht.Controls.Add(this.label7);
            this.overzicht.Controls.Add(this.label6);
            this.overzicht.Location = new System.Drawing.Point(4, 25);
            this.overzicht.Name = "overzicht";
            this.overzicht.Padding = new System.Windows.Forms.Padding(3);
            this.overzicht.Size = new System.Drawing.Size(651, 332);
            this.overzicht.TabIndex = 0;
            this.overzicht.Text = "overzicht";
            this.overzicht.UseVisualStyleBackColor = true;
            this.overzicht.Click += new System.EventHandler(this.overzicht_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.radioBox);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.naam);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(651, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "deelname";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // radioBox
            // 
            this.radioBox.Controls.Add(this.radioButton3);
            this.radioBox.Controls.Add(this.radioButton5);
            this.radioBox.Controls.Add(this.radioButton2);
            this.radioBox.Controls.Add(this.radioButton4);
            this.radioBox.Location = new System.Drawing.Point(259, 139);
            this.radioBox.Name = "radioBox";
            this.radioBox.Size = new System.Drawing.Size(214, 49);
            this.radioBox.TabIndex = 15;
            this.radioBox.TabStop = false;
            this.radioBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(65, 21);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(35, 20);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "2";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(150, 21);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(35, 20);
            this.radioButton5.TabIndex = 12;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "4";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(35, 20);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "1";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(106, 21);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(35, 20);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "3";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 keer",
            "2 keer",
            "3 keer",
            "4 keer"});
            this.comboBox1.Location = new System.Drawing.Point(259, 192);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(259, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Verzenden";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // naam
            // 
            this.naam.Location = new System.Drawing.Point(259, 111);
            this.naam.Name = "naam";
            this.naam.Size = new System.Drawing.Size(214, 22);
            this.naam.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hoeveel sport je in de week?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hoeveel fruit eet je per dag?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Wat is je naam?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "vul hieronder je gegevens in";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Overzicht resultaten";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Aantal deelnemers:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // aantalDeelnemerslabel
            // 
            this.aantalDeelnemerslabel.AutoSize = true;
            this.aantalDeelnemerslabel.Location = new System.Drawing.Point(155, 51);
            this.aantalDeelnemerslabel.Name = "aantalDeelnemerslabel";
            this.aantalDeelnemerslabel.Size = new System.Drawing.Size(14, 16);
            this.aantalDeelnemerslabel.TabIndex = 2;
            this.aantalDeelnemerslabel.Text = "0";
            this.aantalDeelnemerslabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Leefstijl onderzoek";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlMain.ResumeLayout(false);
            this.overzicht.ResumeLayout(false);
            this.overzicht.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.radioBox.ResumeLayout(false);
            this.radioBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage overzicht;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox naam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox radioBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label aantalDeelnemerslabel;
    }
}

