using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shared
{
    public static class ObjectExtension
    {
		public static void TryCall<T>(this T o, Action<T> action)
		{
			try {
				o.SafeCall(obj => action(obj));
			}
			catch(Exception) {
				return;
			}
			
		}

		public static void SafeCall<T>(this T o, Action<T> action)
		{
			if(o == null)
				return;

			action(o);
		}

		public static void ForEach<T>(this IEnumerable<T> list, Action<T> action)
		{
			list.SafeCall(l => {
				foreach(var entry in l)
					action(entry);
			});
		}

		public static bool ForEach<T>(this IEnumerable<T> list, Func<T, bool> func)
		{
			if(list == null)
				return false;

			
			bool result = true;
			foreach(var l in list) {
				if(func(l))
					result = false;
			}

			return result;
		}
    }
}
