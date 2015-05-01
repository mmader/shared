using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using shared;

namespace Test
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			string foobar = "1234";

			foobar.SafeCall(f => {
				Debug.WriteLine(f.Length.ToString());
			});

			foobar.TryCall(f => {
				f = null;
				string.Format("{0}", f, f);
			});

			string[] fooArray = { "1", "2", "3" };
			fooArray.ForEach(f => Debug.WriteLine(f));


			Debug.Print("***********************");
			fooArray.ForEach(f => Debug.Print(f.IsNumeric().ToString()));

			fooArray = new []  { "1", "b", "3" };
			fooArray.ForEach(f => Debug.Print(f.IsNumeric().ToString()));
			Debug.Print("***********************");

		}
	}
}
