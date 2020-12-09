
namespace SOLID_Principles_Sample_Project.Interface_Segregation_Principle.Before_ISP
{
    public class TeamLead : ILead
    {
        public void AssignTask()
        {
            // Code to assign a task.  
        }

        public void CreateSubTask()
        {
            // Code to create a sub task  
        }

        public void WorkOnTask()
        {
            // Code to work on the Task.  
        }
    }
}
