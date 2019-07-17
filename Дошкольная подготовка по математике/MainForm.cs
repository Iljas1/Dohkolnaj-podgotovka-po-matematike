/*
 * Сделано в SharpDevelop.
 * Пользователь: Admin
 * Дата: 01.04.2019
 * Время: 11:56
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Дошкольная_подготовка_по_математике
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
	//private SoundPlayer kak_tebj_zovut; 
	//private SoundPlayer Napishi_mne_svojo_imj; 
	private SoundPlayer Viberi_zadanie; 
	
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
//			kak_tebj_zovut = new SoundPlayer(); 
//			kak_tebj_zovut.SoundLocation = "kak_tebj_zovut.wav.wav"; 
//			kak_tebj_zovut.Play();
			
			
			
	    Viberi_zadanie = new SoundPlayer(); 
		Viberi_zadanie.SoundLocation = "Viberi_zadanie.wav"; 
		
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
        Form2 Fr0 = new Form2();  
        Fr0.ShowDialog(); 
       
		}
		
		void Button2Click(object sender, EventArgs e)
		{
	Forrm3 Fr3 = new Forrm3(); 
       Fr3.ShowDialog(); 
       
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			 Application.Exit();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
	   Form5 Fr3 = new Form5(); 
       Fr3.ShowDialog(); 
       
		}
		
		void Button6Click(object sender, EventArgs e)
		{
	   Form6 Fr3 = new Form6(); 
       Fr3.ShowDialog(); 
      
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			Viberi_zadanie.Play();				
		}
		
		void ОПрограммеToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Программа создана на технологии С#.NEТ.\n" + "Разработчик: Салихов Ильяс Расихович.","О программе");
		}
		
		void ВыходToolStripMenuItemClick(object sender, EventArgs e)
		{
		 Application.Exit();	
		}

        private void SaveResult(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
