
namespace SOLID_Principles_Sample_Project.Interface_Segregation_Principle.After_ISP
{
    public class TeamLead : IProgrammer, ILead
    {
        public void AssignTask()
        {
            // Code to assign a Task  
        }

        public void CreateSubTask()
        {
            // Code to create a sub task from a task.  
        }

        public void WorkOnTask()
        {
            // Code to work on the Task.  
        }
    }
}
