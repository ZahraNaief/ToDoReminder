using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6abc
{

    //Don't forget to include using System.IO; in above  
    class FileManager
    {
        //Write this token as the first line in the textfile as a stample  
        //to mark that the file is saved by this application  
        //  
        private const string fileVersionToken = "ToDoRe_21";
        //The file version can help you to make old files compatible  
        //The fileVersion does not have to be the same as the app's version nr.  
        private const double fileVersionNr = 1.0;
        public bool SaveTaskListToFile(List<Taskk> taskList, string fileName)
        {
            bool ok = true;
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(fileName);
                writer.WriteLine(fileVersionToken);
                writer.WriteLine(fileVersionNr);
                writer.WriteLine(taskList.Count);
                for (int i = 0; i < taskList.Count; i++)
                {
                    writer.WriteLine(taskList[i].Description);
                    writer.WriteLine(taskList[i].Priority.ToString());
                    writer.WriteLine(taskList[i].DueDateTime.Year);
                    writer.WriteLine(taskList[i].DueDateTime.Month);
                    writer.WriteLine(taskList[i].DueDateTime.Day);
                    writer.WriteLine(taskList[i].DueDateTime.Hour);
                    writer.WriteLine(taskList[i].DueDateTime.Minute);
                    writer.WriteLine(taskList[i].DueDateTime.Second);
                }
            }
            catch
            {
                //if any error occurs in above try-block, the execution will  
                //jump to this block (avoiding program crash)  
                ok = false;
            }
            finally
            {
                //This block is always executed no matter if an error occurs  
                //or not  
                if (writer != null)
                    writer.Close();
            }
            return ok;
        }

        public bool ReadTaskLisstFrFile(List<Taskk> taskList, string fileName)
        {
            bool ok = true;
            StreamReader reader = null;
            try
            {
                //Clear the contents of taskList  
                if (taskList != null)
                    taskList.Clear();
                else
                    taskList = new List<Taskk>();
                reader = new StreamReader(fileName);
                //Ensure that it is the correct file  
                string versionTest = reader.ReadLine();
                //Ensure that it has the correct version nr.  
                double version = double.Parse(reader.ReadLine());


                if ((versionTest == fileVersionToken) && (version == fileVersionNr))//correct file  
                {
                    //read num of items (tasks) to read  
                    int count = int.Parse(reader.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        Taskk task = new Taskk();
                        task.Description = reader.ReadLine();
                        task.Priority = (Priority)Enum.Parse(typeof(Priority), reader.ReadLine());
                        //DateTime.Year,Month, etc. are readonly!  
                        int year =0, month =0, day = 0 ;
                        int hour = 0, minute = 0, second = 0;
                        year = int.Parse(reader.ReadLine());
                        month = int.Parse(reader.ReadLine());
                        day = int.Parse(reader.ReadLine());
                        hour = int.Parse(reader.ReadLine());
                        minute = int.Parse(reader.ReadLine());
                        second = int.Parse(reader.ReadLine());
                        task.DueDateTime = new DateTime(year, month, day, hour, minute, second);
                        taskList.Add(task);
                    }
                }
                else
                    ok = false;
            }
            catch
            {
                ok = false;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            return ok;

        } 
    }
}
