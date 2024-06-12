using Assignment6abc;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

public class TaskManager
{
    private List<Taskk> taskList;

    public TaskManager()
    {
        taskList = new List<Taskk>();
    }

    // Method to add a new task
    public void AddTask(Taskk task)
    {
        taskList.Add(task);
    }


    // Method to change a task
    public void ChangeTask(int index, Taskk newTask)
    {
        if (index >= 0 && index < taskList.Count)
        {
            taskList[index] = newTask;
        }
    }
    public void DeleteTaskAtIndex(int index)
    {
        if (index >= 0 && index < taskList.Count)
        {
            taskList.RemoveAt(index);
        }
    }
 

    // Method to retrieve a task at a specified index
    public Taskk GetTaskAtIndex(int index)
    {
        if (index >= 0 && index < taskList.Count)
        {
            return taskList[index];
        }
        else
        {
            // Return null or throw an exception based on your requirement
            return null;
        }
    }

      
    //Send the taskList object declared in above to which  
    //data from the fileName is saved. As taskList is an object  
    //it will have the changes made in the FileManager when  
    //the method ReadTaskLisstFrFile returns.  
    public bool ReadDataFromFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            //objects are passed by ref so taskList will be updated.  
            return fileManager.ReadTaskLisstFrFile(taskList, fileName);
        }
        //FileManager is a class that handles saving and reading data  
        //to and from a text file. Send the taskList from which  
        //data is read and saved to the file fileName  
        public bool WriteDataToFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            return fileManager.SaveTaskListToFile(taskList, fileName);
        }  
    
    // Method to prepare and return a list of strings representing the tasks currently in the task list
    public string[] GetTaskStrings()
    {
        List<string> taskStrings = new List<string>();
        foreach (Taskk task in taskList)
        {
            taskStrings.Add(task.ToString());
        }
        return taskStrings.ToArray();
    }
}
