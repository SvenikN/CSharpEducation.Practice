using Logger;
using System;
using System.IO;

public class FileLogger : ILogger, IDisposable
{
    private readonly string _filePath;
    private StreamWriter _writer;

    public FileLogger(string filePath)
    {
        _filePath = filePath;
        _writer = new StreamWriter(_filePath, append: true)
        {
            AutoFlush = true
        };
    }

    public void Trace(string message) => Log(message, LogLevel.Trace);
    public void Info(string message) => Log(message, LogLevel.Info);
    public void Debug(string message) => Log(message, LogLevel.Debug);
    public void Warning(string message) => Log(message, LogLevel.Warning);
    public void Error(string message) => Log(message, LogLevel.Error);
    public void Fatal(string message) => Log(message, LogLevel.Fatal);

    public void Log(string message, LogLevel level)
    {
        string className = GetCallingClassName();
        string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | {className} | {level} | {message}";

        _writer.WriteLine(logMessage);
    }

    private string GetCallingClassName()
    {
        var stackTrace = new System.Diagnostics.StackTrace();
        var frame = stackTrace.GetFrame(2);
        var method = frame?.GetMethod();
        return method?.DeclaringType?.Name ?? "UnknownClass";
    }

    public void Dispose()
    {
        _writer?.Dispose();
    }
}
