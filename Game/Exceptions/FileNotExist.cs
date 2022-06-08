using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Exceptions
{
    public class FileNotExist: Exception
    {
        public FileNotExist(string filePath): base(string.Format("Il file {0} non esiste.", filePath)) {}
    }
}
