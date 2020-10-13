using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class Doctor : Person
    {
        private String Specialty { get; set; }

        public Doctor()
        {

        }

        public Doctor(String name, String ci, String speciality)
        {
            SetData(name, ci);
            this.Specialty = speciality;
        }

        public override void GetData()
        {
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("CI: " + this.Ci);
            Console.WriteLine("Specialty: " + this.Specialty);
        }

        public String GetSpeciality()
        {
            return this.Specialty;
        }
    }
}
