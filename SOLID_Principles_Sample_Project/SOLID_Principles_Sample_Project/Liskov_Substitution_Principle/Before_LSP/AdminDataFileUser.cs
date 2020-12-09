using System.IO;

namespace SOLID_Principles_Sample_Project.Liskov_Substitution_Principle.Before_LSP
{
    public class AdminDataFileUser : AccessDataFile
    {
        public override void ReadFile()
        {
            // Code to read text from the file    
        }

        public override void WriteFile()
        {
            // Code to save text into file
        }
    }
}
