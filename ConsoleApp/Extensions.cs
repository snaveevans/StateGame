using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp
{
    public static class Extensions
    {
        public static List<T> RemoveRange<T>(this List<T> list, List<T> remove)
        {
            return list.Where(i => !remove.Contains(i)).ToList();
        }

        public static List<T> Clone<T>(this List<T> list)
        {
            var result = new List<T>();
            
            foreach (var item in list)
            {
                result.Add(item);
            }

            return result;
        }
    }
}