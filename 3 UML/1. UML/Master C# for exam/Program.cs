using Master_C__for_exam;
DateTime studentDob = new DateTime(2000, 5, 15);
Student yahya = new Student(
    "Yahya", "5368853122", "yahyashannat@example.com", studentDob, "Elazig",
    "S12345", 3.8
);
yahya.DisplayDetails();
Console.WriteLine($"Is Eligible to Enroll: {yahya.IsEligibleToEnroll()}");
Console.WriteLine($"Calculated GPA: {yahya.CalculateGPA():F2}");

Console.WriteLine();

DateTime professorDob = new DateTime(1975, 8, 20);
Professor drAhmad = new Professor(
    "Dr. Ahmad", "5551234567", "ahmad@example.com", professorDob, "Istanbul",
    120000, "Computer Science"
);
drAhmad.DisplayDetails();
drAhmad.PublishResearchPaper("AI in Education", "Journal of Educational Technology");