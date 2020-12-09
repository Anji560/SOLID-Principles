
namespace SOLID_Principles_Sample_Project.Liskov_Substitution_Principle.After_LSP
{
    public class FileManager
    {
        public void ManageFile()
        {
            IFileReader fileReader = new AdminDataFileUser();
            fileReader.ReadFile(@"c:\temp\sample.txt");

            IFileWriter fileWriter = new AdminDataFileUser();
            fileWriter.WriteFile(@"c:\temp\sample.txt");

            IFileReader fileReaderR = new RegularDataFileUser();
            fileReaderR.ReadFile(@"c:\temp\sample.txt");
        }
    }
}
