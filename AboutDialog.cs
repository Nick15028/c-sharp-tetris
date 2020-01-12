﻿/*
 * Сделано в SharpDevelop.
 * Пользователь: user
 * Дата: 08.11.2013
 * Время: 18:18
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
	/// <summary>
	/// Dialog "About the program"
	/// </summary>
	public partial class AboutDialog : Form
	{
		public AboutDialog()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			DialogResult=DialogResult.OK;
		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start("http://vk.com/imaginarius");
			}
			catch
			{
				MessageBox.Show("Your rotten OS was unable to open the link -_-",
				                "Mistake!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void LinkLabel2LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start("http://www.everaldo.com/");
			}
			catch
			{
				MessageBox.Show("Your rotten OS was unable to open the link -_-",
				                "Mistake!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
