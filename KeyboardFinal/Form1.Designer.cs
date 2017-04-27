namespace KeyboardFinal
{
    partial class Keyboard
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
            this.enterBtn = new System.Windows.Forms.Button();
            this.hashBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.starBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.emptyBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.sevenBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.modeBtn = new System.Windows.Forms.Button();
            this.builderBox = new System.Windows.Forms.RichTextBox();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.notePadBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureDelayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // enterBtn
            // 
            this.enterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.enterBtn.Location = new System.Drawing.Point(320, 384);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(49, 100);
            this.enterBtn.TabIndex = 43;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = false;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // hashBtn
            // 
            this.hashBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.hashBtn.Location = new System.Drawing.Point(265, 437);
            this.hashBtn.Name = "hashBtn";
            this.hashBtn.Size = new System.Drawing.Size(49, 47);
            this.hashBtn.TabIndex = 42;
            this.hashBtn.Text = "#";
            this.hashBtn.UseVisualStyleBackColor = false;
            this.hashBtn.Click += new System.EventHandler(this.hashBtn_Click);
            // 
            // zeroBtn
            // 
            this.zeroBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.zeroBtn.Location = new System.Drawing.Point(210, 437);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(49, 47);
            this.zeroBtn.TabIndex = 41;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = false;
            this.zeroBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // starBtn
            // 
            this.starBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.starBtn.Location = new System.Drawing.Point(155, 437);
            this.starBtn.Name = "starBtn";
            this.starBtn.Size = new System.Drawing.Size(49, 47);
            this.starBtn.TabIndex = 40;
            this.starBtn.Text = "*-_";
            this.starBtn.UseVisualStyleBackColor = false;
            this.starBtn.Click += new System.EventHandler(this.starBtn_Click);
            // 
            // threeBtn
            // 
            this.threeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.threeBtn.Location = new System.Drawing.Point(265, 384);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(49, 47);
            this.threeBtn.TabIndex = 38;
            this.threeBtn.Text = "3\r\nWXYZ\r\n";
            this.threeBtn.UseVisualStyleBackColor = false;
            this.threeBtn.Click += new System.EventHandler(this.threeBtn_Click);
            // 
            // twoBtn
            // 
            this.twoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.twoBtn.Location = new System.Drawing.Point(210, 384);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(49, 47);
            this.twoBtn.TabIndex = 37;
            this.twoBtn.Text = "2\r\nTUV";
            this.twoBtn.UseVisualStyleBackColor = false;
            this.twoBtn.Click += new System.EventHandler(this.twoBtn_Click);
            // 
            // oneBtn
            // 
            this.oneBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.oneBtn.Location = new System.Drawing.Point(155, 384);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(49, 47);
            this.oneBtn.TabIndex = 36;
            this.oneBtn.Text = "1\r\nPQRS";
            this.oneBtn.UseVisualStyleBackColor = false;
            this.oneBtn.Click += new System.EventHandler(this.oneBtn_Click);
            // 
            // sixBtn
            // 
            this.sixBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.sixBtn.Location = new System.Drawing.Point(265, 331);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(49, 47);
            this.sixBtn.TabIndex = 35;
            this.sixBtn.Text = "6\r\nMNO";
            this.sixBtn.UseVisualStyleBackColor = false;
            this.sixBtn.Click += new System.EventHandler(this.sixBtn_Click);
            // 
            // fiveBtn
            // 
            this.fiveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.fiveBtn.Location = new System.Drawing.Point(210, 331);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(49, 47);
            this.fiveBtn.TabIndex = 34;
            this.fiveBtn.Text = "5\r\nJKL\r\n";
            this.fiveBtn.UseVisualStyleBackColor = false;
            this.fiveBtn.Click += new System.EventHandler(this.fiveBtn_Click);
            // 
            // fourBtn
            // 
            this.fourBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.fourBtn.Location = new System.Drawing.Point(155, 331);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(49, 47);
            this.fourBtn.TabIndex = 33;
            this.fourBtn.Text = "4\r\nGHI";
            this.fourBtn.UseVisualStyleBackColor = false;
            this.fourBtn.Click += new System.EventHandler(this.fourBtn_Click);
            // 
            // emptyBtn
            // 
            this.emptyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.emptyBtn.Location = new System.Drawing.Point(320, 278);
            this.emptyBtn.Name = "emptyBtn";
            this.emptyBtn.Size = new System.Drawing.Size(49, 100);
            this.emptyBtn.TabIndex = 32;
            this.emptyBtn.Text = "Append";
            this.emptyBtn.UseVisualStyleBackColor = false;
            this.emptyBtn.Click += new System.EventHandler(this.emptyBtn_Click);
            // 
            // nineBtn
            // 
            this.nineBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nineBtn.Location = new System.Drawing.Point(265, 278);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(49, 47);
            this.nineBtn.TabIndex = 31;
            this.nineBtn.Text = "9\r\nDEF\r\n";
            this.nineBtn.UseVisualStyleBackColor = false;
            this.nineBtn.Click += new System.EventHandler(this.nineBtn_Click);
            // 
            // eightBtn
            // 
            this.eightBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.eightBtn.Location = new System.Drawing.Point(210, 278);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(49, 47);
            this.eightBtn.TabIndex = 30;
            this.eightBtn.Text = "8\r\nABC";
            this.eightBtn.UseVisualStyleBackColor = false;
            this.eightBtn.Click += new System.EventHandler(this.eightBtn_Click);
            // 
            // sevenBtn
            // 
            this.sevenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.sevenBtn.Location = new System.Drawing.Point(155, 278);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(49, 47);
            this.sevenBtn.TabIndex = 29;
            this.sevenBtn.Text = "7\r\n.,\"\r\n";
            this.sevenBtn.UseVisualStyleBackColor = false;
            this.sevenBtn.Click += new System.EventHandler(this.sevenBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sendBtn.Location = new System.Drawing.Point(320, 225);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(49, 47);
            this.sendBtn.TabIndex = 28;
            this.sendBtn.Text = "Send Predicted";
            this.sendBtn.UseVisualStyleBackColor = false;
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.prevBtn.Location = new System.Drawing.Point(265, 225);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(49, 47);
            this.prevBtn.TabIndex = 27;
            this.prevBtn.Text = "Previous";
            this.prevBtn.UseVisualStyleBackColor = false;
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nextBtn.Location = new System.Drawing.Point(210, 225);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(49, 47);
            this.nextBtn.TabIndex = 26;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = false;
            // 
            // modeBtn
            // 
            this.modeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.modeBtn.ForeColor = System.Drawing.Color.Black;
            this.modeBtn.Location = new System.Drawing.Point(155, 225);
            this.modeBtn.Name = "modeBtn";
            this.modeBtn.Size = new System.Drawing.Size(49, 47);
            this.modeBtn.TabIndex = 25;
            this.modeBtn.Text = "Mode";
            this.modeBtn.UseVisualStyleBackColor = false;
            this.modeBtn.Click += new System.EventHandler(this.modeBtn_Click);
            // 
            // builderBox
            // 
            this.builderBox.Location = new System.Drawing.Point(173, 188);
            this.builderBox.Name = "builderBox";
            this.builderBox.ReadOnly = true;
            this.builderBox.Size = new System.Drawing.Size(100, 20);
            this.builderBox.TabIndex = 44;
            this.builderBox.Text = "";
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(289, 188);
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.Size = new System.Drawing.Size(80, 20);
            this.statusBox.TabIndex = 45;
            this.statusBox.Text = "Multi-Press";
            // 
            // notePadBox
            // 
            this.notePadBox.Location = new System.Drawing.Point(94, 47);
            this.notePadBox.Name = "notePadBox";
            this.notePadBox.Size = new System.Drawing.Size(352, 123);
            this.notePadBox.TabIndex = 46;
            this.notePadBox.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(556, 24);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureDelayToolStripMenuItem});
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.configureToolStripMenuItem.Text = "Configure";
            // 
            // configureDelayToolStripMenuItem
            // 
            this.configureDelayToolStripMenuItem.Name = "configureDelayToolStripMenuItem";
            this.configureDelayToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.configureDelayToolStripMenuItem.Text = "Configure Delay";
            this.configureDelayToolStripMenuItem.Click += new System.EventHandler(this.configureDelayToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Press Append to add letter to TextBox";
            // 
            // Keyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notePadBox);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.builderBox);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.hashBtn);
            this.Controls.Add(this.zeroBtn);
            this.Controls.Add(this.starBtn);
            this.Controls.Add(this.threeBtn);
            this.Controls.Add(this.twoBtn);
            this.Controls.Add(this.oneBtn);
            this.Controls.Add(this.sixBtn);
            this.Controls.Add(this.fiveBtn);
            this.Controls.Add(this.fourBtn);
            this.Controls.Add(this.emptyBtn);
            this.Controls.Add(this.nineBtn);
            this.Controls.Add(this.eightBtn);
            this.Controls.Add(this.sevenBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.modeBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Keyboard";
            this.Text = "Keyboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button hashBtn;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Button starBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button emptyBtn;
        private System.Windows.Forms.Button nineBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button sevenBtn;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button modeBtn;
        private System.Windows.Forms.RichTextBox builderBox;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.RichTextBox notePadBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureDelayToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

