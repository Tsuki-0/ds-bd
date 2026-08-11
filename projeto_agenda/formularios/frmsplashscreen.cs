using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

private void frmspashscreen_Load(object sender, EventArgs e)
{
	this.Opacity = 1;
	player = new SoundPlayer (@"")
	player.Play();

	timer = new Timer();
	timer.Interval = 100;
	timer.tick += Timer_Tick
	timer.Start();
}

private void Timer_Tick(object sender, EventArgs e)
{
	this.Opacity -= 0.01;
	if (this.Opacity == 0)
	{
		timer.Stop();
		this.Close();
		this.hide()
		Login login = new Login();
		login.ShowDialog();
	}
}
public class 
{
	public splashscreen()
	{
		 player
	}
}
