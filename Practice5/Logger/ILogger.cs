﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public enum LogLevel
    {
        Trace,
        Info,
        Debug,
        Warning,
        Error,
        Fatal
    }
    public interface ILogger
    {
        public void Trace(string message);
        public void Info(string message);
        public void Debug(string message);
        public void Warning(string message);
        public void Error(string message);
        public void Fatal(string message);
        public void Log(string message, LogLevel level);
    }
}
