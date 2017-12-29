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
            this.debugCheckBox = new System.Windows.Forms.CheckBox();
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
            this.oglCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox12.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addConfig
            // 
            this.addConfig.Location = new System.Drawing.Point(8, 88);
            this.addConfig.Margin = new System.Windows.Forms.Padding(2);
            this.addConfig.Name = "addConfig";
            this.addConfig.Size = new System.Drawing.Size(100, 26);
            this.addConfig.TabIndex = 0;
            this.addConfig.Text = "Add Config";
            this.addConfig.UseVisualStyleBackColor = true;
            this.addConfig.Click += new System.EventHandler(this.addConfig_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Remove Config";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Configs";
            // 
            // configListBox
            // 
            this.configListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configListBox.FormattingEnabled = true;
            this.configListBox.Location = new System.Drawing.Point(11, 25);
            this.configListBox.Margin = new System.Windows.Forms.Padding(2);
            this.configListBox.Name = "configListBox";
            this.configListBox.Size = new System.Drawing.Size(721, 56);
            this.configListBox.TabIndex = 4;
            this.configListBox.SelectedIndexChanged += new System.EventHandler(this.configListBox_SelectedIndexChanged);
            // 
            // exeListBox
            // 
            this.exeListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exeListBox.FormattingEnabled = true;
            this.exeListBox.Location = new System.Drawing.Point(11, 142);
            this.exeListBox.Margin = new System.Windows.Forms.Padding(2);
            this.exeListBox.Name = "exeListBox";
            this.exeListBox.Size = new System.Drawing.Size(721, 56);
            this.exeListBox.TabIndex = 8;
            this.exeListBox.SelectedIndexChanged += new System.EventHandler(this.exeListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Executables";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 204);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 26);
            this.button2.TabIndex = 6;
            this.button2.Text = "Remove Exe";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 204);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 26);
            this.button3.TabIndex = 5;
            this.button3.Text = "Add Exe";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 489);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Command Line";
            // 
            // cmdTextBox
            // 
            this.cmdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdTextBox.Location = new System.Drawing.Point(12, 608);
            this.cmdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cmdTextBox.Name = "cmdTextBox";
            this.cmdTextBox.Size = new System.Drawing.Size(721, 83);
            this.cmdTextBox.TabIndex = 10;
            this.cmdTextBox.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(214, 704);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 26);
            this.button4.TabIndex = 12;
            this.button4.Text = "Status";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(10, 704);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 26);
            this.button5.TabIndex = 11;
            this.button5.Text = "Run";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(418, 704);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 26);
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
            this.groupBox12.Location = new System.Drawing.Point(5, 764);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(727, 102);
            this.groupBox12.TabIndex = 17;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Console : ";
            // 
            // btnConsoleClear
            // 
            this.btnConsoleClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsoleClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsoleClear.Location = new System.Drawing.Point(673, 60);
            this.btnConsoleClear.Name = "btnConsoleClear";
            this.btnConsoleClear.Size = new System.Drawing.Size(44, 34);
            this.btnConsoleClear.TabIndex = 2;
            this.btnConsoleClear.Text = "Clear";
            this.btnConsoleClear.UseVisualStyleBackColor = true;
            this.btnConsoleClear.Click += new System.EventHandler(this.btnConsoleClear_Click);
            // 
            // btnConsoleCopy
            // 
            this.btnConsoleCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsoleCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsoleCopy.Location = new System.Drawing.Point(673, 18);
            this.btnConsoleCopy.Name = "btnConsoleCopy";
            this.btnConsoleCopy.Size = new System.Drawing.Size(44, 34);
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
            this.tbConsole.Location = new System.Drawing.Point(6, 19);
            this.tbConsole.Multiline = true;
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.ReadOnly = true;
            this.tbConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbConsole.Size = new System.Drawing.Size(663, 77);
            this.tbConsole.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.oglCheckBox);
            this.groupBox1.Controls.Add(this.debugCheckBox);
            this.groupBox1.Controls.Add(this.resYTextBox);
            this.groupBox1.Controls.Add(this.resYCheckBox);
            this.groupBox1.Controls.Add(this.resXTextBox);
            this.groupBox1.Controls.Add(this.resXCheckBox);
            this.groupBox1.Controls.Add(this.windowedCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 122);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional Commands :";
            // 
            // debugCheckBox
            // 
            this.debugCheckBox.AutoSize = true;
            this.debugCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugCheckBox.Location = new System.Drawing.Point(179, 25);
            this.debugCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.debugCheckBox.Name = "debugCheckBox";
            this.debugCheckBox.Size = new System.Drawing.Size(56, 17);
            this.debugCheckBox.TabIndex = 5;
            this.debugCheckBox.Text = "debug";
            this.debugCheckBox.UseVisualStyleBackColor = true;
            this.debugCheckBox.CheckedChanged += new System.EventHandler(this.debugCheckBox_CheckedChanged);
            // 
            // resYTextBox
            // 
            this.resYTextBox.Location = new System.Drawing.Point(67, 71);
            this.resYTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.resYTextBox.Name = "resYTextBox";
            this.resYTextBox.Size = new System.Drawing.Size(68, 20);
            this.resYTextBox.TabIndex = 4;
            // 
            // resYCheckBox
            // 
            this.resYCheckBox.AutoSize = true;
            this.resYCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resYCheckBox.Location = new System.Drawing.Point(16, 72);
            this.resYCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.resYCheckBox.Name = "resYCheckBox";
            this.resYCheckBox.Size = new System.Drawing.Size(47, 17);
            this.resYCheckBox.TabIndex = 3;
            this.resYCheckBox.Text = "resY";
            this.resYCheckBox.UseVisualStyleBackColor = true;
            this.resYCheckBox.CheckedChanged += new System.EventHandler(this.resYCheckBox_CheckedChanged);
            // 
            // resXTextBox
            // 
            this.resXTextBox.Location = new System.Drawing.Point(67, 47);
            this.resXTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.resXTextBox.Name = "resXTextBox";
            this.resXTextBox.Size = new System.Drawing.Size(68, 20);
            this.resXTextBox.TabIndex = 2;
            // 
            // resXCheckBox
            // 
            this.resXCheckBox.AutoSize = true;
            this.resXCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resXCheckBox.Location = new System.Drawing.Point(16, 48);
            this.resXCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.resXCheckBox.Name = "resXCheckBox";
            this.resXCheckBox.Size = new System.Drawing.Size(47, 17);
            this.resXCheckBox.TabIndex = 1;
            this.resXCheckBox.Text = "resX";
            this.resXCheckBox.UseVisualStyleBackColor = true;
            this.resXCheckBox.CheckedChanged += new System.EventHandler(this.resXCheckBox_CheckedChanged);
            // 
            // windowedCheckBox
            // 
            this.windowedCheckBox.AutoSize = true;
            this.windowedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowedCheckBox.Location = new System.Drawing.Point(16, 25);
            this.windowedCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.windowedCheckBox.Name = "windowedCheckBox";
            this.windowedCheckBox.Size = new System.Drawing.Size(74, 17);
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
            this.groupBox2.Location = new System.Drawing.Point(10, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(722, 172);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Window Config :";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(83, 129);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 26);
            this.button8.TabIndex = 14;
            this.button8.Text = "Remove";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(15, 129);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(64, 26);
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
            this.wcListBox.Location = new System.Drawing.Point(177, 18);
            this.wcListBox.Margin = new System.Windows.Forms.Padding(2);
            this.wcListBox.Name = "wcListBox";
            this.wcListBox.Size = new System.Drawing.Size(274, 121);
            this.wcListBox.TabIndex = 12;
            this.wcListBox.SelectedIndexChanged += new System.EventHandler(this.wndCfgListBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "top";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "left";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "node id";
            // 
            // wcTopTextBox
            // 
            this.wcTopTextBox.Location = new System.Drawing.Point(67, 95);
            this.wcTopTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.wcTopTextBox.Name = "wcTopTextBox";
            this.wcTopTextBox.Size = new System.Drawing.Size(68, 20);
            this.wcTopTextBox.TabIndex = 6;
            // 
            // wcLeftTextBox
            // 
            this.wcLeftTextBox.Location = new System.Drawing.Point(67, 71);
            this.wcLeftTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.wcLeftTextBox.Name = "wcLeftTextBox";
            this.wcLeftTextBox.Size = new System.Drawing.Size(68, 20);
            this.wcLeftTextBox.TabIndex = 4;
            // 
            // wcNodeTextBox
            // 
            this.wcNodeTextBox.Location = new System.Drawing.Point(67, 47);
            this.wcNodeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.wcNodeTextBox.Name = "wcNodeTextBox";
            this.wcNodeTextBox.Size = new System.Drawing.Size(68, 20);
            this.wcNodeTextBox.TabIndex = 2;
            // 
            // wcUseCheckBox
            // 
            this.wcUseCheckBox.AutoSize = true;
            this.wcUseCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wcUseCheckBox.Location = new System.Drawing.Point(16, 25);
            this.wcUseCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.wcUseCheckBox.Name = "wcUseCheckBox";
            this.wcUseCheckBox.Size = new System.Drawing.Size(120, 17);
            this.wcUseCheckBox.TabIndex = 0;
            this.wcUseCheckBox.Text = "Use Window Config";
            this.wcUseCheckBox.UseVisualStyleBackColor = true;
            // 
            // oglCheckBox
            // 
            this.oglCheckBox.AutoSize = true;
            this.oglCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oglCheckBox.Location = new System.Drawing.Point(179, 50);
            this.oglCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.oglCheckBox.Name = "oglCheckBox";
            this.oglCheckBox.Size = new System.Drawing.Size(46, 17);
            this.oglCheckBox.TabIndex = 6;
            this.oglCheckBox.Text = "ogl3";
            this.oglCheckBox.UseVisualStyleBackColor = true;
            this.oglCheckBox.CheckedChanged += new System.EventHandler(this.oglCheckBox_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 690);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.CheckBox debugCheckBox;
        private System.Windows.Forms.CheckBox oglCheckBox;
    }
}