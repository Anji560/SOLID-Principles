using System;

namespace SOLID_Principles_Sample_Project.Dependency_Inversion_Principle.Before_DIP
{
    public class ExceptionLogger
    {
        public void LogIntoFile(Exception exception)
        {
            FileLogger objFileLogger = new FileLogger();
            objFileLogger.LogMessage(GetUserReadableMessage(exception));
        }

        public void LogIntoDataBase(Exception exception)
        {
            DbLogger objDbLogger = new DbLogger();
            objDbLogger.LogMessage(GetUserReadableMessage(exception));
        }

        private string GetUserReadableMessage(Exception exception)
        {
            string strMessage = string.Empty;

            // Code to convert Exception's stack trace and message to user readable format.
            
           return strMessage;
        }
    }
}
