
namespace SOLID_Principles_Sample_Project.Dependency_Inversion_Principle.After_DIP
{
    public class FileLogger : ILogger
    {
        public void LogMessage(string stackTrace)
        {
            // Code to log stack trace into a file.  
        }
    }
}
