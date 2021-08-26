using System.Collections.Generic;
using Tasks.HelpClasses;

namespace Tasks
{
    public class Task4
    {
        /*
         * Desenvolva um método que retorne todos os estudantes do Repositório que nasceram em 2020      
         * Dica: A classe Repository possui as informções dos Students
         */
        public static List<Student> GetStudentsByBirth() {
            Repository repository = new Repository();
            List<Student> studentsList = new List<Student>();

            for (int i = 0; i < repository.Students.Count; i++)
            {
                if (repository.Students[i].Birth.DayOfYear == 2020)
                {
                    studentsList.Add(repository.Students[i]);
                }
            }

            return studentsList;
                
        }
    }
}
