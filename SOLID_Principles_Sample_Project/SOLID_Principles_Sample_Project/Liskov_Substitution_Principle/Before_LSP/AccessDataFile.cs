
namespace SOLID_Principles_Sample_Project.Liskov_Substitution_Principle.Before_LSP
{
    public class AccessDataFile
    {
        public string FilePath { get; set; }

        public virtual void ReadFile()
        {
            // Code to read text from the file          
        }

        public virtual void WriteFile()
        {
            // Code to save text into file
        }
    }
}
