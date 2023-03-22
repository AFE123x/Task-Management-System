using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Management_Project
{
    class TaskManager
    {
        private Node priority1;
        private Node priority2;
        private Node priority3;
        private Node priority4;
        private int p1size;
        private int p2size;
        private int p3size;
        private int p4size;
        private Node tailp1;
        private Node tailp2;
        private Node tailp3;
        private Node tailp4;
        private class Node{
            public String taskname;
            public String deadline;
            public Node next;
            public int size = 0;
            public Node(String taskname, String deadline)
            {
                this.taskname = taskname;
                this.deadline = deadline;
            }

        }
        public TaskManager()
        {

        }
        public static int CompareDates(string date1, string date2)
        {
            // Parse the input strings as DateTime objects with the specified format
            DateTime parsedDate1 = DateTime.ParseExact(date1, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            DateTime parsedDate2 = DateTime.ParseExact(date2, "MM/dd/yyyy", CultureInfo.InvariantCulture);

            // Compare the parsed DateTime objects and return the result as an integer
            return parsedDate1.CompareTo(parsedDate2);
        }
        public void printp1()
        {
            Node temp = priority1;
            while(temp != null)
            {
                Console.WriteLine(temp.taskname + " by " + temp.deadline);
                temp = temp.next;
                
            }
        }
        public void printp2()
        {
            Node temp = priority2;
            while (temp != null)
            {
                Console.WriteLine(temp.taskname + " by " + temp.deadline);
                temp = temp.next;

            }
        }
        public void printp3()
        {
            Node temp = priority3;
            while (temp != null)
            {
                Console.WriteLine(temp.taskname + " by " + temp.deadline);
                temp = temp.next;

            }
        }
        public void printp4()
        {
            Node temp = priority4;
            while (temp != null)
            {
                Console.WriteLine(temp.taskname + " by " + temp.deadline);
                temp = temp.next;

            }
        }
        public void addtask(String task, String deadline, int priority)
        {
            if(priority == 1)
            {
                
                if(priority1 == null)
                {
                    priority1 = new Node(task, deadline);
                    p1size++;
                }
                else if(p1size == 1)
                {
                    int cc = CompareDates(deadline, priority1.deadline) ;
                    if(cc > 0)
                    {
                        priority1.next = new Node(task,deadline);
                        tailp1 = priority1.next;
                        
                    }
                    else if(cc < 0)
                    {
                        Node temp = priority1;
                        priority1 = new Node(task, deadline);
                        priority1.next = temp;
                        tailp1 = priority1.next;

                    }
                    else
                    {
                        priority1.next = new Node(task, deadline);
                        tailp1 = priority1.next;
                    }
                    p1size++;
                }
                else
                {
                    addnodep1(new Node(task, deadline));
                }

            }
            else if (priority == 2)
            {
                if (priority2 == null)
                {
                    priority2 = new Node(task, deadline);
                    p2size++;
                }
                else if (p2size == 1)
                {
                    int cc = CompareDates(deadline, priority2.deadline);
                    if (cc > 0)
                    {
                        priority2.next = new Node(task, deadline);
                        tailp2 = priority2.next;

                    }
                    else if (cc < 0)
                    {
                        Node temp = priority2;
                        priority2 = new Node(task, deadline);
                        priority2.next = temp;
                        tailp2 = priority2.next;

                    }
                    else
                    {
                        priority2.next = new Node(task, deadline);
                        tailp2 = priority2.next;
                    }
                    p2size++;
                }
                else
                {
                    addnodep2(new Node(task, deadline));
                }

            }
            else if(priority == 3)
            {
                if (priority3 == null)
                {
                    priority3 = new Node(task, deadline);
                    p3size++;
                }
                else if (p3size == 1)
                {
                    int cc = CompareDates(deadline, priority3.deadline);
                    if (cc > 0)
                    {
                        priority3.next = new Node(task, deadline);
                        tailp3 = priority3.next;

                    }
                    else if (cc < 0)
                    {
                        Node temp = priority3;
                        priority3 = new Node(task, deadline);
                        priority3.next = temp;
                        tailp3 = priority3.next;

                    }
                    else
                    {
                        priority3.next = new Node(task, deadline);
                        tailp3 = priority3.next;
                    }
                    p3size++;
                }
                else
                {
                    addnodep3(new Node(task, deadline));
                }
            }
            else if(priority == 4)
            {
                if (priority4 == null)
                {
                    priority4 = new Node(task, deadline);
                    p4size++;
                }
                else if (p4size == 1)
                {
                    int cc = CompareDates(deadline, priority4.deadline);
                    if (cc > 0)
                    {
                        priority4.next = new Node(task, deadline);
                        tailp4 = priority4.next;

                    }
                    else if (cc < 0)
                    {
                        Node temp = priority4;
                        priority4 = new Node(task, deadline);
                        priority4.next = temp;
                        tailp4 = priority4.next;

                    }
                    else
                    {
                        priority4.next = new Node(task, deadline);
                        tailp4 = priority4.next;
                    }
                    p4size++;
                }
                else
                {
                    addnodep4(new Node(task, deadline));
                }
            }
            else
            {
                throw new Exception("Priority Must be between 1 - 4");
            }
        }

        private void addnodep1(Node n)
        {
            int compare = CompareDates(n.deadline, priority1.deadline);
                
            if (compare < 0)
            {
                Node oldfirst = priority1;
                priority1 = n;
                priority1.next = oldfirst;
            }
            compare = CompareDates(n.deadline, tailp1.deadline);
            if(compare > 0)
            {
                tailp1.next = n;
                tailp1 = tailp1.next;
            }
            else
            {
                Node temp = priority1;

                while(temp.next != null && CompareDates(n.deadline,temp.next.deadline) > 0)
                {
                    temp = temp.next;
                }
                Node t = temp.next;
                temp.next = n;
                temp.next.next = t;
            }
        }
        private void addnodep2(Node n)
        {
            int compare = CompareDates(n.deadline, priority2.deadline);

            if (compare < 0)
            {
                Node oldfirst = priority2;
                priority2 = n;
                priority2.next = oldfirst;
            }
            compare = CompareDates(n.deadline, tailp2.deadline);
            if (compare > 0)
            {
                tailp2.next = n;
                tailp2 = tailp2.next;
            }
            else
            {
                Node temp = priority2;

                while (temp.next != null && CompareDates(n.deadline, temp.next.deadline) > 0)
                {
                    temp = temp.next;
                }
                Node t = temp.next;
                temp.next = n;
                temp.next.next = t;
            }
        }
        private void addnodep3(Node n)
        {
            int compare = CompareDates(n.deadline, priority3.deadline);

            if (compare < 0)
            {
                Node oldfirst = priority3;
                priority3 = n;
                priority3.next = oldfirst;
            }
            compare = CompareDates(n.deadline, tailp3.deadline);
            if (compare > 0)
            {
                tailp3.next = n;
                tailp3 = tailp3.next;
            }
            else
            {
                Node temp = priority3;

                while (temp.next != null && CompareDates(n.deadline, temp.next.deadline) > 0)
                {
                    temp = temp.next;
                }
                Node t = temp.next;
                temp.next = n;
                temp.next.next = t;
            }
        }
        private void addnodep4(Node n)
        {
            int compare = CompareDates(n.deadline, priority4.deadline);

            if (compare < 0)
            {
                Node oldfirst = priority4;
                priority4 = n;
                priority4.next = oldfirst;
            }
            compare = CompareDates(n.deadline, tailp4.deadline);
            if (compare > 0)
            {
                tailp4.next = n;
                tailp4 = tailp4.next;
            }
            else
            {
                Node temp = priority4;

                while (temp.next != null && CompareDates(n.deadline, temp.next.deadline) > 0)
                {
                    temp = temp.next;
                }
                Node t = temp.next;
                temp.next = n;
                temp.next.next = t;
            }
        }



    }
}
