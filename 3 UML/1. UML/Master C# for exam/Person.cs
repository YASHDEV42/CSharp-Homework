using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_C__for_exam
{
    class Person
    {
        private string name;
        private string phoneNumber;
        private string emailAddress;
        private DateTime dateOfBirth;
        private string address;

        public Person(string name, string phoneNumber, string emailAddress, DateTime dateOfBirth, string address)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
        }
        public string Name => name;
        public string PhoneNumber => phoneNumber;
        public string EmailAddress => emailAddress;
        public DateTime DateOfBirth => dateOfBirth;
        public string Address => address;

        public void PurchaseParkingPass()
        {
            Console.WriteLine($"{name} has purchased a parking pass.");
        }

        public void UpdateContactInfo(string newEmail, string newAddress)
        {
            if (!string.IsNullOrWhiteSpace(newEmail) && !newEmail.Contains("@"))
            {
                throw new ArgumentException("Invalid email address.");
            }

            this.emailAddress = newEmail;
            this.address = newAddress;
            Console.WriteLine("Contact information updated successfully.");
        }

        public int GetAge()
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;

            if (DateTime.Now.Month < dateOfBirth.Month ||
                (DateTime.Now.Month == dateOfBirth.Month && DateTime.Now.Day < dateOfBirth.Day))
            {
                age--;
            }

            return age;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Phone Number: {phoneNumber}");
            Console.WriteLine($"Email Address: {emailAddress}");
            Console.WriteLine($"Date of Birth: {dateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Address: {address}");
        }
    }

    class Student : Person
    {
        private string studentNumber;
        private double averageMark;

        public Student(string name, string phoneNumber, string emailAddress, DateTime dateOfBirth, string address,
                       string studentNumber, double averageMark)
            : base(name, phoneNumber, emailAddress, dateOfBirth, address)
        {
            this.studentNumber = studentNumber;
            this.averageMark = averageMark;
        }

        public string StudentNumber => studentNumber;
        public double AverageMark => averageMark;

        public bool IsEligibleToEnroll()
        {
            return averageMark >= 2.5;
        }

        public double CalculateGPA()
        {
            return averageMark / 25.0;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Student Number: {studentNumber}");
            Console.WriteLine($"Average Mark: {averageMark}");
        }
    }
    class Professor : Person
    {
        private decimal salary;
        private string department;
        public Professor(string name, string phoneNumber, string emailAddress, DateTime dateOfBirth, string address,
                         decimal salary, string department)
            : base(name, phoneNumber, emailAddress, dateOfBirth, address)
        {
            this.salary = salary;
            this.department = department;
        }

        public decimal Salary => salary;
        public string Department => department;

        public void PublishResearchPaper(string title, string journal)
        {
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(journal))
                throw new ArgumentException("Title and journal cannot be null or empty.");

            Console.WriteLine($"{Name} has published a research paper titled \"{title}\" in the journal \"{journal}\".");
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Salary: {salary:C}");
            Console.WriteLine($"Department: {department}");
        }
    }
}
