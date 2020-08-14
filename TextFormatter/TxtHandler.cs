using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFormatter
{
    public class TxtHandler : FileHandler
    {
        public TxtHandler(string In, string Out) : base(In, Out)
        {

        }
        protected override string Read()
        {
            return Input.ReadLine();
        }

        protected override void Write(string str)
        {
            Output.WriteLine(str);
        }
    }
}
