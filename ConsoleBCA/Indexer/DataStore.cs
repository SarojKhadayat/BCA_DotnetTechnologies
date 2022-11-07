using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBCA.Indexer
{
    public class DataStore
    {
        private string[] StringArray = new string[10];
        public string this[int i]
        {
            get
            {
                if (i < 0 || i > StringArray.Length)
                    throw new IndexOutOfRangeException("Index is out of range");
                return StringArray[i];
            }
            set
            {
                if (i < 0 || i > StringArray.Length)
                    throw new IndexOutOfRangeException("Index is out of range");
                StringArray[i] = value;
            }
        }
    }
}
