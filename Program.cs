using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarkov_Time_Sync
{
	static class Program
	{

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			if (Environment.OSVersion.Version.Major >= 6)
				SetProcessDPIAware();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());

		}

		[DllImport("user32.dll")]
		private static extern bool SetProcessDPIAware();

		[DllImport("kernel32.dll")]
		public static extern bool SetSystemTime(ref SystemTime time);

		[StructLayout(LayoutKind.Sequential)]
		public struct SystemTime
		{
			public ushort Year;
			public ushort Month;
			public ushort DayOfWeek;
			public ushort Day;
			public ushort Hour;
			public ushort Minute;
			public ushort Second;
			public ushort Milliseconds;

			public SystemTime(DateTime dt)
			{
				Year = (ushort)dt.Year;
				Month = (ushort)dt.Month;
				DayOfWeek = (ushort)dt.DayOfWeek;
				Day = (ushort)dt.Day;
				Hour = (ushort)dt.Hour;
				Minute = (ushort)dt.Minute;
				Second = (ushort)dt.Second;
				Milliseconds = (ushort)dt.Millisecond;
			}
		}

	}
}
