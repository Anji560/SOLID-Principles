
namespace SOLID_Principles_Sample_Project.Liskov_Substitution_Principle.After_LSP
{
    public class AdminDataFileUser : IFileReader, IFileWriter
    {
        public void ReadFile(string filePath)
        {
            // Code to read text from the file
        }

        public void WriteFile(string filePath)
        {
            // Code to save text into file
        }
    }
}
