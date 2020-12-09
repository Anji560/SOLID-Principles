using System;
using System.IO;

namespace SOLID_Principles_Sample_Project.Dependency_Inversion_Principle.Before_DIP
{
    public class DataExporter
    {
        public void ExportDataFromFile()
        {
            try
            {
                // Code to export data from files to database.  
            }
            catch (IOException ex)
            {
                new ExceptionLogger().LogIntoDataBase(ex);
            }
            catch (Exception ex)
            {
                new ExceptionLogger().LogIntoFile(ex);
            }
        }
    }
}
