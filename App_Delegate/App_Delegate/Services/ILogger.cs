namespace App_Delegate.Services;

public interface ILogger
{
    void SetLog(string message);
}

// Default Log System
public class SetLogger : ILogger { public void SetLog(string message) { Console.WriteLine($"SetLogger -> {message}"); } }


public class SSMLogger : ILogger { public void SetLog(string message) { Console.WriteLine($"SSMLogger -> {message}"); } }
public class XMLLogger : ILogger { public void SetLog(string message) { Console.WriteLine($"XMLLogger -> {message}"); } }
public class SQLLogger : ILogger { public void SetLog(string message) { Console.WriteLine($"SQLLogger -> {message}"); } }
public class MailLogger : ILogger { public void SetLog(string message) { Console.WriteLine($"MailLogger -> {message}"); } }
public class PushNotigicationLogger : ILogger { public void SetLog(string message) { Console.WriteLine($"PushNotigicationLogger -> {message}"); } }