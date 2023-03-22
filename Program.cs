using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Management_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager t = new TaskManager();
            t.addtask("important task 1", "03/28/2023", 1);
            t.addtask("important task 2", "03/23/2023", 1);
            t.addtask("important task 3", "04/02/2023", 1);
            t.addtask("super important task from a while ago", "01/02/1950", 1);
            t.addtask("talk about how great bogosort is", "01/23/1992", 4);
            t.addtask("Use strings in C", "01/22/1992", 4);
            t.addtask("implement integer in while loop in C", "01/22/1990", 4);

            t.printp1();
            Console.WriteLine("priority 4");
            t.printp4();
            while (true) ;

        }
    }
}
