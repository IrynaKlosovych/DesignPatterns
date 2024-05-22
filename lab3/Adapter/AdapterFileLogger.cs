using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Adapter
{
    public enum WriteMode
    {
        write,
        writeline
    };
    public class AdapterFileLogger : Logger
    {
        private FileWriter _adaptee;
        public AdapterFileLogger(FileWriter adaptee)
        {
            _adaptee = adaptee;
        }
        public void NewLog(string message, WriteMode type)
        {
            Log();
            CheckMode(message, type);
            Reset();
        }
        public void NewError(string message, WriteMode type)
        {
            Error();
            CheckMode(message, type);
            Reset();
        }
        public void NewWarn(string message, WriteMode type)
        {
            Warn();
            CheckMode(message, type);
            Reset();
        }
        private void CheckMode(string message, WriteMode type)
        {
            if (type == WriteMode.write)
            {
                _adaptee.Write(message);
            }
            else
            {
                _adaptee.WriteLine(message);
            }
        }
    }
}
