namespace JackpotV1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnResim1 = new System.Windows.Forms.Button();
            this.ımageListJackpot = new System.Windows.Forms.ImageList(this.components);
            this.btnResim2 = new System.Windows.Forms.Button();
            this.btnResim3 = new System.Windows.Forms.Button();
            this.btnOyna = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uygulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sıfırlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oyunuBitirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniOyunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnResim1
            // 
            this.btnResim1.ImageIndex = 0;
            this.btnResim1.ImageList = this.ımageListJackpot;
            this.btnResim1.Location = new System.Drawing.Point(92, 54);
            this.btnResim1.Name = "btnResim1";
            this.btnResim1.Size = new System.Drawing.Size(128, 128);
            this.btnResim1.TabIndex = 0;
            this.btnResim1.UseVisualStyleBackColor = true;
            // 
            // ımageListJackpot
            // 
            this.ımageListJackpot.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListJackpot.ImageStream")));
            this.ımageListJackpot.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListJackpot.Images.SetKeyName(0, "car.png");
            this.ımageListJackpot.Images.SetKeyName(1, "game.png");
            this.ımageListJackpot.Images.SetKeyName(2, "girl.png");
            this.ımageListJackpot.Images.SetKeyName(3, "house.png");
            this.ımageListJackpot.Images.SetKeyName(4, "money.png");
            // 
            // btnResim2
            // 
            this.btnResim2.ImageIndex = 4;
            this.btnResim2.ImageList = this.ımageListJackpot;
            this.btnResim2.Location = new System.Drawing.Point(262, 54);
            this.btnResim2.Name = "btnResim2";
            this.btnResim2.Size = new System.Drawing.Size(128, 128);
            this.btnResim2.TabIndex = 1;
            this.btnResim2.UseVisualStyleBackColor = true;
            // 
            // btnResim3
            // 
            this.btnResim3.ImageIndex = 2;
            this.btnResim3.ImageList = this.ımageListJackpot;
            this.btnResim3.Location = new System.Drawing.Point(427, 54);
            this.btnResim3.Name = "btnResim3";
            this.btnResim3.Size = new System.Drawing.Size(128, 128);
            this.btnResim3.TabIndex = 2;
            this.btnResim3.UseVisualStyleBackColor = true;
            // 
            // btnOyna
            // 
            this.btnOyna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOyna.Location = new System.Drawing.Point(92, 202);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(463, 42);
            this.btnOyna.TabIndex = 3;
            this.btnOyna.Text = "OYNA";
            this.btnOyna.UseVisualStyleBackColor = true;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uygulamaToolStripMenuItem,
            this.puanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(637, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uygulamaToolStripMenuItem
            // 
            this.uygulamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.uygulamaToolStripMenuItem.Name = "uygulamaToolStripMenuItem";
            this.uygulamaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.uygulamaToolStripMenuItem.Text = "Uygulama";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // puanToolStripMenuItem
            // 
            this.puanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniOyunToolStripMenuItem,
            this.sıfırlaToolStripMenuItem,
            this.oyunuBitirToolStripMenuItem});
            this.puanToolStripMenuItem.Name = "puanToolStripMenuItem";
            this.puanToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.puanToolStripMenuItem.Text = "Oyun";
            this.puanToolStripMenuItem.Click += new System.EventHandler(this.puanToolStripMenuItem_Click);
            // 
            // sıfırlaToolStripMenuItem
            // 
            this.sıfırlaToolStripMenuItem.Name = "sıfırlaToolStripMenuItem";
            this.sıfırlaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sıfırlaToolStripMenuItem.Text = "Puanı Sıfırla";
            this.sıfırlaToolStripMenuItem.Click += new System.EventHandler(this.sıfırlaToolStripMenuItem_Click);
            // 
            // oyunuBitirToolStripMenuItem
            // 
            this.oyunuBitirToolStripMenuItem.Name = "oyunuBitirToolStripMenuItem";
            this.oyunuBitirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oyunuBitirToolStripMenuItem.Text = "Oyunu Bitir";
            this.oyunuBitirToolStripMenuItem.Click += new System.EventHandler(this.oyunuBitirToolStripMenuItem_Click);
            // 
            // yeniOyunToolStripMenuItem
            // 
            this.yeniOyunToolStripMenuItem.Name = "yeniOyunToolStripMenuItem";
            this.yeniOyunToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniOyunToolStripMenuItem.Text = "Yeni Oyun";
            this.yeniOyunToolStripMenuItem.Click += new System.EventHandler(this.yeniOyunToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOyna);
            this.Controls.Add(this.btnResim3);
            this.Controls.Add(this.btnResim2);
            this.Controls.Add(this.btnResim1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "JACKPOT V1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResim1;
        private System.Windows.Forms.Button btnResim2;
        private System.Windows.Forms.Button btnResim3;
        private System.Windows.Forms.Button btnOyna;
        internal System.Windows.Forms.ImageList ımageListJackpot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uygulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sıfırlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oyunuBitirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniOyunToolStripMenuItem;
    }
}

