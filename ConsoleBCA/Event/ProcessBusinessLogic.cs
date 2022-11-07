using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBCA.Event
{
   // public delegate void Notify();
    public class ProcessBusinessLogic
    {
        public event EventHandler<ProcessCompletedEventArgs> ProcessCompleted;

        public void StartProcess(String message) {
            Console.Write("Processing Started......");
            // Other code

            ProcessingCompleted(message);
        }

        private void ProcessingCompleted(string message) {
            var args = new ProcessCompletedEventArgs { EventMessage = message };
            ProcessCompleted?.Invoke(this, args);
        }
    }
}
