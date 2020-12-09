
namespace SOLID_Principles_Sample_Project.Liskov_Substitution_Principle.Before_LSP
{
    public class FileManager
    {
        public void ManageFile()
        {
            AccessDataFile accessDataFile = new AdminDataFileUser();
            accessDataFile.FilePath = @"c:\temp\sample.txt";
            accessDataFile.ReadFile();
            accessDataFile.WriteFile();

            AccessDataFile accessDataFileR = new RegularDataFileUser();
            accessDataFileR.FilePath = @"c:\temp\sample.txt";
            accessDataFileR.ReadFile();
            accessDataFileR.WriteFile();  // Throws exception 
        }
    }
}
