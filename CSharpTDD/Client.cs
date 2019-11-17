using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpTDD
{
    public class Client
    {
        //private readonly UpdateableSpin spin;
        //private readonly Processor processor;

        public Client()
        {

        }

        public void Do()
        {

        }
    }

    public class UpdateableSpin
    {
        private readonly object lockObj = new object();
        private bool shouldWait = true;

        public bool Wait(TimeSpan timeout)
        {
            Thread.Sleep(timeout);
            if (!shouldWait)
                return true;
            return false;
        }

        public void Set()
        {
            lock (lockObj)
            {
                shouldWait = false;
            }
        }
    }
}
