using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class ClinicalExamination: IMedialAttention
    {
        private String Date;
        private String Type;
        private String ExamPlace;

        public ClinicalExamination()
        {

        }

        public ClinicalExamination(String date, String type, String examPlace)
        {
            this.Date = date;
            this.Type = type;
            this.ExamPlace = examPlace;
        }

        public void CreateClinicalExamination()
        {
            Console.WriteLine("Date: ");
            this.Date = Console.ReadLine();
            Console.WriteLine("Type: ");
            this.Type = Console.ReadLine();
            Console.WriteLine("Exam Place: ");
            this.ExamPlace = Console.ReadLine();
        }

        public void CalculatePrice()
        {
            if(Type == "X-Rays")
            {
                Console.WriteLine("Price: 100bs");
            }
            if (Type == "Blood-Test")
            {
                Console.WriteLine("Price: 20bs");
            }
            if (Type == "Electrocardiogram")
            {
                Console.WriteLine("Price: 80bs");
            }
            else
            {
                Console.WriteLine("Price: 50bs");
            }
        }
        public void ShowMedicalAttention()
        {
            Console.WriteLine("Date: " + this.Date);
            Console.WriteLine("Type:" + this.Type);
            Console.WriteLine("Exam Place:" + this.ExamPlace);
        }
    }
}
