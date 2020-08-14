using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFormatter
{
    public interface IFormatter
    {
        string DeleteSymbols(string line);
        string DeleteWords(string line);
    }
}
