namespace SQLTester
{
    partial class SqlTester
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
            this.components = new System.ComponentModel.Container();
            this.executeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.baseTxt = new System.Windows.Forms.TextBox();
            this.prototypeTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.optimizedTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.baseFindBtn = new System.Windows.Forms.Button();
            this.prototypeFindBtn = new System.Windows.Forms.Button();
            this.generateBtn = new System.Windows.Forms.Button();
            this.totalExecution = new System.Windows.Forms.Timer(this.components);
            this.lapExecution = new System.Windows.Forms.Timer(this.components);
            this.cyclesCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.baseTimeLbl = new System.Windows.Forms.Label();
            this.baseExecutionLbl = new System.Windows.Forms.Label();
            this.prototypeExecutionLbl = new System.Windows.Forms.Label();
            this.optimizedExecutionLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalTimeLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resultsBtn = new System.Windows.Forms.Button();
            this.resultsTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.resolveLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.serverTxt = new System.Windows.Forms.TextBox();
            this.databaseTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.cyclesCount)).BeginInit();
            this.SuspendLayout();
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(16, 260);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(75, 23);
            this.executeButton.TabIndex = 0;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Base Path or Query";
            // 
            // baseTxt
            // 
            this.baseTxt.Location = new System.Drawing.Point(16, 34);
            this.baseTxt.Name = "baseTxt";
            this.baseTxt.Size = new System.Drawing.Size(542, 20);
            this.baseTxt.TabIndex = 2;
            // 
            // prototypeTxt
            // 
            this.prototypeTxt.Location = new System.Drawing.Point(16, 87);
            this.prototypeTxt.Name = "prototypeTxt";
            this.prototypeTxt.Size = new System.Drawing.Size(542, 20);
            this.prototypeTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prototype Path or Query";
            // 
            // optimizedTxt
            // 
            this.optimizedTxt.Enabled = false;
            this.optimizedTxt.Location = new System.Drawing.Point(15, 138);
            this.optimizedTxt.Name = "optimizedTxt";
            this.optimizedTxt.Size = new System.Drawing.Size(543, 20);
            this.optimizedTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Optimized Path or Query";
            // 
            // baseFindBtn
            // 
            this.baseFindBtn.Location = new System.Drawing.Point(564, 34);
            this.baseFindBtn.Name = "baseFindBtn";
            this.baseFindBtn.Size = new System.Drawing.Size(75, 20);
            this.baseFindBtn.TabIndex = 7;
            this.baseFindBtn.Text = "Find";
            this.baseFindBtn.UseVisualStyleBackColor = true;
            this.baseFindBtn.Click += new System.EventHandler(this.baseFindBtn_Click);
            // 
            // prototypeFindBtn
            // 
            this.prototypeFindBtn.Location = new System.Drawing.Point(564, 87);
            this.prototypeFindBtn.Name = "prototypeFindBtn";
            this.prototypeFindBtn.Size = new System.Drawing.Size(75, 20);
            this.prototypeFindBtn.TabIndex = 8;
            this.prototypeFindBtn.Text = "Find";
            this.prototypeFindBtn.UseVisualStyleBackColor = true;
            this.prototypeFindBtn.Click += new System.EventHandler(this.prototypeFindBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.Enabled = false;
            this.generateBtn.Location = new System.Drawing.Point(564, 138);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(75, 20);
            this.generateBtn.TabIndex = 9;
            this.generateBtn.Text = "Generate*";
            this.generateBtn.UseVisualStyleBackColor = true;
            // 
            // cyclesCount
            // 
            this.cyclesCount.Location = new System.Drawing.Point(679, 215);
            this.cyclesCount.Name = "cyclesCount";
            this.cyclesCount.Size = new System.Drawing.Size(120, 20);
            this.cyclesCount.TabIndex = 10;
            this.cyclesCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(679, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cycles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(679, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Base Time:";
            // 
            // baseTimeLbl
            // 
            this.baseTimeLbl.AutoSize = true;
            this.baseTimeLbl.Location = new System.Drawing.Point(746, 242);
            this.baseTimeLbl.Name = "baseTimeLbl";
            this.baseTimeLbl.Size = new System.Drawing.Size(43, 13);
            this.baseTimeLbl.TabIndex = 13;
            this.baseTimeLbl.Text = "N/A ms";
            // 
            // baseExecutionLbl
            // 
            this.baseExecutionLbl.AutoSize = true;
            this.baseExecutionLbl.Location = new System.Drawing.Point(258, 9);
            this.baseExecutionLbl.Name = "baseExecutionLbl";
            this.baseExecutionLbl.Size = new System.Drawing.Size(0, 13);
            this.baseExecutionLbl.TabIndex = 14;
            // 
            // prototypeExecutionLbl
            // 
            this.prototypeExecutionLbl.AutoSize = true;
            this.prototypeExecutionLbl.Location = new System.Drawing.Point(258, 60);
            this.prototypeExecutionLbl.Name = "prototypeExecutionLbl";
            this.prototypeExecutionLbl.Size = new System.Drawing.Size(0, 13);
            this.prototypeExecutionLbl.TabIndex = 15;
            // 
            // optimizedExecutionLbl
            // 
            this.optimizedExecutionLbl.AutoSize = true;
            this.optimizedExecutionLbl.Location = new System.Drawing.Point(258, 116);
            this.optimizedExecutionLbl.Name = "optimizedExecutionLbl";
            this.optimizedExecutionLbl.Size = new System.Drawing.Size(0, 13);
            this.optimizedExecutionLbl.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(682, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total Time:";
            // 
            // totalTimeLbl
            // 
            this.totalTimeLbl.AutoSize = true;
            this.totalTimeLbl.Location = new System.Drawing.Point(749, 270);
            this.totalTimeLbl.Name = "totalTimeLbl";
            this.totalTimeLbl.Size = new System.Drawing.Size(43, 13);
            this.totalTimeLbl.TabIndex = 18;
            this.totalTimeLbl.Text = "N/A ms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 22;
            // 
            // resultsBtn
            // 
            this.resultsBtn.Location = new System.Drawing.Point(564, 212);
            this.resultsBtn.Name = "resultsBtn";
            this.resultsBtn.Size = new System.Drawing.Size(75, 23);
            this.resultsBtn.TabIndex = 21;
            this.resultsBtn.Text = "Find";
            this.resultsBtn.UseVisualStyleBackColor = true;
            this.resultsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultsTxt
            // 
            this.resultsTxt.Location = new System.Drawing.Point(16, 212);
            this.resultsTxt.Name = "resultsTxt";
            this.resultsTxt.Size = new System.Drawing.Size(542, 20);
            this.resultsTxt.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Results Folder";
            // 
            // resolveLbl
            // 
            this.resolveLbl.AutoSize = true;
            this.resolveLbl.Location = new System.Drawing.Point(261, 186);
            this.resolveLbl.Name = "resolveLbl";
            this.resolveLbl.Size = new System.Drawing.Size(0, 13);
            this.resolveLbl.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(673, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Configuration";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(676, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Server";
            // 
            // serverTxt
            // 
            this.serverTxt.Location = new System.Drawing.Point(679, 52);
            this.serverTxt.Name = "serverTxt";
            this.serverTxt.Size = new System.Drawing.Size(114, 20);
            this.serverTxt.TabIndex = 26;
            // 
            // databaseTxt
            // 
            this.databaseTxt.Location = new System.Drawing.Point(679, 88);
            this.databaseTxt.Name = "databaseTxt";
            this.databaseTxt.Size = new System.Drawing.Size(114, 20);
            this.databaseTxt.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(676, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Database";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(679, 125);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(114, 20);
            this.userNameTxt.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(676, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "User Name";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(679, 160);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(114, 20);
            this.passwordTxt.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(676, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Password";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(98, 260);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(460, 22);
            this.progressBar1.TabIndex = 33;
            // 
            // SqlTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 297);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.databaseTxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.serverTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.resolveLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resultsBtn);
            this.Controls.Add(this.resultsTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.totalTimeLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.optimizedExecutionLbl);
            this.Controls.Add(this.prototypeExecutionLbl);
            this.Controls.Add(this.baseExecutionLbl);
            this.Controls.Add(this.baseTimeLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cyclesCount);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.prototypeFindBtn);
            this.Controls.Add(this.baseFindBtn);
            this.Controls.Add(this.optimizedTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prototypeTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.baseTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.executeButton);
            this.Name = "SqlTester";
            this.Text = "Query Tester";
            ((System.ComponentModel.ISupportInitialize)(this.cyclesCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox baseTxt;
        private System.Windows.Forms.TextBox prototypeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox optimizedTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button baseFindBtn;
        private System.Windows.Forms.Button prototypeFindBtn;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Timer totalExecution;
        private System.Windows.Forms.Timer lapExecution;
        private System.Windows.Forms.NumericUpDown cyclesCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label baseTimeLbl;
        private System.Windows.Forms.Label baseExecutionLbl;
        private System.Windows.Forms.Label prototypeExecutionLbl;
        private System.Windows.Forms.Label optimizedExecutionLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalTimeLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button resultsBtn;
        private System.Windows.Forms.TextBox resultsTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label resolveLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox serverTxt;
        private System.Windows.Forms.TextBox databaseTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

