/*
 * Сделано в SharpDevelop.
 * Пользователь: Admin
 * Дата: 01.04.2019
 * Время: 12:18
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
	/// Description of Forrm3.
	/// </summary>
	public partial class Forrm3 : Form
	{
		string Znak1 = "<";
		string Znak2 = "=";
		string Znak3 = ">";
		
		private SoundPlayer Kakoe_shislo_bolshe; 
		
		public Forrm3()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Text = button2.Text;
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			textBox1.Text = button3.Text;
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			textBox1.Text = button4.Text;
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			if(textBox1.Text == Znak1) 
			{
				textBox1.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox1.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox1.Text = "";
			}
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			if(textBox2.Text == Znak2) 
			{
				textBox2.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox2.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox2.Text = "";
			}
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			textBox2.Text = button7.Text;
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			textBox2.Text = button6.Text;
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			textBox2.Text = button5.Text;
		}
		
		void TextBox3TextChanged(object sender, EventArgs e)
		{
		if(textBox3.Text == Znak3) 
		{
				textBox3.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox3.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox3.Text = "";
			}
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			textBox3.Text = button10.Text;
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			textBox3.Text = button9.Text;
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			textBox3.Text = button8.Text;
		}
		
		void TextBox4TextChanged(object sender, EventArgs e)
		{
			if(textBox4.Text == Znak1) 
		{
				textBox4.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox4.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox4.Text = "";
			}
		}
		
		void Button13Click(object sender, EventArgs e)
		{
			textBox4.Text = button13.Text;
		}
		
		void Button12Click(object sender, EventArgs e)
		{
			textBox4.Text = button12.Text;
		}
		
		void Button11Click(object sender, EventArgs e)
		{
			textBox4.Text = button11.Text;
		}
		
		void TextBox5TextChanged(object sender, EventArgs e)
		{
			if(textBox5.Text == Znak3) 
		{
				textBox5.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox5.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox5.Text = "";
			}
		}
		
		void Button16Click(object sender, EventArgs e)
		{
				textBox5.Text = button16.Text;
		}
		
		void Button15Click(object sender, EventArgs e)
		{
				textBox5.Text = button15.Text;
		}
		
		void Button14Click(object sender, EventArgs e)
		{
			textBox5.Text = button14.Text;	
		}
		
		void TextBox6TextChanged(object sender, EventArgs e)
		{
			if(textBox6.Text == Znak1) 
		{
				textBox6.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox6.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox6.Text = "";
			}
		}
		
		void Button19Click(object sender, EventArgs e)
		{
			textBox6.Text = button19.Text;	
		}
		
		void Button18Click(object sender, EventArgs e)
		{
		textBox6.Text = button18.Text;		
		}
		
		void Button17Click(object sender, EventArgs e)
		{
			textBox6.Text = button17.Text;	
		}
		
		void TextBox7TextChanged(object sender, EventArgs e)
		{
			if(textBox7.Text == Znak3) 
		{
				textBox7.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox7.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox7.Text = "";
			}
		}
		
		void Button22Click(object sender, EventArgs e)
		{
			textBox7.Text = button22.Text;	
		}
		
		void Button21Click(object sender, EventArgs e)
		{
			textBox7.Text = button21.Text;	
		}
		
		void Button20Click(object sender, EventArgs e)
		{
			textBox7.Text = button20.Text;	
		}
		
		void TextBox8TextChanged(object sender, EventArgs e)
		{
			if(textBox8.Text == Znak3) 
		{
				textBox8.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox8.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox8.Text = "";
			}
		}
		
		void Button25Click(object sender, EventArgs e)
		{
			textBox8.Text = button25.Text;
		}
		
		void Button24Click(object sender, EventArgs e)
		{
			textBox8.Text = button24.Text;
		}
		
		void Button23Click(object sender, EventArgs e)
		{
			textBox8.Text = button23.Text;
		}
		
		void TextBox9TextChanged(object sender, EventArgs e)
		{
			if(textBox9.Text == Znak3) 
		{
				textBox9.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox9.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox9.Text = "";
			}
		}
		
		void Button28Click(object sender, EventArgs e)
		{
			textBox9.Text = button28.Text;
		}
		
		void Button27Click(object sender, EventArgs e)
		{
			textBox9.Text = button27.Text;
		}
		
		void Button26Click(object sender, EventArgs e)
		{
			textBox9.Text = button26.Text;
		}
		
		void TextBox10TextChanged(object sender, EventArgs e)
		{
			if(textBox10.Text == Znak2) 
		{
				textBox10.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox10.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox10.Text = "";
			}
		}
		
		void Button31Click(object sender, EventArgs e)
		{
			textBox10.Text = button31.Text;
		}
		
		void Button30Click(object sender, EventArgs e)
		{
			textBox10.Text = button30.Text;
		}
		
		void Button29Click(object sender, EventArgs e)
		{
			textBox10.Text = button29.Text;
		}
		
		void TextBox15TextChanged(object sender, EventArgs e)
		{
			if(textBox15.Text == Znak1) 
		{
				textBox15.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox15.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox15.Text = "";
			}
		}
		
		void Button46Click(object sender, EventArgs e)
		{
			textBox15.Text = button46.Text;
		}
		
		void Button45Click(object sender, EventArgs e)
		{
			textBox15.Text = button45.Text;
		}
		
		void Button44Click(object sender, EventArgs e)
		{
			textBox15.Text = button44.Text;
		}
		
		void TextBox14TextChanged(object sender, EventArgs e)
		{
			if(textBox14.Text == Znak1) 
		{
				textBox14.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox14.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox14.Text = "";
			}
		}
		
		void Button43Click(object sender, EventArgs e)
		{
			textBox14.Text = button43.Text;
		}
		
		void Button42Click(object sender, EventArgs e)
		{
			textBox14.Text = button42.Text;
		}
		
		void Button41Click(object sender, EventArgs e)
		{
			textBox14.Text = button41.Text;
		}
		
		void TextBox13TextChanged(object sender, EventArgs e)
		{
			if(textBox13.Text == Znak3) 
		{
				textBox13.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox13.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox13.Text = "";
			}
		}
		
		void Button40Click(object sender, EventArgs e)
		{
			textBox13.Text = button40.Text;
		}
		
		void Button39Click(object sender, EventArgs e)
		{
			textBox13.Text = button39.Text;
		}
		
		void Button38Click(object sender, EventArgs e)
		{
			textBox13.Text = button38.Text;
		}
		
		void TextBox12TextChanged(object sender, EventArgs e)
		{
			if(textBox12.Text == Znak1) 
		{
				textBox12.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox12.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox12.Text = "";
			}
		}
		
		void Button37Click(object sender, EventArgs e)
		{
			textBox12.Text = button37.Text;
		}
		
		void Button36Click(object sender, EventArgs e)
		{
			textBox12.Text = button36.Text;
		}
		
		void Button35Click(object sender, EventArgs e)
		{
			textBox12.Text = button35.Text;
		}
		
		void TextBox17TextChanged(object sender, EventArgs e)
		{
			if(textBox17.Text == Znak3) 
		{
				textBox17.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox17.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox17.Text = "";
			}
		}
		
		void Button52Click(object sender, EventArgs e)
		{
			textBox17.Text = button52.Text;
		}
		
		void Button51Click(object sender, EventArgs e)
		{
			textBox17.Text = button51.Text;
		}
		
		void Button50Click(object sender, EventArgs e)
		{
			textBox17.Text = button50.Text;
		}
		
		void TextBox30TextChanged(object sender, EventArgs e)
		{
			if(textBox30.Text == Znak2) 
		{
				textBox30.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox30.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox30.Text = "";
			}
		}
		
		void Button91Click(object sender, EventArgs e)
		{
			textBox30.Text = button91.Text;
		}
		
		void Button90Click(object sender, EventArgs e)
		{
			textBox30.Text = button90.Text;
		}
		
		void Button89Click(object sender, EventArgs e)
		{
			textBox30.Text = button89.Text;
		}
		
		void TextBox27TextChanged(object sender, EventArgs e)
		{
			if(textBox27.Text == Znak3) 
		{
				textBox27.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox27.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox27.Text = "";
			}
		}
		
		void Button82Click(object sender, EventArgs e)
		{
			textBox27.Text = button82.Text;
		}
		
		void Button81Click(object sender, EventArgs e)
		{
			textBox27.Text = button81.Text;
		}
		
		void Button80Click(object sender, EventArgs e)
		{
			textBox27.Text = button80.Text;
		}
		
		void TextBox29TextChanged(object sender, EventArgs e)
		{
			if(textBox29.Text == Znak3) 
		{
				textBox29.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox29.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox29.Text = "";
			}
		}
		
		void Button88Click(object sender, EventArgs e)
		{
			textBox29.Text = button88.Text;
		}
		
		void Button87Click(object sender, EventArgs e)
		{
			textBox29.Text = button87.Text;
		}
		
		void Button86Click(object sender, EventArgs e)
		{
			textBox29.Text = button86.Text;
		}
		
		void TextBox16TextChanged(object sender, EventArgs e)
		{
			if(textBox16.Text == Znak1) 
		{
				textBox16.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox16.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox16.Text = "";
			}
		}
		
		void Button49Click(object sender, EventArgs e)
		{
			textBox16.Text = button49.Text;
		}
		
		void Button48Click(object sender, EventArgs e)
		{
			textBox16.Text = button48.Text;
		}
		
		void Button47Click(object sender, EventArgs e)
		{
			textBox16.Text = button47.Text;
		}
		
		void TextBox28TextChanged(object sender, EventArgs e)
		{
			if(textBox28.Text == Znak2) 
		{
				textBox28.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox28.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox28.Text = "";
			}
		}
		
		void Button85Click(object sender, EventArgs e)
		{
			textBox28.Text = button85.Text;
		}
		
		void Button84Click(object sender, EventArgs e)
		{
			textBox28.Text = button84.Text;
		}
		
		void Button83Click(object sender, EventArgs e)
		{
			textBox28.Text = button83.Text;
		}
		
		void TextBox26TextChanged(object sender, EventArgs e)
		{
			if(textBox26.Text == Znak1) 
		{
				textBox26.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox26.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox26.Text = "";
			}
		}
		
		void Button79Click(object sender, EventArgs e)
		{
			textBox26.Text = button79.Text;
		}
		
		void Button78Click(object sender, EventArgs e)
		{
			textBox26.Text = button78.Text;
		}
		
		void Button77Click(object sender, EventArgs e)
		{
			textBox26.Text = button77.Text;
		}
		
		void TextBox25TextChanged(object sender, EventArgs e)
		{
			if(textBox25.Text == Znak3) 
		{
				textBox25.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox25.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox25.Text = "";
			}
		}
		
		void Button76Click(object sender, EventArgs e)
		{
			textBox25.Text = button76.Text;
		}
		
		void Button75Click(object sender, EventArgs e)
		{
		textBox25.Text = button75.Text;	
		}
		
		void Button74Click(object sender, EventArgs e)
		{
			textBox25.Text = button74.Text;
		}
		
		void TextBox19TextChanged(object sender, EventArgs e)
		{
			if(textBox19.Text == Znak3) 
		{
				textBox19.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox19.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox19.Text = "";
			}
		}
		
		void Button58Click(object sender, EventArgs e)
		{
			textBox19.Text = button58.Text;
		}
		
		void Button57Click(object sender, EventArgs e)
		{
			textBox19.Text = button57.Text;
		}
		
		void Button56Click(object sender, EventArgs e)
		{
			textBox19.Text = button56.Text;
		}
		
		void TextBox20TextChanged(object sender, EventArgs e)
		{
			if(textBox20.Text == Znak2) 
		{
				textBox20.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox20.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox20.Text = "";
			}
		}
		
		void Button61Click(object sender, EventArgs e)
		{
			textBox20.Text = button61.Text;
		}
		
		void Button60Click(object sender, EventArgs e)
		{
			textBox20.Text = button60.Text;
		}
		
		void Button59Click(object sender, EventArgs e)
		{
			textBox20.Text = button59.Text;
		}
		
		void TextBox18TextChanged(object sender, EventArgs e)
		{
			if(textBox18.Text == Znak1) 
		{
				textBox18.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox18.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox18.Text = "";
			}
		}
		
		void Button55Click(object sender, EventArgs e)
		{
			textBox18.Text = button55.Text;
		}
		
		void Button54Click(object sender, EventArgs e)
		{
			textBox18.Text = button54.Text;
		}
		
		void Button53Click(object sender, EventArgs e)
		{
			textBox18.Text = button53.Text;
		}
		
		void TextBox11TextChanged(object sender, EventArgs e)
		{
			if(textBox11.Text == Znak3) 
		{
				textBox11.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox11.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox11.Text = "";
			}
		}
		
		void Button34Click(object sender, EventArgs e)
		{
			textBox11.Text = button34.Text;
		}
		
		void Button33Click(object sender, EventArgs e)
		{
			textBox11.Text = button33.Text;
		}
		
		void Button32Click(object sender, EventArgs e)
		{
			textBox11.Text = button32.Text;
		}
		
		void TextBox21TextChanged(object sender, EventArgs e)
		{
			if(textBox21.Text == Znak1) 
		{
				textBox21.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox21.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox21.Text = "";
			}
		}
		
		void Button64Click(object sender, EventArgs e)
		{
			textBox21.Text = button64.Text;
		}
		
		void Button63Click(object sender, EventArgs e)
		{
			textBox21.Text = button63.Text;
		}
		
		void Button62Click(object sender, EventArgs e)
		{
			textBox21.Text = button62.Text;
		}
		
		void TextBox22TextChanged(object sender, EventArgs e)
		{
			if(textBox22.Text == Znak1) 
		{
				textBox22.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox22.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox22.Text = "";
			}
		}
		
		void Button67Click(object sender, EventArgs e)
		{
			textBox22.Text = button67.Text;
		}
		
		void Button66Click(object sender, EventArgs e)
		{
			textBox22.Text = button66.Text;
		}
		
		void Button65Click(object sender, EventArgs e)
		{
			textBox22.Text = button65.Text;
		}
		
		void TextBox23TextChanged(object sender, EventArgs e)
		{
			if(textBox23.Text == Znak2) 
		{
				textBox23.BackColor = Color.YellowGreen;
			}
			else
			{
				textBox23.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox23.Text = "";
			}
		}
		
		void Button70Click(object sender, EventArgs e)
		{
			textBox23.Text = button70.Text;
		}
		
		void Button69Click(object sender, EventArgs e)
		{
			textBox23.Text = button69.Text;
		}
		
		void Button68Click(object sender, EventArgs e)
		{
		textBox23.Text = button68.Text;	
		}
		
		void TextBox24TextChanged(object sender, EventArgs e)
		{
			if(textBox24.Text == Znak3) 
		{
				textBox24.BackColor = Color.YellowGreen;
				
                Hide(); 
			}
			else
			{
				textBox24.BackColor = Color.Tomato;
				MessageBox.Show("НЕПРАВИЛЬНО!!!","Сообщение",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                textBox24.Text = "";
			}
		}
		
		void Button73Click(object sender, EventArgs e)
		{
		textBox24.Text = button73.Text;	
		}
		
		void Button72Click(object sender, EventArgs e)
		{
			textBox24.Text = button72.Text;
		}
		
		void Button71Click(object sender, EventArgs e)
		{
			textBox24.Text = button71.Text;
		}
		
		void Button92Click(object sender, EventArgs e)
		{
		Kakoe_shislo_bolshe.Stop();
		}
		
		void Button93Click(object sender, EventArgs e)
		{
			Kakoe_shislo_bolshe = new SoundPlayer(); 
			Kakoe_shislo_bolshe.SoundLocation = "Kakoe_shislo_bolshe.wav"; 
			Kakoe_shislo_bolshe.Play();
		}
		
		void ВыходToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void НазадToolStripMenuItemClick(object sender, EventArgs e)
		{
			MainForm fr1=new MainForm();
			fr1.Show();
			Hide();
		}
	}
}
