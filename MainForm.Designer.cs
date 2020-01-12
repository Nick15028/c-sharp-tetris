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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(950, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.паузапродолжитьToolStripMenuItem,
            this.toolStripSeparator2,
            this.таблицаРекордовToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.новаяИграToolStripMenuItem.Text = "Новая игра";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.НоваяИграToolStripMenuItemClick);
            // 
            // паузапродолжитьToolStripMenuItem
            // 
            this.паузапродолжитьToolStripMenuItem.Name = "паузапродолжитьToolStripMenuItem";
            this.паузапродолжитьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.паузапродолжитьToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.паузапродолжитьToolStripMenuItem.Text = "Пауза/продолжить";
            this.паузапродолжитьToolStripMenuItem.Click += new System.EventHandler(this.ПаузапродолжитьToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
            // 
            // таблицаРекордовToolStripMenuItem
            // 
            this.таблицаРекордовToolStripMenuItem.Name = "таблицаРекордовToolStripMenuItem";
            this.таблицаРекордовToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.таблицаРекордовToolStripMenuItem.Text = "Таблица рекордов...";
            this.таблицаРекордовToolStripMenuItem.Click += new System.EventHandler(this.ТаблицаРекордовToolStripMenuItemClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItemClick);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правилаToolStripMenuItem,
            this.обИгреToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // правилаToolStripMenuItem
            // 
            this.правилаToolStripMenuItem.Name = "правилаToolStripMenuItem";
            this.правилаToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.правилаToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.правилаToolStripMenuItem.Text = "Правила";
            this.правилаToolStripMenuItem.Click += new System.EventHandler(this.ПравилаToolStripMenuItemClick);
            // 
            // обИгреToolStripMenuItem
            // 
            this.обИгреToolStripMenuItem.Name = "обИгреToolStripMenuItem";
            this.обИгреToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.обИгреToolStripMenuItem.Text = "О программе";
            this.обИгреToolStripMenuItem.Click += new System.EventHandler(this.ОбИгреToolStripMenuItemClick);
            // 
            // GameFieldPictureBox
            // 
            this.GameFieldPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GameFieldPictureBox.BackColor = System.Drawing.Color.White;
            this.GameFieldPictureBox.Location = new System.Drawing.Point(192, 25);
            this.GameFieldPictureBox.Name = "GameFieldPictureBox";
            this.GameFieldPictureBox.Size = new System.Drawing.Size(250, 371);
            this.GameFieldPictureBox.TabIndex = 1;
            this.GameFieldPictureBox.TabStop = false;
            this.GameFieldPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GameFieldPictureBoxPaint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ElapsedTimeLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ScoreLabel);
            this.groupBox1.Controls.Add(this.FiguresLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Score";
            // 
            // ElapsedTimeLabel
            // 
            this.ElapsedTimeLabel.Location = new System.Drawing.Point(108, 57);
            this.ElapsedTimeLabel.Name = "ElapsedTimeLabel";
            this.ElapsedTimeLabel.Size = new System.Drawing.Size(50, 21);
            this.ElapsedTimeLabel.TabIndex = 5;
            this.ElapsedTimeLabel.Text = "14:25";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Time has passed:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Location = new System.Drawing.Point(108, 36);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(50, 21);
            this.ScoreLabel.TabIndex = 3;
            this.ScoreLabel.Text = "0";
            // 
            // FiguresLabel
            // 
            this.FiguresLabel.Location = new System.Drawing.Point(108, 15);
            this.FiguresLabel.Name = "FiguresLabel";
            this.FiguresLabel.Size = new System.Drawing.Size(50, 21);
            this.FiguresLabel.TabIndex = 2;
            this.FiguresLabel.Text = "396";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Points:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shapes reset:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NextFigurePictureBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 113);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Next figure";
            // 
            // NextFigurePictureBox
            // 
            this.NextFigurePictureBox.Location = new System.Drawing.Point(31, 24);
            this.NextFigurePictureBox.Name = "NextFigurePictureBox";
            this.NextFigurePictureBox.Size = new System.Drawing.Size(96, 89);
            this.NextFigurePictureBox.TabIndex = 0;
            this.NextFigurePictureBox.TabStop = false;
            this.NextFigurePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.NextFigurePictureBoxPaint);
            // 
            // TipsCheckBox
            // 
            this.TipsCheckBox.Checked = true;
            this.TipsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TipsCheckBox.Location = new System.Drawing.Point(12, 229);
            this.TipsCheckBox.Name = "TipsCheckBox";
            this.TipsCheckBox.Size = new System.Drawing.Size(164, 22);
            this.TipsCheckBox.TabIndex = 4;
            this.TipsCheckBox.TabStop = false;
            this.TipsCheckBox.Text = "Tips";
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
            this.groupBox3.Controls.Add(this.AdviceLabel);
            this.groupBox3.Location = new System.Drawing.Point(12, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 128);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tip";
            // 
            // AdviceLabel
            // 
            this.AdviceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdviceLabel.Location = new System.Drawing.Point(6, 15);
            this.AdviceLabel.Name = "AdviceLabel";
            this.AdviceLabel.Size = new System.Drawing.Size(152, 110);
            this.AdviceLabel.TabIndex = 0;
            this.AdviceLabel.Text = "Use the Q key to postpone the shape and use the following";
            // 
            // GameFieldPictureBox2
            // 
            this.GameFieldPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GameFieldPictureBox2.BackColor = System.Drawing.Color.White;
            this.GameFieldPictureBox2.Location = new System.Drawing.Point(509, 27);
            this.GameFieldPictureBox2.Name = "GameFieldPictureBox2";
            this.GameFieldPictureBox2.Size = new System.Drawing.Size(250, 371);
            this.GameFieldPictureBox2.TabIndex = 6;
            this.GameFieldPictureBox2.TabStop = false;
            this.GameFieldPictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.GameFieldPictureBox2_Paint);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ElapsedTimeLabel2);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.ScoreLabel2);
            this.groupBox4.Controls.Add(this.FiguresLabel2);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(765, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(164, 80);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Score";
            // 
            // ElapsedTimeLabel2
            // 
            this.ElapsedTimeLabel2.Location = new System.Drawing.Point(108, 57);
            this.ElapsedTimeLabel2.Name = "ElapsedTimeLabel2";
            this.ElapsedTimeLabel2.Size = new System.Drawing.Size(50, 21);
            this.ElapsedTimeLabel2.TabIndex = 5;
            this.ElapsedTimeLabel2.Text = "14:25";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Time has passed:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ScoreLabel2
            // 
            this.ScoreLabel2.Location = new System.Drawing.Point(108, 36);
            this.ScoreLabel2.Name = "ScoreLabel2";
            this.ScoreLabel2.Size = new System.Drawing.Size(50, 21);
            this.ScoreLabel2.TabIndex = 3;
            this.ScoreLabel2.Text = "0";
            // 
            // FiguresLabel2
            // 
            this.FiguresLabel2.Location = new System.Drawing.Point(108, 15);
            this.FiguresLabel2.Name = "FiguresLabel2";
            this.FiguresLabel2.Size = new System.Drawing.Size(50, 21);
            this.FiguresLabel2.TabIndex = 2;
            this.FiguresLabel2.Text = "396";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Points:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Shapes reset:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.NextFigurePictureBox2);
            this.groupBox5.Location = new System.Drawing.Point(765, 111);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(164, 113);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Next figure";
            // 
            // NextFigurePictureBox2
            // 
            this.NextFigurePictureBox2.Location = new System.Drawing.Point(31, 24);
            this.NextFigurePictureBox2.Name = "NextFigurePictureBox2";
            this.NextFigurePictureBox2.Size = new System.Drawing.Size(96, 89);
            this.NextFigurePictureBox2.TabIndex = 0;
            this.NextFigurePictureBox2.TabStop = false;
            this.NextFigurePictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.NextFigurePictureBox2_Paint);
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(765, 229);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(164, 22);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "Tips";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.AdviceLabel2);
            this.groupBox6.Location = new System.Drawing.Point(765, 257);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(164, 141);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tip";
            // 
            // AdviceLabel2
            // 
            this.AdviceLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdviceLabel2.Location = new System.Drawing.Point(6, 15);
            this.AdviceLabel2.Name = "AdviceLabel2";
            this.AdviceLabel2.Size = new System.Drawing.Size(152, 123);
            this.AdviceLabel2.TabIndex = 0;
            this.AdviceLabel2.Text = "Use the Q key to postpone the shape and use the following";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 435);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Tetris";
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
    }
}
