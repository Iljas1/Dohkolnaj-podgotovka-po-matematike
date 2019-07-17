/*
 * Сделано в SharpDevelop.
 * Пользователь: Admin
 * Дата: 05.04.2019
 * Время: 9:48
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Дошкольная_подготовка_по_математике
{
	/// <summary>
	/// Description of Form5.
	/// </summary>
	public partial class Form5 : Form
	{
	string kub0 = "0";
	string kub1 = "1";
	string kub2 = "2";
	string kub3 = "3";
	string kub4 = "4";
	string kub5 = "5";
	
	private SoundPlayer Reshi_primeri; 
	
		public Form5()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			if (textBox1.Text == kub1)
			{
				textBox1.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox1.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
			    textBox1.Text = "";
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			 Application.Exit();
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			if (textBox2.Text == kub0)
			{
				textBox2.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox2.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
			   textBox2.Text = "";
			 }   
		}
		
		void TextBox3TextChanged(object sender, EventArgs e)
		{
			if (textBox3.Text == kub1)
			{
				textBox3.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox3.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
			   textBox3.Text = "";
			 }   
		}
		
		void TextBox4TextChanged(object sender, EventArgs e)
		{
			if (textBox4.Text == kub2)
			{
				textBox4.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox4.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
			   textBox4.Text = "";
			 }   
		}
		
		void TextBox7TextChanged(object sender, EventArgs e)
		{
			if (textBox7.Text == kub3)
			{
				textBox7.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox7.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
			   textBox7.Text = "";
			 }   
		}
		
		void TextBox6TextChanged(object sender, EventArgs e)
		{
			if (textBox6.Text == kub5)
			{
				textBox6.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox6.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
			   textBox6.Text = "";
			}
		}
		
		void TextBox5TextChanged(object sender, EventArgs e)
		{
			if (textBox5.Text == kub3)
			{
				textBox5.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox5.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
			   textBox5.Text = "";
			}
		}
		
		void TextBox8TextChanged(object sender, EventArgs e)
		{
			if (textBox8.Text == kub4)
			{
				textBox8.BackColor = Color.YellowGreen;
				
                Hide(); 
			}
			else
			{
				textBox8.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
			   textBox8.Text = "";		   
			}
		}
		
		void Button40Click(object sender, EventArgs e)
		{
			Reshi_primeri.Stop();
		}
		
		void Button44Click(object sender, EventArgs e)
		{
				Reshi_primeri = new SoundPlayer(); 
			Reshi_primeri.SoundLocation = "Reshi_primeri.wav"; 
			Reshi_primeri.Play();
		}
		
		void ВыходToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void НазадToolStripMenuItemClick(object sender, EventArgs e)
		{
			MainForm fr2 = new MainForm();
			fr2.Show();
			Hide();
		}
    }
}
	
