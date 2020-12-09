
namespace SOLID_Principles_Sample_Project.Interface_Segregation_Principle.After_ISP
{
    public class Manager : ILead
    {
        public void AssignTask()
        {
            // Code to assign a Task  
        }

        public void CreateSubTask()
        {
            // Code to create a sub taks from a task.  
        }
    }
}
