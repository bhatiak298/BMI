namespace Heart_rater
{
    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public Patient(string firstName, string lastName, double weight, double height)
        {
            FirstName = firstName;
            LastName = lastName;
            Weight = weight;
            Height = height;
        }

        public string CalculateBloodPressure(int systolic, int diastolic)
        {
            if (systolic >= 90 && systolic <= 120 && diastolic >= 60 && diastolic <= 80)
            {
                return "NORMAL";
            }
            else if (systolic >= 120 && systolic <= 129 && diastolic < 80)
            {
                return "ELEVATED";
            }
            else if (systolic >= 130 && systolic <= 139 && diastolic >= 80 && diastolic <= 89)
            {
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1";
            }
            else if (systolic >= 140 && systolic <= 180 && diastolic >= 90 && diastolic <= 120)
            {
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 2";
            }
            else if (systolic > 180 && diastolic > 120)
            {
                return "HYPERTENSIVE CRISIS (consult your doctor immediately)";
            }
            else
            {
                return "Warning: Blood pressure values are out of range.";
            }
        }

        private void OutputPatientInformation()
        {
            Console.WriteLine("Full Name: " + FirstName + " " + LastName);
            Console.WriteLine("Weight: " + Weight + " kg");
            Console.WriteLine("Height: " + Height + " cm");
            Console.WriteLine("Blood Pressure: " + CalculateBloodPressure(120, 80));
            double bmi = CalculateBMI();
            Console.WriteLine("BMI: " + bmi);

            if (bmi >= 25.0)
            {
                Console.WriteLine("BMI Status: Overweight");
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.WriteLine("BMI Status: Normal (In the healthy range)");
            }
            else
            {
                Console.WriteLine("BMI Status: Underweight");
            }
        }

        private double CalculateBMI()
        {
            double heightInMeters = Height / 100; // Convert height from centimeters to meters
            double bmi = Weight / (heightInMeters * heightInMeters);
            return bmi;
        }
    }
}