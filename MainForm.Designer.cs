/*
 * Created by SharpDevelop.
 * User: user
 * Date: 08.10.2013
 * Time: 2:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tetris
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.паузапродолжитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.таблицаРекордовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обИгреToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.語言ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.英文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GameFieldPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ElapsedTimeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.FiguresLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NextFigurePictureBox = new System.Windows.Forms.PictureBox();
            this.TipsCheckBox = new System.Windows.Forms.CheckBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AdviceLabel = new System.Windows.Forms.Label();
            this.GameFieldPictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ElapsedTimeLabel2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ScoreLabel2 = new System.Windows.Forms.Label();
            this.FiguresLabel2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.NextFigurePictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.AdviceLabel2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameFieldPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NextFigurePictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameFieldPictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NextFigurePictureBox2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            resources.ApplyResources(this.играToolStripMenuItem, "играToolStripMenuItem");
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.паузапродолжитьToolStripMenuItem,
            this.toolStripSeparator2,
            this.таблицаРекордовToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            // 
            // новаяИграToolStripMenuItem
            // 
            resources.ApplyResources(this.новаяИграToolStripMenuItem, "новаяИграToolStripMenuItem");
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.НоваяИграToolStripMenuItemClick);
            // 
            // паузапродолжитьToolStripMenuItem
            // 
            resources.ApplyResources(this.паузапродолжитьToolStripMenuItem, "паузапродолжитьToolStripMenuItem");
            this.паузапродолжитьToolStripMenuItem.Name = "паузапродолжитьToolStripMenuItem";
            this.паузапродолжитьToolStripMenuItem.Click += new System.EventHandler(this.ПаузапродолжитьToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // таблицаРекордовToolStripMenuItem
            // 
            resources.ApplyResources(this.таблицаРекордовToolStripMenuItem, "таблицаРекордовToolStripMenuItem");
            this.таблицаРекордовToolStripMenuItem.Name = "таблицаРекордовToolStripMenuItem";
            this.таблицаРекордовToolStripMenuItem.Click += new System.EventHandler(this.ТаблицаРекордовToolStripMenuItemClick);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // выходToolStripMenuItem
            // 
            resources.ApplyResources(this.выходToolStripMenuItem, "выходToolStripMenuItem");
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItemClick);
            // 
            // справкаToolStripMenuItem
            // 
            resources.ApplyResources(this.справкаToolStripMenuItem, "справкаToolStripMenuItem");
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правилаToolStripMenuItem,
            this.обИгреToolStripMenuItem,
            this.語言ToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            // 
            // правилаToolStripMenuItem
            // 
            resources.ApplyResources(this.правилаToolStripMenuItem, "правилаToolStripMenuItem");
            this.правилаToolStripMenuItem.Name = "правилаToolStripMenuItem";
            this.правилаToolStripMenuItem.Click += new System.EventHandler(this.ПравилаToolStripMenuItemClick);
            // 
            // обИгреToolStripMenuItem
            // 
            resources.ApplyResources(this.обИгреToolStripMenuItem, "обИгреToolStripMenuItem");
            this.обИгреToolStripMenuItem.Name = "обИгреToolStripMenuItem";
            this.обИгреToolStripMenuItem.Click += new System.EventHandler(this.ОбИгреToolStripMenuItemClick);
            // 
            // 語言ToolStripMenuItem
            // 
            resources.ApplyResources(this.語言ToolStripMenuItem, "語言ToolStripMenuItem");
            this.語言ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.中文ToolStripMenuItem,
            this.英文ToolStripMenuItem});
            this.語言ToolStripMenuItem.Name = "語言ToolStripMenuItem";
            // 
            // 中文ToolStripMenuItem
            // 
            resources.ApplyResources(this.中文ToolStripMenuItem, "中文ToolStripMenuItem");
            this.中文ToolStripMenuItem.Name = "中文ToolStripMenuItem";
            this.中文ToolStripMenuItem.Click += new System.EventHandler(this.中文ToolStripMenuItem_Click);
            // 
            // 英文ToolStripMenuItem
            // 
            resources.ApplyResources(this.英文ToolStripMenuItem, "英文ToolStripMenuItem");
            this.英文ToolStripMenuItem.Name = "英文ToolStripMenuItem";
            this.英文ToolStripMenuItem.Click += new System.EventHandler(this.英文ToolStripMenuItem_Click);
            // 
            // GameFieldPictureBox
            // 
            resources.ApplyResources(this.GameFieldPictureBox, "GameFieldPictureBox");
            this.GameFieldPictureBox.BackColor = System.Drawing.Color.White;
            this.GameFieldPictureBox.Name = "GameFieldPictureBox";
            this.GameFieldPictureBox.TabStop = false;
            this.GameFieldPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GameFieldPictureBoxPaint);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.ElapsedTimeLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ScoreLabel);
            this.groupBox1.Controls.Add(this.FiguresLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // ElapsedTimeLabel
            // 
            resources.ApplyResources(this.ElapsedTimeLabel, "ElapsedTimeLabel");
            this.ElapsedTimeLabel.Name = "ElapsedTimeLabel";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // ScoreLabel
            // 
            resources.ApplyResources(this.ScoreLabel, "ScoreLabel");
            this.ScoreLabel.Name = "ScoreLabel";
            // 
            // FiguresLabel
            // 
            resources.ApplyResources(this.FiguresLabel, "FiguresLabel");
            this.FiguresLabel.Name = "FiguresLabel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.NextFigurePictureBox);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // NextFigurePictureBox
            // 
            resources.ApplyResources(this.NextFigurePictureBox, "NextFigurePictureBox");
            this.NextFigurePictureBox.Name = "NextFigurePictureBox";
            this.NextFigurePictureBox.TabStop = false;
            this.NextFigurePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.NextFigurePictureBoxPaint);
            // 
            // TipsCheckBox
            // 
            resources.ApplyResources(this.TipsCheckBox, "TipsCheckBox");
            this.TipsCheckBox.Checked = true;
            this.TipsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TipsCheckBox.Name = "TipsCheckBox";
            this.TipsCheckBox.TabStop = false;
            this.TipsCheckBox.UseVisualStyleBackColor = true;
            this.TipsCheckBox.CheckedChanged += new System.EventHandler(this.TipsCheckBoxCheckedChanged);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 700;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerTick);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.AdviceLabel);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // AdviceLabel
            // 
            resources.ApplyResources(this.AdviceLabel, "AdviceLabel");
            this.AdviceLabel.Name = "AdviceLabel";
            // 
            // GameFieldPictureBox2
            // 
            resources.ApplyResources(this.GameFieldPictureBox2, "GameFieldPictureBox2");
            this.GameFieldPictureBox2.BackColor = System.Drawing.Color.White;
            this.GameFieldPictureBox2.Name = "GameFieldPictureBox2";
            this.GameFieldPictureBox2.TabStop = false;
            this.GameFieldPictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.GameFieldPictureBox2_Paint);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.ElapsedTimeLabel2);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.ScoreLabel2);
            this.groupBox4.Controls.Add(this.FiguresLabel2);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // ElapsedTimeLabel2
            // 
            resources.ApplyResources(this.ElapsedTimeLabel2, "ElapsedTimeLabel2");
            this.ElapsedTimeLabel2.Name = "ElapsedTimeLabel2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // ScoreLabel2
            // 
            resources.ApplyResources(this.ScoreLabel2, "ScoreLabel2");
            this.ScoreLabel2.Name = "ScoreLabel2";
            // 
            // FiguresLabel2
            // 
            resources.ApplyResources(this.FiguresLabel2, "FiguresLabel2");
            this.FiguresLabel2.Name = "FiguresLabel2";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.NextFigurePictureBox2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // NextFigurePictureBox2
            // 
            resources.ApplyResources(this.NextFigurePictureBox2, "NextFigurePictureBox2");
            this.NextFigurePictureBox2.Name = "NextFigurePictureBox2";
            this.NextFigurePictureBox2.TabStop = false;
            this.NextFigurePictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.NextFigurePictureBox2_Paint);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.TabStop = false;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Controls.Add(this.AdviceLabel2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // AdviceLabel2
            // 
            resources.ApplyResources(this.AdviceLabel2, "AdviceLabel2");
            this.AdviceLabel2.Name = "AdviceLabel2";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.GameFieldPictureBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.TipsCheckBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GameFieldPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameFieldPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NextFigurePictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GameFieldPictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NextFigurePictureBox2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Label AdviceLabel;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ToolStripMenuItem таблицаРекордовToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.Timer GameTimer;
		private System.Windows.Forms.CheckBox TipsCheckBox;
		private System.Windows.Forms.PictureBox NextFigurePictureBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label FiguresLabel;
		private System.Windows.Forms.Label ScoreLabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label ElapsedTimeLabel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox GameFieldPictureBox;
		private System.Windows.Forms.ToolStripMenuItem обИгреToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem правилаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem паузапродолжитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox GameFieldPictureBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label ElapsedTimeLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ScoreLabel2;
        private System.Windows.Forms.Label FiguresLabel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox NextFigurePictureBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label AdviceLabel2;
        private System.Windows.Forms.ToolStripMenuItem 語言ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 英文ToolStripMenuItem;
    }
}
