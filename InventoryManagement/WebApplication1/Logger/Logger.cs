namespace WebApplication1.Logger
{
    public class Logger : ILogger
    {
        private readonly string logFilePath;

        // Constructor that allows you to specify a file path for logging
        public Logger(string logFilePath = null)
        {
            this.logFilePath = logFilePath;
        }

        // Log an informational message
        public void LogInfo(string message)
        {
            string logMessage = $"INFO: {message} - {DateTime.Now}";
            Console.WriteLine(logMessage);
            LogToFile(logMessage);
        }

        // Log an error message
        public void LogError(string message)
        {
            string logMessage = $"ERROR: {message} - {DateTime.Now}";
            Console.WriteLine(logMessage);
            LogToFile(logMessage);
        }

        // Log a warning message
        public void LogWarning(string message)
        {
            string logMessage = $"WARNING: {message} - {DateTime.Now}";
            Console.WriteLine(logMessage);
            LogToFile(logMessage);
        }

        // Optional: Log messages to a file if the file path is provided
        private void LogToFile(string message)
        {
            if (string.IsNullOrEmpty(logFilePath))
                return;

            try
            {
                File.AppendAllText(logFilePath, message + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to write log to file: {ex.Message}");
            }
        }
    }
}
