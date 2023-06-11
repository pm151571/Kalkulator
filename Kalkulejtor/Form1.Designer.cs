namespace Kalkulejtor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            label1 = new Label();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            b1 = new Button();
            bPerc = new Button();
            bBckS = new Button();
            bDziel = new Button();
            bPierwzX = new Button();
            bxkw = new Button();
            b1nax = new Button();
            b2 = new Button();
            bMinus = new Button();
            b6 = new Button();
            b5 = new Button();
            b4 = new Button();
            bPlus = new Button();
            bMn = new Button();
            b9 = new Button();
            b8 = new Button();
            b7 = new Button();
            b3 = new Button();
            bEquals = new Button();
            bComa = new Button();
            b0 = new Button();
            bZmianaZnaku = new Button();
            bSin = new Button();
            bLn = new Button();
            bLog = new Button();
            bCos = new Button();
            bE = new Button();
            bPi = new Button();
            bTan = new Button();
            bAns = new Button();
            bExp = new Button();
            bXdoy = new Button();
            bSilnia = new Button();
            bprawy = new Button();
            blewy = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 60);
            listView1.Name = "listView1";
            listView1.Size = new Size(167, 359);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 1;
            label1.Text = "Historia";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(208, 18);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(112, 29);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Naukowy";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(266, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(399, 31);
            textBox1.TabIndex = 3;
            // 
            // b1
            // 
            b1.Location = new Point(428, 333);
            b1.Name = "b1";
            b1.Size = new Size(75, 65);
            b1.TabIndex = 4;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // bPerc
            // 
            bPerc.Location = new Point(590, 120);
            bPerc.Name = "bPerc";
            bPerc.Size = new Size(75, 65);
            bPerc.TabIndex = 5;
            bPerc.Text = "%";
            bPerc.UseVisualStyleBackColor = true;
            bPerc.Click += bPerc_Click;
            // 
            // bBckS
            // 
            bBckS.Location = new Point(669, 120);
            bBckS.Name = "bBckS";
            bBckS.Size = new Size(75, 65);
            bBckS.TabIndex = 8;
            bBckS.Text = "<-";
            bBckS.UseVisualStyleBackColor = true;
            bBckS.Click += bBckS_Click;
            // 
            // bDziel
            // 
            bDziel.Location = new Point(671, 191);
            bDziel.Name = "bDziel";
            bDziel.Size = new Size(75, 65);
            bDziel.TabIndex = 13;
            bDziel.Text = "/";
            bDziel.UseVisualStyleBackColor = true;
            bDziel.Click += bDziel_Click;
            // 
            // bPierwzX
            // 
            bPierwzX.Location = new Point(347, 333);
            bPierwzX.Name = "bPierwzX";
            bPierwzX.Size = new Size(75, 65);
            bPierwzX.TabIndex = 12;
            bPierwzX.Text = "PIERW z x";
            bPierwzX.UseVisualStyleBackColor = true;
            bPierwzX.Click += bPierwzX_Click;
            // 
            // bxkw
            // 
            bxkw.Location = new Point(347, 262);
            bxkw.Name = "bxkw";
            bxkw.Size = new Size(75, 65);
            bxkw.TabIndex = 11;
            bxkw.Text = "x^2";
            bxkw.UseVisualStyleBackColor = true;
            bxkw.Click += bxkw_Click;
            // 
            // b1nax
            // 
            b1nax.Location = new Point(347, 191);
            b1nax.Name = "b1nax";
            b1nax.Size = new Size(75, 65);
            b1nax.TabIndex = 10;
            b1nax.Text = "1/x";
            b1nax.UseVisualStyleBackColor = true;
            b1nax.Click += b1nax_Click;
            // 
            // b2
            // 
            b2.Location = new Point(509, 333);
            b2.Name = "b2";
            b2.Size = new Size(75, 65);
            b2.TabIndex = 9;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // bMinus
            // 
            bMinus.Location = new Point(671, 333);
            bMinus.Name = "bMinus";
            bMinus.Size = new Size(75, 65);
            bMinus.TabIndex = 23;
            bMinus.Text = "-";
            bMinus.UseVisualStyleBackColor = true;
            bMinus.Click += bMinus_Click;
            // 
            // b6
            // 
            b6.Location = new Point(590, 262);
            b6.Name = "b6";
            b6.Size = new Size(75, 65);
            b6.TabIndex = 22;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = true;
            b6.Click += b6_Click;
            // 
            // b5
            // 
            b5.Location = new Point(509, 262);
            b5.Name = "b5";
            b5.Size = new Size(75, 65);
            b5.TabIndex = 21;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = true;
            b5.Click += b5_Click;
            // 
            // b4
            // 
            b4.Location = new Point(428, 262);
            b4.Name = "b4";
            b4.Size = new Size(75, 65);
            b4.TabIndex = 20;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = true;
            b4.Click += b4_Click;
            // 
            // bPlus
            // 
            bPlus.Location = new Point(671, 404);
            bPlus.Name = "bPlus";
            bPlus.Size = new Size(75, 65);
            bPlus.TabIndex = 19;
            bPlus.Text = "+";
            bPlus.UseVisualStyleBackColor = true;
            bPlus.Click += bPlus_Click;
            // 
            // bMn
            // 
            bMn.Location = new Point(671, 262);
            bMn.Name = "bMn";
            bMn.Size = new Size(75, 65);
            bMn.TabIndex = 18;
            bMn.Text = "*";
            bMn.UseVisualStyleBackColor = true;
            bMn.Click += bMn_Click;
            // 
            // b9
            // 
            b9.Location = new Point(590, 191);
            b9.Name = "b9";
            b9.Size = new Size(75, 65);
            b9.TabIndex = 17;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = true;
            b9.Click += b9_Click;
            // 
            // b8
            // 
            b8.Location = new Point(509, 191);
            b8.Name = "b8";
            b8.Size = new Size(75, 65);
            b8.TabIndex = 16;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = true;
            b8.Click += b8_Click;
            // 
            // b7
            // 
            b7.Location = new Point(428, 191);
            b7.Name = "b7";
            b7.Size = new Size(75, 65);
            b7.TabIndex = 15;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = true;
            b7.Click += b7_Click;
            // 
            // b3
            // 
            b3.Location = new Point(590, 333);
            b3.Name = "b3";
            b3.Size = new Size(75, 65);
            b3.TabIndex = 14;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // bEquals
            // 
            bEquals.Location = new Point(590, 404);
            bEquals.Name = "bEquals";
            bEquals.Size = new Size(75, 65);
            bEquals.TabIndex = 27;
            bEquals.Text = "=";
            bEquals.UseVisualStyleBackColor = true;
            bEquals.Click += bEquals_Click;
            // 
            // bComa
            // 
            bComa.Location = new Point(509, 404);
            bComa.Name = "bComa";
            bComa.Size = new Size(75, 65);
            bComa.TabIndex = 26;
            bComa.Text = ".";
            bComa.UseVisualStyleBackColor = true;
            bComa.Click += bComa_Click;
            // 
            // b0
            // 
            b0.Location = new Point(428, 404);
            b0.Name = "b0";
            b0.Size = new Size(75, 65);
            b0.TabIndex = 25;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = true;
            b0.Click += b0_Click;
            // 
            // bZmianaZnaku
            // 
            bZmianaZnaku.Location = new Point(659, 485);
            bZmianaZnaku.Name = "bZmianaZnaku";
            bZmianaZnaku.Size = new Size(75, 65);
            bZmianaZnaku.TabIndex = 24;
            bZmianaZnaku.Text = "+/-";
            bZmianaZnaku.UseVisualStyleBackColor = true;
            bZmianaZnaku.Click += bZmianaZnaku_Click;
            // 
            // bSin
            // 
            bSin.BackColor = SystemColors.ActiveCaption;
            bSin.Location = new Point(185, 191);
            bSin.Name = "bSin";
            bSin.Size = new Size(75, 65);
            bSin.TabIndex = 28;
            bSin.Text = "sin";
            bSin.UseVisualStyleBackColor = false;
            bSin.Visible = false;
            bSin.EnabledChanged += checkBox1_CheckedChanged;
            bSin.Click += bSin_Click;
            // 
            // bLn
            // 
            bLn.BackColor = SystemColors.ActiveCaption;
            bLn.Location = new Point(266, 191);
            bLn.Name = "bLn";
            bLn.Size = new Size(75, 65);
            bLn.TabIndex = 29;
            bLn.Text = "ln";
            bLn.UseVisualStyleBackColor = false;
            bLn.Visible = false;
            bLn.EnabledChanged += checkBox1_CheckedChanged;
            bLn.Click += bLn_Click;
            // 
            // bLog
            // 
            bLog.BackColor = SystemColors.ActiveCaption;
            bLog.Location = new Point(266, 262);
            bLog.Name = "bLog";
            bLog.Size = new Size(75, 65);
            bLog.TabIndex = 31;
            bLog.Text = "log";
            bLog.UseVisualStyleBackColor = false;
            bLog.Visible = false;
            bLog.EnabledChanged += checkBox1_CheckedChanged;
            bLog.Click += bLog_Click;
            // 
            // bCos
            // 
            bCos.BackColor = SystemColors.ActiveCaption;
            bCos.Location = new Point(185, 262);
            bCos.Name = "bCos";
            bCos.Size = new Size(75, 65);
            bCos.TabIndex = 30;
            bCos.Text = "cos";
            bCos.UseVisualStyleBackColor = false;
            bCos.Visible = false;
            bCos.EnabledChanged += checkBox1_CheckedChanged;
            bCos.Click += bCos_Click;
            // 
            // bE
            // 
            bE.BackColor = SystemColors.ActiveCaption;
            bE.Location = new Point(185, 404);
            bE.Name = "bE";
            bE.Size = new Size(75, 65);
            bE.TabIndex = 33;
            bE.Text = "e";
            bE.UseVisualStyleBackColor = false;
            bE.Visible = false;
            bE.EnabledChanged += checkBox1_CheckedChanged;
            bE.Click += bE_Click;
            // 
            // bPi
            // 
            bPi.BackColor = SystemColors.ActiveCaption;
            bPi.Location = new Point(185, 333);
            bPi.Name = "bPi";
            bPi.Size = new Size(75, 65);
            bPi.TabIndex = 32;
            bPi.Text = "pi";
            bPi.UseVisualStyleBackColor = false;
            bPi.Visible = false;
            bPi.EnabledChanged += checkBox1_CheckedChanged;
            bPi.Click += bPi_Click;
            // 
            // bTan
            // 
            bTan.BackColor = SystemColors.ActiveCaption;
            bTan.Location = new Point(266, 404);
            bTan.Name = "bTan";
            bTan.Size = new Size(75, 65);
            bTan.TabIndex = 34;
            bTan.Text = "tan";
            bTan.UseVisualStyleBackColor = false;
            bTan.Visible = false;
            bTan.Click += bTan_Click;
            // 
            // bAns
            // 
            bAns.BackColor = SystemColors.ActiveCaption;
            bAns.Location = new Point(347, 546);
            bAns.Name = "bAns";
            bAns.Size = new Size(75, 65);
            bAns.TabIndex = 35;
            bAns.Text = "Ans";
            bAns.UseVisualStyleBackColor = false;
            bAns.Click += bAns_Click;
            // 
            // bExp
            // 
            bExp.BackColor = SystemColors.ActiveCaption;
            bExp.Location = new Point(428, 546);
            bExp.Name = "bExp";
            bExp.Size = new Size(75, 65);
            bExp.TabIndex = 36;
            bExp.Text = "EXP";
            bExp.UseVisualStyleBackColor = false;
            bExp.Click += bExp_Click;
            // 
            // bXdoy
            // 
            bXdoy.BackColor = SystemColors.ActiveCaption;
            bXdoy.Location = new Point(347, 404);
            bXdoy.Name = "bXdoy";
            bXdoy.Size = new Size(75, 65);
            bXdoy.TabIndex = 37;
            bXdoy.Text = "x^y";
            bXdoy.UseVisualStyleBackColor = false;
            bXdoy.Visible = false;
            bXdoy.Click += bXdoy_Click;
            // 
            // bSilnia
            // 
            bSilnia.BackColor = SystemColors.ActiveCaption;
            bSilnia.Location = new Point(266, 333);
            bSilnia.Name = "bSilnia";
            bSilnia.Size = new Size(75, 65);
            bSilnia.TabIndex = 38;
            bSilnia.Text = "x!";
            bSilnia.UseVisualStyleBackColor = false;
            bSilnia.Visible = false;
            bSilnia.Click += bSilnia_Click;
            // 
            // bprawy
            // 
            bprawy.Location = new Point(509, 120);
            bprawy.Name = "bprawy";
            bprawy.Size = new Size(75, 65);
            bprawy.TabIndex = 39;
            bprawy.Text = ")";
            bprawy.UseVisualStyleBackColor = true;
            bprawy.Click += bprawy_Click;
            // 
            // blewy
            // 
            blewy.Location = new Point(428, 120);
            blewy.Name = "blewy";
            blewy.Size = new Size(75, 65);
            blewy.TabIndex = 40;
            blewy.Text = "(";
            blewy.UseVisualStyleBackColor = true;
            blewy.Click += blewy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 635);
            Controls.Add(blewy);
            Controls.Add(bprawy);
            Controls.Add(bSilnia);
            Controls.Add(bXdoy);
            Controls.Add(bExp);
            Controls.Add(bAns);
            Controls.Add(bTan);
            Controls.Add(bE);
            Controls.Add(bPi);
            Controls.Add(bLog);
            Controls.Add(bCos);
            Controls.Add(bLn);
            Controls.Add(bSin);
            Controls.Add(bEquals);
            Controls.Add(bComa);
            Controls.Add(b0);
            Controls.Add(bZmianaZnaku);
            Controls.Add(bMinus);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(bPlus);
            Controls.Add(bMn);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b7);
            Controls.Add(b3);
            Controls.Add(bDziel);
            Controls.Add(bPierwzX);
            Controls.Add(bxkw);
            Controls.Add(b1nax);
            Controls.Add(b2);
            Controls.Add(bBckS);
            Controls.Add(bPerc);
            Controls.Add(b1);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Kalkulator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private Button b1;
        private Button bPerc;
        private Button bBckS;
        private Button bDziel;
        private Button bPierwzX;
        private Button bxkw;
        private Button b1nax;
        private Button b2;
        private Button bMinus;
        private Button b6;
        private Button b5;
        private Button b4;
        private Button bPlus;
        private Button bMn;
        private Button b9;
        private Button b8;
        private Button b7;
        private Button b3;
        private Button bEquals;
        private Button bComa;
        private Button b0;
        private Button bZmianaZnaku;
        private Button bSin;
        private Button bLn;
        private Button bLog;
        private Button bCos;
        private Button bE;
        private Button bPi;
        private Button bTan;
        private Button bAns;
        private Button bExp;
        private Button bXdoy;
        private Button bSilnia;
        private Button bprawy;
        private Button blewy;
    }
}