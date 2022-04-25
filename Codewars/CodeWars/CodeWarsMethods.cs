using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class CodeWarsMethods
    {
        public static string PhoneDir(string strng, string num)
        {
            string[] entries = strng.Split("\n");
            string? match = null;
            foreach (string entry in entries)
            {
                if (entry.Contains(num))
                {
                    if (match == null)
                    {
                        match = entry;
                    }
                    else
                    {
                        return $"Error => Too many people: {num}";
                    }
                }
            }
            if (match == null)
            {
                return $"Error => Not found: {num}";
            }
            else
            {
                string name = match.Substring(match.IndexOf("<") + 1, (match.IndexOf(">") - (match.IndexOf("<") + 1)));
                match = match.Remove(match.IndexOf("<"), (match.IndexOf(">") - (match.IndexOf("<") - 1)));
                match = match.Remove(match.IndexOf("+"), num.Length + 1);
                string address = match.Replace("; ", "").Replace("  ", " ").Replace("$ ", "").Replace("/ ", "").Replace("_", " ").Trim();
                return $"Phone => {num}, Name => {name}, Address => {address}";
            }
        }

        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length != 10) { return false; }
            int NSTrack = 0;
            int EWTrack = 0;
            foreach (var block in walk)
            {
                switch (block)
                {
                    case "n":
                        NSTrack++;
                        break;
                    case "s":
                        NSTrack--;
                        break;
                    case "e":
                        EWTrack++;
                        break;
                    case "w":
                        EWTrack--;
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
            if (NSTrack == 0 && EWTrack == 0)
            {
                return true;
            }
            return false;
        }

        public static int[] FoldArray(int[] array, int runs)
        {
            Console.WriteLine(string.Join(",", array));
            for (int i = 0; i < runs; i++)
            {
                int start = 0;
                int end = array.Length - 1;
                while (start < end)
                {
                    array[start] = array[start] + array[end];
                    start++;
                    end--;
                }
                if (start == end)
                {
                    int[] vs = array[..(start + 1)];
                    array = vs;
                }
                else
                {
                    int[] vs = array[..start];
                    array = vs;
                }
            }
            Console.WriteLine(string.Join(",", array));
            return array;
        }
    }
}
