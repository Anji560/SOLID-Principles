using System;

namespace SOLID_Principles_Sample_Project.Interface_Segregation_Principle.Before_ISP
{
    public class Programmer : ILead
    {
        public void AssignTask()
        {
            throw new Exception("Programmer can't Assign Task");
        }

        public void CreateSubTask()
        {
            throw new Exception("Programmer can't Create Sub Task");
        }

        public void WorkOnTask()
        {
            // Code to work on the Task.            
        }
    }
}
