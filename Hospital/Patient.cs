using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class Patient : Person
    {
        private String Job { get; set; }

        public Patient()
        {

        }

        public Patient(String name, String ci, String job)
        {
            SetData(name, ci);
            this.Job = job;
        }

        public void CreatePatient()
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("CI: ");
            string ci = Console.ReadLine();
            Console.WriteLine("Job: ");
            this.Job = Console.ReadLine();
            SetData(name, ci);
        }

        public override void GetData()
        {
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("CI: " + this.Ci);
            Console.WriteLine("Job: " + this.Job);
        }

    }
}
