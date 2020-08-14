using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TextFormatter
{
    public class TxtFormatter : FileFormatter
    {

        private readonly Regex Pattern;
        public TxtFormatter(int Length, string delim) : base(Length,delim) {
            Pattern = new Regex("["+delim+"]");
        }
        public TxtFormatter(int Length) : base(Length) { }

        public override string DeleteSymbols(string line)
        {
            return Pattern.Replace(line, " ");
        }

        public override string DeleteWords(string line)
        {
            var set = new HashSet<char>(Delims.ToString()+' ');
            var sb = new StringBuilder();
            var result= new StringBuilder();
            for (int i=0;i<line.Length;i++) {
                if (set.Contains(line[i])) {
                    if (sb.Length < WordLength) {
                        result.Append(sb);
                        result.Append(line[i]);
                    }
                    sb.Clear();
                }
                else
                {
                    sb.Append(line[i]);
                }
            }
            return result.ToString();
        }
    }
}
