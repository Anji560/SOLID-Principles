using System;

namespace SOLID_Principles_Sample_Project.Dependency_Inversion_Principle.After_DIP
{
    public class ExceptionLogger
    {
        private ILogger _logger;

        public ExceptionLogger(ILogger logger)
        {
            this._logger = logger;
        }

        public void LogException(Exception exception)
        {
            string strMessage = GetUserReadableMessage(exception);
            this._logger.LogMessage(strMessage);
        }

        private string GetUserReadableMessage(Exception exception)
        {
            string strMessage = string.Empty;

            // Code to convert Exception's stack trace and message to user readable format.  

           return strMessage;
        }
    }
}
