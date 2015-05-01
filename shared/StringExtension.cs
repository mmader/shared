using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shared
{
	public static class StringExtension
	{
		public static string Safe(this string s)
		{
			return s ?? string.Empty;
		}

		public static bool IsNumeric(this string s)
		{
			var chars = (s != null) ? s.ToCharArray() : null;
			return (chars != null) && chars.ForEach(c => char.IsNumber(c));
		}
	}
}
