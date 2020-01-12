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
using System.Windows.Forms;

namespace Tetris
{
	public class TetrisGame
	{
		public Figure NextFigure, NextFigure2;

		private int score, score2;
		public int Score
		{
			get { return score; }
			set
			{
				score=value;
				OnStateChanged();
			}
		}
        public int Score2
        {
            get { return score2; }
            set
            {
                score2 = value;
                OnStateChanged();
            }
        }


        private int figDropped, figDropped2;
		public int FiguresDropped
		{
			get { return figDropped; }
			set
			{
				figDropped=value;
				OnStateChanged();
			}
		}
        public int FiguresDropped2
        {
            get { return figDropped2; }
            set
            {
                figDropped2 = value;
                OnStateChanged();
            }
        }


        private bool gameOver, paused, figChanged, figChanged2;
		public bool GameOver
		{
			get { return gameOver; }
			set
			{
				gameOver=value;
				OnStateChanged();
			}
		}
		public bool Paused
		{
			get { return paused; }
			set
			{
				if(!paused && value)
				{
					GamePaused=DateTime.Now;
					paused=value;
					OnStateChanged();
				}
				if(paused && !value)
				{
					GameStarted=GameStarted+(DateTime.Now-GamePaused);
					paused=value;
					OnStateChanged();
				}
			}
		}
		public bool FigureChanged
		{
			get { return figChanged; }
			set
			{
				figChanged=value;
				OnStateChanged();
			}
		}

        public bool FigureChanged2
        {
            get { return figChanged2; }
            set
            {
                figChanged2 = value;
                OnStateChanged();
            }
        }

        public DateTime GameStarted, GamePaused;
		
		
		/// <summary>
		/// 建構子
		/// </summary>
		public TetrisGame()
		{
			Score = 0; FiguresDropped=0;
            Score2 = 0; FiguresDropped2 = 0;
            NextFigure =Figure.RandomFigure();
            NextFigure2= Figure.RandomFigure();
            GameOver =false; Paused=false; 
            FigureChanged=false; FigureChanged2 = false;

            GameStarted =DateTime.Now;
		}
		
		/// <summary>
		/// Ends the game
		/// </summary>
		public void Over()
		{
			GameOver=true;
		}
		
		
		public event EventHandler StateChanged;
		protected virtual void OnStateChanged()
		{
			if (StateChanged != null)
			{
				StateChanged(this, new EventArgs());
			}
		}
	}
}
