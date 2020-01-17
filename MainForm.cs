using System;
using System.Diagnostics;
using System.Windows.Forms;
using static Tarkov_Time_Sync.Program;

namespace Tarkov_Time_Sync
{
	public partial class MainForm : Form
	{

		private int timeOffset = 0;

		public MainForm()
		{
			InitializeComponent();
		}

		private void BtnReset_Click(object sender, EventArgs e)
		{
		
			ModifyTime(-timeOffset);
			timeOffset = 0;

			lblDisplay.Text = timeOffset.ToString() + " ms";
		}

		private void BtnPlusMs_Click(object sender, EventArgs e)
		{
			ModifyTime(50);
			timeOffset += 50;
			lblDisplay.Text = timeOffset.ToString() + " ms";
		}

		private void BtnMinusMs_Click(object sender, EventArgs e)
		{
			ModifyTime(-50);
			timeOffset -= 50;
			lblDisplay.Text = timeOffset.ToString() + " ms";
		}

		private void BtnPlusSec_Click(object sender, EventArgs e)
		{
			ModifyTime(1000);
			timeOffset += 1000;
			lblDisplay.Text = timeOffset.ToString() + " ms";
		}

		private void BtnMinusSec_Click(object sender, EventArgs e)
		{
			ModifyTime(-1000);
			timeOffset -= 1000;
			lblDisplay.Text = timeOffset.ToString() + " ms";
		}

	

		private void ModifyTime(int msOffset)
		{
			DateTime currentTime = DateTime.UtcNow;
			currentTime = currentTime.AddMilliseconds(msOffset);

			SystemTime time = new SystemTime(currentTime);
			SetSystemTime(ref time);
		}
	}
}
