/*
 * Created by SharpDevelop.
 * User: user
 * Date: 08.10.2013
 * Time: 2:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using System.Threading;

namespace Tetris
{
	/// <summary>
	/// Main form
	/// </summary>
	public partial class MainForm : Form
	{
		private GameField GF, GF2;
		private TetrisField Preview, Preview2;
		private TetrisGame Game;
		
		private NewRecordDialog NRDialog;
		private RecordsForm RForm;
		
		
		private Image PausedImage, GameOverImage;
		
		public MainForm()
		{
			Game=new TetrisGame();
			Game.Score=0; Game.GameOver=true;
            Game.Score2 = 0;
			
			Saver.Load();
			
			GF=new GameField(18, 12);
            GF2 = new GameField(18, 12);/////

            Preview =new TetrisField(4, 4);
			Preview.BorderColor=Preview.BackColor;

            Preview2 = new TetrisField(4, 4);
            Preview2.BorderColor = Preview2.BackColor;

            Random rnd=new Random();

            // Type splash
            for (int row=0; row<GF.TilesHeight; row++)
			{
				for(int col=0; col<GF.TilesWidth; col++)
				{
					TileType t=(TileType)rnd.Next(0, 7);
					GF.SetCell(row, col, t);
				}
			}

            //
            for (int row = 0; row < GF2.TilesHeight; row++)
            {
                for (int col = 0; col < GF2.TilesWidth; col++)
                {
                    TileType t = (TileType)rnd.Next(0, 7);
                    GF2.SetCell(row, col, t);
                }
            }
            //

            Game.StateChanged+=new EventHandler(Game_StateChanged);
			Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
			InitializeComponent();
			
		}

		void Game_StateChanged(object sender, EventArgs e)
		{
			ScoreLabel.Text=Game.Score.ToString();
            ScoreLabel2.Text = Game.Score2.ToString();
            FiguresLabel.Text=Game.FiguresDropped.ToString();
            FiguresLabel2.Text = Game.FiguresDropped2.ToString();
            ElapsedTimeLabel.Text=(DateTime.Now-Game.GameStarted).ToString();
            ElapsedTimeLabel2.Text = (DateTime.Now - Game.GameStarted).ToString();
            Refresh();
		}
		
		private void SetScore(int nscore)
		{
			Game.Score=nscore;
			//ScoreLabel.Text=Score.ToString();
		}

        private void SetScore2(int nscore)
        {
            Game.Score2 = nscore;
            //ScoreLabel.Text=Score.ToString();
        }

        private void NewGame()
		{
			Game=new TetrisGame();
			Game.StateChanged+= new EventHandler(Game_StateChanged);
			SetScore(0);
            SetScore2(0);

            GameTimer.Interval=700;
			GameTimer.Enabled=true;
			
			Game.NextFigure=Figure.RandomFigure();
            Game.NextFigure2 = Figure.RandomFigure();

            GF.Clear();
            GF2.Clear();////////

            Refresh();
		}
		
		private void SetPause(bool enable)
		{
			if(Game.GameOver) return;
			Game.Paused=enable;
			
			GameTimer.Enabled=!enable;
			
			//Refresh();
		}
		
		// Game cycle
		void GameTimerTick(object sender, EventArgs e)
		{
			if(Game.Paused) return;
			
			GF.DoStep();
            GF2.DoStep();///////

            if (!GF.IsFigureFalling) 
			{
				//you need to put a new figure on the field and hide the full rows
				SetScore(Game.Score+GF.RemoveFullRows()*10);
				
				if(!GF.PlaceFigure(Game.NextFigure))
				{
					//game over
					OnGameOver();
				}
				else
				{
					Game.NextFigure=Figure.RandomFigure();
					Game.FiguresDropped++;
					FiguresLabel.Text=Game.FiguresDropped.ToString();
					Preview.Clear();
					Preview.SetFigure(Game.NextFigure.MoveTo(1, 1), false);
					
					if(Game.FigureChanged && Game.FiguresDropped%5==0) Game.FigureChanged=false;
					//speed up the game with increasing points
					if(Game.FiguresDropped%15==0 && Game.Score!=0)
					{
						if(GameTimer.Interval>300)
						{
							//GameTimer.Enabled=false;
							GameTimer.Interval-=100;
							//GameTimer.Enabled=true;
						}
					}
					
					ShowAdvice();
				}
			}

            //
            if (!GF2.IsFigureFalling)
            {
                //you need to put a new figure on the field and hide the full rows
                SetScore2(Game.Score2 + GF2.RemoveFullRows() * 10);

                if (!GF2.PlaceFigure(Game.NextFigure2))
                {
                    //game over
                    OnGameOver();
                }
                else
                {
                    Game.NextFigure2 = Figure.RandomFigure();
                    Game.FiguresDropped2++;
                    FiguresLabel2.Text = Game.FiguresDropped2.ToString();
                    Preview2.Clear();
                    Preview2.SetFigure(Game.NextFigure2.MoveTo(1, 1), false);

                    if (Game.FigureChanged2 && Game.FiguresDropped2 % 5 == 0) Game.FigureChanged2 = false;
                    //speed up the game with increasing points
                    if (Game.FiguresDropped2 % 15 == 0 && Game.Score2 != 0)
                    {
                        if (GameTimer.Interval > 300)
                        {
                            //GameTimer.Enabled=false;
                            GameTimer.Interval -= 100;
                            //GameTimer.Enabled=true;
                        }
                    }

                    ShowAdvice2();
                }
            }//


            ElapsedTimeLabel.Text=(DateTime.Now-Game.GameStarted).ToString(@"mm\:ss");
            ElapsedTimeLabel2.Text = (DateTime.Now - Game.GameStarted).ToString(@"mm\:ss");

            Refresh();
		}
		
		private void OnGameOver()
		{
			Game.Over();
			GameTimer.Enabled=false;

            TetrisSave test;
            if (Game.Score>Game.Score2)
            {
                test = new TetrisSave("---", Game.Score, DateTime.Now - Game.GameStarted);//////////////////////
            }
            else//Game.Score<=Game.Score2
            {
                test = new TetrisSave("---", Game.Score2, DateTime.Now - Game.GameStarted);//////////////////////
            }
                
			if(Saver.HighScores.CanAdd(test) || Saver.HighTimes.CanAdd(test))
			{
				NRDialog=new NewRecordDialog();
				if(NRDialog.ShowDialog()==DialogResult.OK)
				{
					test.UserName=NRDialog.UserName;
					Saver.Save(test);
					
					RForm=new RecordsForm(test);
					if(RForm.ShowDialog()==DialogResult.OK)
					{
						NewGame();
					}
				}
			}
		}
		
		private static string[] Advices=new string[]
		{
			"Wait until the indicator disappears around the image of the next figure to be able to postpone the figure!",
            "Use the magic key to postpone the shape and use the next",
            "Along with the number of discarded pieces, the speed of the game grows",
            "To get into the high score table, you can either score the most points and stay in the game longer than anyone else",
            "Use the F3 key to pause the game",
            "Decided to start a new game? Press F2 to do it immediately!"
		};
		private void ShowAdvice(int advice)
		{
			AdviceLabel.Text=Advices[advice];
		}
		private void ShowAdvice()
		{
			ShowAdvice(new Random().Next(1, Advices.Length));
		}
        private void ShowAdvice2(int advice)
        {
            AdviceLabel2.Text = Advices[advice];
        }
        private void ShowAdvice2()
        {
            ShowAdvice2(new Random().Next(1, Advices.Length));
        }

        // Input processing
        void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			e.SuppressKeyPress=true;
			
			if(Game.GameOver || Game.Paused) return;
			
			if(e.KeyData==Keys.A)
			{
				GF.MoveLeft();
			}
            if (e.KeyData == Keys.NumPad1)
            {
                GF2.MoveLeft();
            }


            if (e.KeyData==Keys.D)
			{
				GF.MoveRight();
			}
            if (e.KeyData == Keys.NumPad3)
            {
                GF2.MoveRight();
            }


            if (e.KeyData==Keys.W)
			{
				if(GF.Drop())
					SetScore(Game.Score+5);
			}

            if (e.KeyData == Keys.NumPad5)
            {
                if (GF2.Drop())
                    SetScore2(Game.Score2 + 5);
            }


            if (e.KeyData==Keys.S)
			{
				if(GF.MoveDown())
					SetScore(Game.Score+1);
			}
            if (e.KeyData == Keys.NumPad2)
            {
                if (GF2.MoveDown())
                    SetScore2(Game.Score2 + 1);
            }


            if (e.KeyData==Keys.Space)
			{
				GF.RotateFigure();
			}
            if (e.KeyData == Keys.Enter)
            {
                GF2.RotateFigure();
            }

            if (e.KeyData==Keys.Q)
			{
				if(!Game.FigureChanged && GF.IsFigureFalling)
				{
					Game.NextFigure=new Figure(GF.ChangeFigure(Game.NextFigure).Type);
					Preview.Clear();
					Preview.SetFigure(Game.NextFigure.MoveTo(1, 1), false);
					Game.FigureChanged=true;
					if(Game.NextFigure==Figure.Zero)
						OnGameOver();
				}
				if(Game.FigureChanged)
				{
					ShowAdvice(0);
				}
			}
            if (e.KeyData == Keys.NumPad4)
            {
                if (!Game.FigureChanged2 && GF2.IsFigureFalling)
                {
                    Game.NextFigure2 = new Figure(GF2.ChangeFigure(Game.NextFigure2).Type);
                    Preview2.Clear();
                    Preview2.SetFigure(Game.NextFigure2.MoveTo(1, 1), false);
                    Game.FigureChanged2 = true;
                    if (Game.NextFigure2 == Figure.Zero)
                        OnGameOver();
                }
                if (Game.FigureChanged2)
                {
                    ShowAdvice2(0);
                }
            }

            Refresh();
		}

		
		void GameFieldPictureBoxPaint(object sender, PaintEventArgs e)
		{
			GF.Paint(e.Graphics);
			
			if(Game.Paused)
			{
				Rectangle img=new Rectangle((GameFieldPictureBox.Width-PausedImage.Width)/2,
				                            (GameFieldPictureBox.Height-PausedImage.Height)/2,
				                            PausedImage.Width, PausedImage.Height);
				e.Graphics.DrawImage(PausedImage, img);
				return;
			}
			if(Game.GameOver)
			{
				Rectangle img=new Rectangle((GameFieldPictureBox.Width-GameOverImage.Width)/2,
				                            (GameFieldPictureBox.Height-GameOverImage.Height)/2,
				                            GameOverImage.Width, GameOverImage.Height);
				e.Graphics.DrawImage(GameOverImage, img);
			}
		}
        //
        private void GameFieldPictureBox2_Paint(object sender, PaintEventArgs e)
        {
            GF2.Paint(e.Graphics);

            if (Game.Paused)
            {
                Rectangle img = new Rectangle((GameFieldPictureBox2.Width - PausedImage.Width) / 2,
                                            (GameFieldPictureBox2.Height - PausedImage.Height) / 2,
                                            PausedImage.Width, PausedImage.Height);
                e.Graphics.DrawImage(PausedImage, img);
                return;
            }
            if (Game.GameOver)
            {
                Rectangle img = new Rectangle((GameFieldPictureBox2.Width - GameOverImage.Width) / 2,
                                            (GameFieldPictureBox2.Height - GameOverImage.Height) / 2,
                                            GameOverImage.Width, GameOverImage.Height);
                e.Graphics.DrawImage(GameOverImage, img);
            }

        }
        //

        void НоваяИграToolStripMenuItemClick(object sender, EventArgs e)
		{
			NewGame();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			//string[] res = GetType().Assembly.GetManifestResourceNames();
			
			try
			{
				TetrisField.Blue=new System.Drawing.Bitmap(GetType().Assembly.GetManifestResourceStream("ImBLUE"));
				TetrisField.Red=new System.Drawing.Bitmap(GetType().Assembly.GetManifestResourceStream("ImRED"));
				TetrisField.Green=new System.Drawing.Bitmap(GetType().Assembly.GetManifestResourceStream("ImGREEN"));
				TetrisField.LightBlue=new System.Drawing.Bitmap(GetType().Assembly.GetManifestResourceStream("ImLBLUE"));
				TetrisField.Purple=new System.Drawing.Bitmap(GetType().Assembly.GetManifestResourceStream("ImPURPLE"));
				TetrisField.Yellow=new System.Drawing.Bitmap(GetType().Assembly.GetManifestResourceStream("ImYELLOW"));
				TetrisField.Orange=new System.Drawing.Bitmap(GetType().Assembly.GetManifestResourceStream("ImORANGE"));
                TetrisField.Black = new System.Drawing.Bitmap(GetType().Assembly.GetManifestResourceStream("ImBLACK"));
                TetrisField.Pink = new System.Drawing.Bitmap(GetType().Assembly.GetManifestResourceStream("ImPINK"));

                PausedImage =new System.Drawing.Bitmap(GetType().Assembly.GetManifestResourceStream("ImPAUSE"));
				GameOverImage=new System.Drawing.Bitmap(GetType().Assembly.GetManifestResourceStream("ImGAMEOVER"));
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка при загрузке изображений!");
			}
			
			//MessageBox.Show(string.Join(", ", res));
		}		
		
		void NextFigurePictureBoxPaint(object sender, PaintEventArgs e)
		{
			Preview.BorderColor=Game.FigureChanged? Color.FromArgb(160, 128, 128) : Preview.BackColor;
			Preview.Paint(e.Graphics);
		}

        private void NextFigurePictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Preview2.BorderColor = Game.FigureChanged2 ? Color.FromArgb(160, 128, 128) : Preview2.BackColor;
            Preview2.Paint(e.Graphics);
        }

        void TipsCheckBoxCheckedChanged(object sender, EventArgs e)
		{
			GF.ShowTips=TipsCheckBox.Checked;
		}
		
		void ПаузапродолжитьToolStripMenuItemClick(object sender, EventArgs e)
		{
			SetPause(!Game.Paused);
		}
		
		void ВыходToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}

        private void 中文ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-TW");
            this.Controls.Clear();
            InitializeComponent();
        }

        private void 英文ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            this.Controls.Clear();
            InitializeComponent();
        }

        void ТаблицаРекордовToolStripMenuItemClick(object sender, EventArgs e)
		{
			RForm=new RecordsForm(new TetrisSave());
			if(RForm.ShowDialog()==DialogResult.OK && Game.GameOver)
				NewGame();
		}

       

        void ОбИгреToolStripMenuItemClick(object sender, EventArgs e)
		{
			new AboutDialog().ShowDialog();
		}
		
		void ПравилаToolStripMenuItemClick(object sender, EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start(@"help\help.htm");
			}
			catch
			{
				try
				{
					System.Diagnostics.Process.Start(@"help\");
				}
				catch
				{
					MessageBox.Show("Не удалось открыть файл помощи О_о Попробуйте самостоятельно открыть папку с игрой," +
					                " а в ней - папку help", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}

/////////////Magic Power///////////////


