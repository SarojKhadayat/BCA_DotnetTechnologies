using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBCA.Event
{
    public class ProcessCompletedEventArgs : EventArgs
    {
        public string EventMessage { get; set; }
    }
}
