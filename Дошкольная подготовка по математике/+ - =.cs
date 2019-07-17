/*
 * Сделано в SharpDevelop.
 * Пользователь: Admin
 * Дата: 01.04.2019
 * Время: 12:04
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
	/// Description of ______.
	/// </summary>
	public partial class Form2 : Form
	{
		    string otvet1 = "8";
		    string otvet2 = "4";
			string otvet3 = "9";
			string otvet4 = "6";
			string otvet5 = "3";
			string otvet6 = "1";
			string otvet7 = "2";
			string otvet8 = "5";
			string otvet9 = "1";
			string otvet10 = "3";
		    string otvet11 = "9";
		    string otvet12 = "2";
		    string otvet13 = "5";
		    string otvet14 = "3";
		    string otvet15 = "8";
		    
		    private SoundPlayer Reshi_primeri; 
	
		    
		public Form2()
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
			if(textBox1.Text == "8")
			{
				textBox1.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox1.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
				textBox1.Text = "";
			}
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			if(textBox2.Text == "4")
			{
				textBox2.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox2.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
				textBox2.Text = "";
			}
		}
		
		void TextBox3TextChanged(object sender, EventArgs e)
		{
			if(textBox3.Text == "9")
			{
				textBox3.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox3.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
				textBox3.Text = "";
			}
		}
		
		void TextBox4TextChanged(object sender, EventArgs e)
		{
				if(textBox4.Text == "6")
			{
				textBox4.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox4.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
				textBox4.Text = "";
			}
		}
		
		void TextBox5TextChanged(object sender, EventArgs e)
		{
				if(textBox5.Text == "3")
			{
				textBox5.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox5.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
				textBox5.Text = "";
			}
		}
		
		void TextBox6TextChanged(object sender, EventArgs e)
		{
				if(textBox6.Text == "1")
			{
				textBox6.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox6.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
				textBox6.Text = "";
			}
		}
		
		void TextBox7TextChanged(object sender, EventArgs e)
		{
			if(textBox7.Text == "2")
			{
				textBox7.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox7.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
				textBox7.Text = "";
			}
		}
		
		void TextBox11TextChanged(object sender, EventArgs e)
		{
			if(textBox11.Text == "5")
			{
				textBox11.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox11.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
				textBox11.Text = "";
			}
		}
		
		void TextBox10TextChanged(object sender, EventArgs e)
		{
			if(textBox10.Text == "1")
			{
				textBox10.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox10.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
				textBox10.Text = "";
			}
		}
		
		void TextBox12TextChanged(object sender, EventArgs e)
		{
			if(textBox12.Text == "3")
			{
				textBox12.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox12.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
				textBox12.Text = "";
			}
		}
		
		void TextBox15TextChanged(object sender, EventArgs e)
		{
			if(textBox15.Text == "9")
			{
				textBox15.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox15.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
				textBox15.Text = "";
			}
		}
		
		void TextBox14TextChanged(object sender, EventArgs e)
		{
			if(textBox14.Text == "2")
			{
				textBox14.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox14.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
				textBox14.Text = "";
			}
		}
		
		void TextBox13TextChanged(object sender, EventArgs e)
		{
			if(textBox13.Text == "5")
			{
				textBox13.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox13.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
				textBox13.Text = "";
			}
		}
		
		void TextBox9TextChanged(object sender, EventArgs e)
		{
			if(textBox9.Text == "3")
			{
				textBox9.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox9.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
				textBox9.Text = "";
			}
		}
		
		void TextBox8TextChanged(object sender, EventArgs e)
		{
			if(textBox8.Text == "8")
			{
				textBox8.BackColor = Color.YellowGreen;
				 
                Hide(); 
			}
			else
			{
				textBox8.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
				textBox8.Text = "";
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Reshi_primeri.Stop();	
		}
		
		void ВыходToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void НазадToolStripMenuItemClick(object sender, EventArgs e)
		{
			MainForm Fr2 = new MainForm(); 
            Fr2.Show(); 
            Hide(); 
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Reshi_primeri = new SoundPlayer(); 
			Reshi_primeri.SoundLocation = "Reshi_primeri.wav"; 
			Reshi_primeri.Play();
		}
	}
}
