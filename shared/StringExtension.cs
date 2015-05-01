using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shared
{
	public static class StringExtension
	{
		public string Safe(this string s)
		{
			return s ?? string.Empty;
		}
	}
}
