namespace AppRunner
{
    partial class Form2
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
            this.addConfig = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.configListBox = new System.Windows.Forms.ListBox();
            this.exeListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdTextBox = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btnConsoleClear = new System.Windows.Forms.Button();
            this.btnConsoleCopy = new System.Windows.Forms.Button();
            this.tbConsole = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resYTextBox = new System.Windows.Forms.TextBox();
            this.resYCheckBox = new System.Windows.Forms.CheckBox();
            this.resXTextBox = new System.Windows.Forms.TextBox();
            this.resXCheckBox = new System.Windows.Forms.CheckBox();
            this.windowedCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.wcListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wcTopTextBox = new System.Windows.Forms.TextBox();
            this.wcLeftTextBox = new System.Windows.Forms.TextBox();
            this.wcNodeTextBox = new System.Windows.Forms.TextBox();
            this.wcUseCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox12.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addConfig
            // 
            this.addConfig.Location = new System.Drawing.Point(12, 135);
            this.addConfig.Name = "addConfig";
            this.addConfig.Size = new System.Drawing.Size(150, 40);
            this.addConfig.TabIndex = 0;
            this.addConfig.Text = "Add Config";
            this.addConfig.UseVisualStyleBackColor = true;
            this.addConfig.Click += new System.EventHandler(this.addConfig_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Remove Config";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Configs";
            // 
            // configListBox
            // 
            this.configListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configListBox.FormattingEnabled = true;
            this.configListBox.ItemHeight = 20;
            this.configListBox.Location = new System.Drawing.Point(16, 39);
            this.configListBox.Name = "configListBox";
            this.configListBox.Size = new System.Drawing.Size(1079, 84);
            this.configListBox.TabIndex = 4;
            this.configListBox.SelectedIndexChanged += new System.EventHandler(this.configListBox_SelectedIndexChanged);
            // 
            // exeListBox
            // 
            this.exeListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exeListBox.FormattingEnabled = true;
            this.exeListBox.ItemHeight = 20;
            this.exeListBox.Location = new System.Drawing.Point(16, 218);
            this.exeListBox.Name = "exeListBox";
            this.exeListBox.Size = new System.Drawing.Size(1079, 84);
            this.exeListBox.TabIndex = 8;
            this.exeListBox.SelectedIndexChanged += new System.EventHandler(this.exeListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Executables";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Remove Exe";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "Add Exe";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 753);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Command Line";
            // 
            // cmdTextBox
            // 
            this.cmdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdTextBox.Enabled = false;
            this.cmdTextBox.Location = new System.Drawing.Point(18, 936);
            this.cmdTextBox.Name = "cmdTextBox";
            this.cmdTextBox.Size = new System.Drawing.Size(1079, 125);
            this.cmdTextBox.TabIndex = 10;
            this.cmdTextBox.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(321, 1083);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(300, 40);
            this.button4.TabIndex = 12;
            this.button4.Text = "Status";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 1083);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(300, 40);
            this.button5.TabIndex = 11;
            this.button5.Text = "Run";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(627, 1083);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(300, 40);
            this.button6.TabIndex = 13;
            this.button6.Text = "Kill";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox12.Controls.Add(this.btnConsoleClear);
            this.groupBox12.Controls.Add(this.btnConsoleCopy);
            this.groupBox12.Controls.Add(this.tbConsole);
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.Location = new System.Drawing.Point(7, 1176);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox12.Size = new System.Drawing.Size(1090, 157);
            this.groupBox12.TabIndex = 17;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Console : ";
            // 
            // btnConsoleClear
            // 
            this.btnConsoleClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsoleClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsoleClear.Location = new System.Drawing.Point(1010, 93);
            this.btnConsoleClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsoleClear.Name = "btnConsoleClear";
            this.btnConsoleClear.Size = new System.Drawing.Size(66, 52);
            this.btnConsoleClear.TabIndex = 2;
            this.btnConsoleClear.Text = "Clear";
            this.btnConsoleClear.UseVisualStyleBackColor = true;
            this.btnConsoleClear.Click += new System.EventHandler(this.btnConsoleClear_Click);
            // 
            // btnConsoleCopy
            // 
            this.btnConsoleCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsoleCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsoleCopy.Location = new System.Drawing.Point(1010, 27);
            this.btnConsoleCopy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsoleCopy.Name = "btnConsoleCopy";
            this.btnConsoleCopy.Size = new System.Drawing.Size(66, 52);
            this.btnConsoleCopy.TabIndex = 1;
            this.btnConsoleCopy.Text = "Copy";
            this.btnConsoleCopy.UseVisualStyleBackColor = true;
            this.btnConsoleCopy.Click += new System.EventHandler(this.btnConsoleCopy_Click);
            // 
            // tbConsole
            // 
            this.tbConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConsole.Location = new System.Drawing.Point(9, 29);
            this.tbConsole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbConsole.Multiline = true;
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.ReadOnly = true;
            this.tbConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbConsole.Size = new System.Drawing.Size(993, 116);
            this.tbConsole.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.resYTextBox);
            this.groupBox1.Controls.Add(this.resYCheckBox);
            this.groupBox1.Controls.Add(this.resXTextBox);
            this.groupBox1.Controls.Add(this.resXCheckBox);
            this.groupBox1.Controls.Add(this.windowedCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 372);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1083, 187);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional Commands :";
            // 
            // resYTextBox
            // 
            this.resYTextBox.Location = new System.Drawing.Point(100, 109);
            this.resYTextBox.Name = "resYTextBox";
            this.resYTextBox.Size = new System.Drawing.Size(100, 26);
            this.resYTextBox.TabIndex = 4;
            // 
            // resYCheckBox
            // 
            this.resYCheckBox.AutoSize = true;
            this.resYCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resYCheckBox.Location = new System.Drawing.Point(24, 111);
            this.resYCheckBox.Name = "resYCheckBox";
            this.resYCheckBox.Size = new System.Drawing.Size(69, 24);
            this.resYCheckBox.TabIndex = 3;
            this.resYCheckBox.Text = "resY";
            this.resYCheckBox.UseVisualStyleBackColor = true;
            this.resYCheckBox.CheckedChanged += new System.EventHandler(this.resYCheckBox_CheckedChanged);
            // 
            // resXTextBox
            // 
            this.resXTextBox.Location = new System.Drawing.Point(100, 72);
            this.resXTextBox.Name = "resXTextBox";
            this.resXTextBox.Size = new System.Drawing.Size(100, 26);
            this.resXTextBox.TabIndex = 2;
            // 
            // resXCheckBox
            // 
            this.resXCheckBox.AutoSize = true;
            this.resXCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resXCheckBox.Location = new System.Drawing.Point(24, 74);
            this.resXCheckBox.Name = "resXCheckBox";
            this.resXCheckBox.Size = new System.Drawing.Size(70, 24);
            this.resXCheckBox.TabIndex = 1;
            this.resXCheckBox.Text = "resX";
            this.resXCheckBox.UseVisualStyleBackColor = true;
            this.resXCheckBox.CheckedChanged += new System.EventHandler(this.resXCheckBox_CheckedChanged);
            // 
            // windowedCheckBox
            // 
            this.windowedCheckBox.AutoSize = true;
            this.windowedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowedCheckBox.Location = new System.Drawing.Point(24, 39);
            this.windowedCheckBox.Name = "windowedCheckBox";
            this.windowedCheckBox.Size = new System.Drawing.Size(108, 24);
            this.windowedCheckBox.TabIndex = 0;
            this.windowedCheckBox.Text = "windowed";
            this.windowedCheckBox.UseVisualStyleBackColor = true;
            this.windowedCheckBox.CheckedChanged += new System.EventHandler(this.windowedCheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.wcListBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.wcTopTextBox);
            this.groupBox2.Controls.Add(this.wcLeftTextBox);
            this.groupBox2.Controls.Add(this.wcNodeTextBox);
            this.groupBox2.Controls.Add(this.wcUseCheckBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 569);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1083, 264);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Window Config :";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(124, 199);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 40);
            this.button8.TabIndex = 14;
            this.button8.Text = "Remove";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(22, 199);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 40);
            this.button7.TabIndex = 13;
            this.button7.Text = "Add / Set";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // wcListBox
            // 
            this.wcListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wcListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wcListBox.FormattingEnabled = true;
            this.wcListBox.ItemHeight = 20;
            this.wcListBox.Location = new System.Drawing.Point(265, 27);
            this.wcListBox.Name = "wcListBox";
            this.wcListBox.Size = new System.Drawing.Size(409, 184);
            this.wcListBox.TabIndex = 12;
            this.wcListBox.SelectedIndexChanged += new System.EventHandler(this.wndCfgListBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "top";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "left";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "node id";
            // 
            // wcTopTextBox
            // 
            this.wcTopTextBox.Location = new System.Drawing.Point(100, 146);
            this.wcTopTextBox.Name = "wcTopTextBox";
            this.wcTopTextBox.Size = new System.Drawing.Size(100, 26);
            this.wcTopTextBox.TabIndex = 6;
            // 
            // wcLeftTextBox
            // 
            this.wcLeftTextBox.Location = new System.Drawing.Point(100, 109);
            this.wcLeftTextBox.Name = "wcLeftTextBox";
            this.wcLeftTextBox.Size = new System.Drawing.Size(100, 26);
            this.wcLeftTextBox.TabIndex = 4;
            // 
            // wcNodeTextBox
            // 
            this.wcNodeTextBox.Location = new System.Drawing.Point(100, 72);
            this.wcNodeTextBox.Name = "wcNodeTextBox";
            this.wcNodeTextBox.Size = new System.Drawing.Size(100, 26);
            this.wcNodeTextBox.TabIndex = 2;
            // 
            // wcUseCheckBox
            // 
            this.wcUseCheckBox.AutoSize = true;
            this.wcUseCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wcUseCheckBox.Location = new System.Drawing.Point(24, 39);
            this.wcUseCheckBox.Name = "wcUseCheckBox";
            this.wcUseCheckBox.Size = new System.Drawing.Size(182, 24);
            this.wcUseCheckBox.TabIndex = 0;
            this.wcUseCheckBox.Text = "Use Window Config";
            this.wcUseCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 1347);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cmdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exeListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.configListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addConfig);
            this.Name = "Form2";
            this.Text = "AppRunner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addConfig;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox configListBox;
        private System.Windows.Forms.ListBox exeListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox cmdTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button btnConsoleClear;
        private System.Windows.Forms.Button btnConsoleCopy;
        private System.Windows.Forms.TextBox tbConsole;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox windowedCheckBox;
        private System.Windows.Forms.TextBox resXTextBox;
        private System.Windows.Forms.CheckBox resXCheckBox;
        private System.Windows.Forms.TextBox resYTextBox;
        private System.Windows.Forms.CheckBox resYCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox wcTopTextBox;
        private System.Windows.Forms.TextBox wcLeftTextBox;
        private System.Windows.Forms.TextBox wcNodeTextBox;
        private System.Windows.Forms.CheckBox wcUseCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox wcListBox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
    }
}