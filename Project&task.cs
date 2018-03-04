using System;
using System.Collections.Generic;

namespace ProManage
{
    public enum ProjectOperation
    {
        Create,
        Edit,
        Finish,
        Delete
    }

    public class Project
    {

        #region Members

        private string name;
        private float pricePerHour;
        private float totalPrice;
        private float time;
        private List<Task> tasks;
        private List<Employee> employees;
        private ProjectOperation operation;

        #endregion

        #region Methods

        public Project(string name, int totalprice, int priceperhour)
        {
            this.name = name;
            this.totalPrice = totalprice;
            this.pricePerHour = priceperhour;
        }

        public void AddWorker(Employee emp)
        {
            this.employees.Add(emp);
        }

        public void RemoveWorker(Employee emp)
        {
            this.employees.Remove(emp);
        }

        public void AddTask(Task task)
        {
            this.tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            this.tasks.Remove(task);
        }

        public void AddTime(float time)
        {
            this.time += time;
        }


        #endregion

        #region Properties

        public float TotalPrice
        {
            get
            {
                return this.totalPrice;
            }
            set
            {
                this.totalPrice = value;
            }
        }

        public float PricePerHour
        {
            get
            {
                return this.pricePerHour;
            }
            set
            {
                this.pricePerHour = value;
            }
        }



        public ProjectOperation Operation
        {
            get
            {
                return operation;
            }
            set
            {
                operation = value;
            }
        }

        public float Time
        {
            get
            {
                return this.time;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        #endregion

    }//end Project class

    public class Task
    {
        //Member
        private string name;
        private bool completed;

        //Method
        public Task(string name)
        {
            this.name = name;
            completed = false;
        }

        //Property
        public bool Completed
        {
            get
            {
                return this.completed;
            }
            set
            {
                this.completed = value;
            }
        }

    }//end Task class


}

