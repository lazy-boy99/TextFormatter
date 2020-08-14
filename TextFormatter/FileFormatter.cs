using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFormatter
{
    public abstract class FileFormatter : IFormatter
    {

        protected char[] Delims { get; set; }
        protected int WordLength { get; set; }

        protected FileFormatter(int Length, string delim)
        {
            WordLength = Length;
            Delims = delim.ToArray();
        }
        protected FileFormatter(int Length)
        {
            WordLength = Length;
        }

        public abstract string DeleteSymbols(string line);

        public abstract string DeleteWords(string line);
    }
}
