using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class MedicalHistory
    {
        public Patient Patient { get; set; }
        private List<MedicalConsultation> MedicalConsultations { get; set; }

        private List<ClinicalExamination> ClinicalExaminations { get; set; }

        public MedicalHistory()
        {
            MedicalConsultations = new List<MedicalConsultation>();
            ClinicalExaminations = new List<ClinicalExamination>();
        }

        public void CreateMedicalConsultation(MedicalConsultation medicalConsultation)
        {
            MedicalConsultations.Add(medicalConsultation);
        }

        public void CreateClinicalExaminations(ClinicalExamination clinicalExamination)
        {
            ClinicalExaminations.Add(clinicalExamination);
        }

        public void ShowPatient()
        {
            Patient.GetData();
        }

        public void ShowMedicalConsultations()
        {
            foreach (MedicalConsultation medicalConsultation in MedicalConsultations)
            {
                Console.WriteLine("------CONSULTATION--------");
                medicalConsultation.ShowMedicalAttention();
                medicalConsultation.CalculatePrice();
            }
        }

        public void ShowClinicalExaminations()
        {
            foreach (ClinicalExamination clinicalExamination in ClinicalExaminations)
            {
                Console.WriteLine("------CLINICAL EXAMINATION--------");
                clinicalExamination.ShowMedicalAttention();
                clinicalExamination.CalculatePrice();
            }
        }
    }
}
