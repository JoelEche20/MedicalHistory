using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class MedicalConsultation: IMedialAttention
    {
        private Doctor Doctor { get; set; }
        private String Date { get; set; }
        private String Description { get; set; }

        public MedicalConsultation()
        {

        }

        public MedicalConsultation(Doctor doctor, String date, String description)
        {
            this.Doctor = doctor;
            this.Date = date;
            this.Description = description;
        }

        public void CreateMedicalConsultation()
        {
            Console.WriteLine("Date: ");
            this.Date = Console.ReadLine();
            Console.WriteLine("Description: ");
            this.Description = Console.ReadLine();
            Console.WriteLine("-----Doctor data-----");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("CI: ");
            string ci = Console.ReadLine();
            Console.WriteLine("Specialty: ");
            string specialty = Console.ReadLine();
            Doctor doctor = new Doctor(name, ci, specialty);
            this.Doctor = doctor;
        }

        public void CalculatePrice()
        {
            if(Doctor.GetSpeciality() == "Surgeon")
            {
                Console.WriteLine("Price: 300bs");
            }
            if (Doctor.GetSpeciality() == "Cardiologist")
            {
                Console.WriteLine("Price: 200bs");
            }
            else
            {
                Console.WriteLine("Price: 50bs");
            }
        }

        public void ShowMedicalAttention()
        {
            Console.WriteLine("Date: " + this.Date);
            Console.WriteLine("Description:" + this.Description);
            this.Doctor.GetData();
        }
    }
}
