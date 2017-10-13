namespace Jarvis
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.randomizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rand5 = new System.Windows.Forms.ToolStripMenuItem();
			this.rand10 = new System.Windows.Forms.ToolStripMenuItem();
			this.rand15 = new System.Windows.Forms.ToolStripMenuItem();
			this.rand20 = new System.Windows.Forms.ToolStripMenuItem();
			this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(0, 27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(515, 360);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.randomizeToolStripMenuItem,
            this.clearToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(515, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// startToolStripMenuItem
			// 
			this.startToolStripMenuItem.Name = "startToolStripMenuItem";
			this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.startToolStripMenuItem.Text = "Start";
			this.startToolStripMenuItem.Click += new System.EventHandler(this.Jarvis);
			// 
			// randomizeToolStripMenuItem
			// 
			this.randomizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rand5,
            this.rand10,
            this.rand15,
            this.rand20});
			this.randomizeToolStripMenuItem.Name = "randomizeToolStripMenuItem";
			this.randomizeToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
			this.randomizeToolStripMenuItem.Text = "Randomize...";
			// 
			// rand5
			// 
			this.rand5.Name = "rand5";
			this.rand5.Size = new System.Drawing.Size(86, 22);
			this.rand5.Text = "5";
			this.rand5.Click += new System.EventHandler(this.randomize_n);
			// 
			// rand10
			// 
			this.rand10.Name = "rand10";
			this.rand10.Size = new System.Drawing.Size(86, 22);
			this.rand10.Text = "10";
			this.rand10.Click += new System.EventHandler(this.randomize_n);
			// 
			// rand15
			// 
			this.rand15.Name = "rand15";
			this.rand15.Size = new System.Drawing.Size(86, 22);
			this.rand15.Text = "15";
			this.rand15.Click += new System.EventHandler(this.randomize_n);
			// 
			// rand20
			// 
			this.rand20.Name = "rand20";
			this.rand20.Size = new System.Drawing.Size(86, 22);
			this.rand20.Text = "20";
			this.rand20.Click += new System.EventHandler(this.randomize_n);
			// 
			// clearToolStripMenuItem
			// 
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.clearToolStripMenuItem.Text = "Clear";
			this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(515, 386);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem randomizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rand5;
		private System.Windows.Forms.ToolStripMenuItem rand10;
		private System.Windows.Forms.ToolStripMenuItem rand15;
		private System.Windows.Forms.ToolStripMenuItem rand20;
		private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
	}
}

