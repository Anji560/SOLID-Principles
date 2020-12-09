
namespace SOLID_Principles_Sample_Project.Dependency_Inversion_Principle.After_DIP
{
    public class DbLogger : ILogger
    {
        public void LogMessage(string message)
        {
            // Code to write message in database.  
        }
    }
}
