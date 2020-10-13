using System;
using System.Collections.Generic;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {

            MedicalHistory medicalHistory = new MedicalHistory();
            int option;
            do
            {
                Console.Clear();
                Console.WriteLine("---------Create your Medical History---------");
                Console.WriteLine("1. Insert Personal Data");
                Console.WriteLine("2. Create Medical Consultation");
                Console.WriteLine("3. Create Clinical Examination");
                Console.WriteLine("4. Show Medical Consultations");
                Console.WriteLine("5. Show Clinical Examinations");
                Console.WriteLine("6. Show Personal Data");
                Console.WriteLine("0. Salir");
                Console.Write("Escoja una opcion:");
                option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Patient patient = new Patient();
                        patient.CreatePatient();
                        medicalHistory.Patient = patient;
                        break;
                    case 2:
                        Console.Clear();
                        MedicalConsultation medicalConsultation = new MedicalConsultation();
                        medicalConsultation.CreateMedicalConsultation();
                        medicalHistory.CreateMedicalConsultation(medicalConsultation);
                        break;
                    case 3:
                        Console.Clear();
                        ClinicalExamination clinicalExamination = new ClinicalExamination();
                        clinicalExamination.CreateClinicalExamination();
                        medicalHistory.CreateClinicalExaminations(clinicalExamination);
                        break;
                    case 4:
                        Console.Clear();
                        medicalHistory.ShowMedicalConsultations();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        medicalHistory.ShowClinicalExaminations();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        medicalHistory.ShowPatient();
                        Console.ReadKey();
                        break;
                    default:
                        break;

                }

            } while (option != 0);
        }
    }
}
