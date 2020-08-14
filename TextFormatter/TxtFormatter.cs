using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextFormatter
{
    public class TxtFormatter : FileFormatter
    {


        public TxtFormatter(int Length, string delim) : base(Length, delim) { }
        public TxtFormatter(int Length) : base(Length) { }

        public override string DeleteSymbols(string line)
        {
            return line.Trim(Delims);
        }

        public override string DeleteWords(string line)
        {
            var words =line.Split(' ');
            var sb = new StringBuilder();
            foreach (var word in words) {
                if (word.Length < WordLength) { 
                    sb.Append(word);
                    sb.Append(" ");
                }
            }
            if(words.Length>0)
                sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
    }
}
