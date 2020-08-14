using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFormatter
{
    public abstract class FileHandler : IDisposable
    {
        protected StreamReader Input;
        protected StreamWriter Output;
        protected FileHandler(string In, string Out) {
            Input = new StreamReader(In);
            Output = new StreamWriter(Out);
        }

        public void Dispose()
        {
            Input.Close();
            Output.Close();
            Input.Dispose();
            Output.Dispose();
        }

        public void Execute(IFormatter formatter,bool DelSymbolsEnabled)
        {
            string line;
            Func<string, string> formatting;
            if (DelSymbolsEnabled)
            {
                formatting = formatter.DeleteSymbols;
                formatting += formatter.DeleteWords;

            }
            else
                formatting = formatter.DeleteWords;
            while ((line = Read()) != null) {
                Write(formatting(line));
            }
        }

        protected abstract string Read();
        protected abstract void Write(string str);

    }
}
