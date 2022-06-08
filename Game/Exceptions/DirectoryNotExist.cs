using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Exceptions
{
    public class DirectoryNotExist: Exception
    {
        public DirectoryNotExist(string directoryPath): base(string.Format("La directory {0} non esiste.", directoryPath)) {}
    }
}
