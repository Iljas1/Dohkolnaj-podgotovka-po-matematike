/*
 * Сделано в SharpDevelop.
 * Пользователь: Admin
 * Дата: 05.04.2019
 * Время: 12:45
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
	/// Description of Form6.
	/// </summary>
	public partial class Form6 : Form
	{
		string rehenie0 = "0";
		string rehenie1 = "1";
		string rehenie2 = "2";
		string rehenie3 = "3";
		
		private SoundPlayer Kakoe_shislo_vstavit_v_kvadrat; 
		
		public Form6()
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
			if (textBox1.Text == rehenie1)
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
		
		void TextBox4TextChanged(object sender, EventArgs e)
		{
			if (textBox4.Text == rehenie1)
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
		
		void TextBox3TextChanged(object sender, EventArgs e)
		{
			if (textBox3.Text == rehenie0)
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
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			if (textBox2.Text == rehenie2)
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
		
		void TextBox6TextChanged(object sender, EventArgs e)
		{
			if (textBox6.Text == rehenie1)
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
		
		void TextBox14TextChanged(object sender, EventArgs e)
		{
			if (textBox14.Text == rehenie2)
		{
			textBox14.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox14.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
  		        textBox14.Text = "";
			}
		}
		
		void TextBox12TextChanged(object sender, EventArgs e)
		{
			if (textBox12.Text == rehenie0)
		{
			textBox12.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox12.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
  		        textBox12.Text = "";
			}
		}
		
		void TextBox11TextChanged(object sender, EventArgs e)
		{
			if (textBox11.Text == rehenie1)
		{
			textBox11.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox11.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
  		        textBox11.Text = "";
			}
		}
		
		void TextBox10TextChanged(object sender, EventArgs e)
		{
			if (textBox10.Text == rehenie2)
		{
			textBox10.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox10.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
  		        textBox10.Text = "";
			}
		}
		
		void TextBox7TextChanged(object sender, EventArgs e)
		{
			if (textBox7.Text == rehenie1)
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
		
		void TextBox24TextChanged(object sender, EventArgs e)
		{
			if (textBox24.Text == rehenie1)
		{
			textBox24.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox24.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
  		        textBox24.Text = "";
			}
		}
		
		void TextBox23TextChanged(object sender, EventArgs e)
		{
			if (textBox23.Text == rehenie1)
		{
			textBox23.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox23.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
  		        textBox23.Text = "";
			}
		}
		
		void TextBox22TextChanged(object sender, EventArgs e)
		{
			if (textBox22.Text == rehenie2)
		{
			textBox22.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox22.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
  		        textBox22.Text = "";
			}
		}
		
		void TextBox21TextChanged(object sender, EventArgs e)
		{
			if (textBox21.Text == rehenie2)
		{
			textBox21.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox21.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
  		        textBox21.Text = "";
			}
		}
		
		void TextBox9TextChanged(object sender, EventArgs e)
		{
		if (textBox9.Text == rehenie1)
		{
			textBox9.BackColor = Color.YellowGreen;
			
                Hide(); 
			}
			else
			{
				textBox9.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
  		        textBox9.Text = "";
			}	
		}
		
		void Button2Click(object sender, EventArgs e)
		{
		Kakoe_shislo_vstavit_v_kvadrat.Stop();	
		}
		
		void НазадToolStripMenuItemClick(object sender, EventArgs e)
		{
			MainForm Fr2 = new MainForm(); 
            Fr2.Show(); 
            Hide(); 
		}
		
		void ВыходToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Kakoe_shislo_vstavit_v_kvadrat = new SoundPlayer(); 
			Kakoe_shislo_vstavit_v_kvadrat.SoundLocation = "Kakoe_shislo_vstavit_v_kvadrat.wav"; 
			Kakoe_shislo_vstavit_v_kvadrat.Play();
		}
	}
}
