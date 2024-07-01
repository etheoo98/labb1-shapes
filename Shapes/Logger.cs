namespace Shapes;

/// <summary>
/// Represents a logger class that uses the Singleton design pattern to only provide one instance that
/// logs output to the console.
/// </summary>
public class Logger
{
    public static Logger Instance
    {
        get
        {
            if (_instance != null) return _instance;

            lock (LockObject)
            {
                if (_instance == null) _instance = new Logger();
            }

            return _instance;
        }
    }

    private static volatile Logger? _instance;
    private static readonly object LockObject = new();

    private Logger()
    {
    }

    public void Log<T>(T output)
    {
        Console.WriteLine(output);
    }
}