using Logger;
using System;

public class ConsoleLogger : ILogger
{
    public void Trace(string message) => Log(message, LogLevel.Trace);
    public void Info(string message) => Log(message, LogLevel.Info);
    public void Debug(string message) => Log(message, LogLevel.Debug);
    public void Warning(string message) => Log(message, LogLevel.Warning);
    public void Error(string message) => Log(message, LogLevel.Error);
    public void Fatal(string message) => Log(message, LogLevel.Fatal);

    public void Log(string message, LogLevel level)
    {
        // Получаем имя класса, который вызвал логгер
        string className = GetCallingClassName();

        string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | {className} | {level} | {message}";
        Console.WriteLine(logMessage);
    }

    private string GetCallingClassName()
    {
        var stackTrace = new System.Diagnostics.StackTrace();
        var frame = stackTrace.GetFrame(2); // 0 - GetCallingClassName, 1 - Log, 2 - вызывающий метод
        var method = frame?.GetMethod();
        return method?.DeclaringType?.Name ?? "UnknownClass";
    }
}
