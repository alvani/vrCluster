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
            this.groupBox12.SuspendLayout();
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
            this.configListBox.Size = new System.Drawing.Size(1090, 84);
            this.configListBox.TabIndex = 4;
            this.configListBox.SelectedIndexChanged += new System.EventHandler(this.configListBox_SelectedIndexChanged);
            // 
            // exeListBox
            // 
            this.exeListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exeListBox.FormattingEnabled = true;
            this.exeListBox.ItemHeight = 20;
            this.exeListBox.Location = new System.Drawing.Point(16, 245);
            this.exeListBox.Name = "exeListBox";
            this.exeListBox.Size = new System.Drawing.Size(1090, 84);
            this.exeListBox.TabIndex = 8;
            this.exeListBox.SelectedIndexChanged += new System.EventHandler(this.exeListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Executables";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Remove Exe";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 341);
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
            this.label3.Location = new System.Drawing.Point(12, 430);
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
            this.cmdTextBox.Location = new System.Drawing.Point(16, 463);
            this.cmdTextBox.Name = "cmdTextBox";
            this.cmdTextBox.Size = new System.Drawing.Size(1090, 125);
            this.cmdTextBox.TabIndex = 10;
            this.cmdTextBox.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(319, 610);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(300, 40);
            this.button4.TabIndex = 12;
            this.button4.Text = "Status";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 610);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(300, 40);
            this.button5.TabIndex = 11;
            this.button5.Text = "Run";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(625, 610);
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
            this.groupBox12.Location = new System.Drawing.Point(5, 815);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox12.Size = new System.Drawing.Size(1101, 157);
            this.groupBox12.TabIndex = 17;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Console : ";
            // 
            // btnConsoleClear
            // 
            this.btnConsoleClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsoleClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsoleClear.Location = new System.Drawing.Point(1021, 93);
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
            this.btnConsoleCopy.Location = new System.Drawing.Point(1021, 27);
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
            this.tbConsole.Size = new System.Drawing.Size(1004, 116);
            this.tbConsole.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 986);
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
    }
}