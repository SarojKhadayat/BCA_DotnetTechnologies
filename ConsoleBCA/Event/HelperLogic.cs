using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBCA.Event
{
    public class HelperLogic
    {
        public event EventHandler<HelperMessageEventArgs> OnEventComplete;

        public void Help(int id, string msg)
        {
            Console.WriteLine("Helper process started");
            // codes...
            var helperMsg = new HelperMessageEventArgs { Id = id, Message = msg };
            OnEventComplete.Invoke(this, helperMsg);
        }


    }
}
