using Microsoft.Data.SqlClient;
using System.Configuration;

namespace WinFormsApp1
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
            ApplicationConfiguration.Initialize();
			Application.Run(new Login());
		}
	}
}