namespace homerseklet_241010form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hőmérsékletekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.számolásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txnap = new System.Windows.Forms.TextBox();
            this.cbev = new System.Windows.Forms.ComboBox();
            this.btkal = new System.Windows.Forms.Button();
            this.lbhom = new System.Windows.Forms.Label();
            this.lbatlag = new System.Windows.Forms.Label();
            this.lbmax = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hőmérsékletekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hőmérsékletekToolStripMenuItem
            // 
            this.hőmérsékletekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.számolásToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.hőmérsékletekToolStripMenuItem.Name = "hőmérsékletekToolStripMenuItem";
            this.hőmérsékletekToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.hőmérsékletekToolStripMenuItem.Text = "Hőmérsékletek";
            // 
            // számolásToolStripMenuItem
            // 
            this.számolásToolStripMenuItem.Name = "számolásToolStripMenuItem";
            this.számolásToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.számolásToolStripMenuItem.Text = "Számolás";
            this.számolásToolStripMenuItem.Click += new System.EventHandler(this.számolásToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Válassz évszakot: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Napok száma: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(68, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hőmérsékletek: ";
            // 
            // txnap
            // 
            this.txnap.Enabled = false;
            this.txnap.Location = new System.Drawing.Point(163, 133);
            this.txnap.Name = "txnap";
            this.txnap.Size = new System.Drawing.Size(100, 20);
            this.txnap.TabIndex = 4;
            // 
            // cbev
            // 
            this.cbev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbev.Enabled = false;
            this.cbev.FormattingEnabled = true;
            this.cbev.Items.AddRange(new object[] {
            "Őszi hónapok: 5 és 20 fok között",
            "Téli hónapok: -8 és 8 fok között",
            "Tavaszi hónapok: 12 és 25 fok között",
            "Nyári hónapok 20 és 35 fok között"});
            this.cbev.Location = new System.Drawing.Point(163, 96);
            this.cbev.Name = "cbev";
            this.cbev.Size = new System.Drawing.Size(210, 21);
            this.cbev.TabIndex = 5;
            this.cbev.SelectedIndexChanged += new System.EventHandler(this.cbev_SelectedIndexChanged);
            // 
            // btkal
            // 
            this.btkal.Enabled = false;
            this.btkal.Location = new System.Drawing.Point(410, 99);
            this.btkal.Name = "btkal";
            this.btkal.Size = new System.Drawing.Size(110, 54);
            this.btkal.TabIndex = 6;
            this.btkal.Text = "Kalkulálás";
            this.btkal.UseVisualStyleBackColor = true;
            this.btkal.Click += new System.EventHandler(this.btkal_Click);
            // 
            // lbhom
            // 
            this.lbhom.AutoSize = true;
            this.lbhom.Location = new System.Drawing.Point(214, 216);
            this.lbhom.Name = "lbhom";
            this.lbhom.Size = new System.Drawing.Size(41, 13);
            this.lbhom.TabIndex = 7;
            this.lbhom.Text = "label4";
            this.lbhom.Visible = false;
            // 
            // lbatlag
            // 
            this.lbatlag.AutoSize = true;
            this.lbatlag.Location = new System.Drawing.Point(49, 350);
            this.lbatlag.Name = "lbatlag";
            this.lbatlag.Size = new System.Drawing.Size(41, 13);
            this.lbatlag.TabIndex = 8;
            this.lbatlag.Text = "label5";
            this.lbatlag.Visible = false;
            // 
            // lbmax
            // 
            this.lbmax.AutoSize = true;
            this.lbmax.Location = new System.Drawing.Point(49, 401);
            this.lbmax.Name = "lbmax";
            this.lbmax.Size = new System.Drawing.Size(41, 13);
            this.lbmax.TabIndex = 9;
            this.lbmax.Text = "label6";
            this.lbmax.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.lbmax);
            this.Controls.Add(this.lbatlag);
            this.Controls.Add(this.lbhom);
            this.Controls.Add(this.btkal);
            this.Controls.Add(this.cbev);
            this.Controls.Add(this.txnap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hőmérséklet kalkuláció";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hőmérsékletekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem számolásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txnap;
        private System.Windows.Forms.ComboBox cbev;
        private System.Windows.Forms.Button btkal;
        private System.Windows.Forms.Label lbhom;
        private System.Windows.Forms.Label lbatlag;
        private System.Windows.Forms.Label lbmax;
    }
}

