using System;
using System.IO;

namespace SOLID_Principles_Sample_Project.Dependency_Inversion_Principle.After_DIP
{
    public class DataExporter
    {
        public void ExportDataFromFile()
        {
            ExceptionLogger _exceptionLogger;
            try
            {
                // Code to export data from files to database.  
            }
            catch (IOException ex)
            {
                _exceptionLogger = new ExceptionLogger(new DbLogger());
                _exceptionLogger.LogException(ex);
            }
            catch (Exception ex)
            {
                _exceptionLogger = new ExceptionLogger(new FileLogger());
                _exceptionLogger.LogException(ex);
            }
        }
    }
}
