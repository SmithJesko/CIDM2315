namespace homework6;

class Program
{
    static void Main(string[] args)
    {
        // Define professors
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.SetSalary(9000);

        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.SetSalary(8000);

        // Print professor info
        Console.WriteLine($"Professor {p1.profName} teaches {p1.classTeach}, and the salary is: {p1.GetSalary()}");
        Console.WriteLine($"Professor {p2.profName} teaches {p2.classTeach}, and the salary is: {p2.GetSalary()}");

        // Define students
        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.SetGrade(90);

        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.SetGrade(80);

        // Print student info
        Console.WriteLine($"Student {s1.studentName} enrolls in {s1.classEnroll}, and the grade is: {s1.GetGrade()}");
        Console.WriteLine($"Student {s2.studentName} enrolls in {s2.classEnroll}, and the grade is: {s2.GetGrade()}");

        // Calculations
        Console.WriteLine($"The salary difference between {p1.profName} and {p2.profName} is: {p1.GetSalary() - p2.GetSalary()}");
        Console.WriteLine($"The total grade of {s1.studentName} and {s2.studentName} is: {s1.GetGrade() + s2.GetGrade()}");
    }
}


class Professor{
    public string profName = string.Empty;
    public string classTeach = string.Empty;
    private double salary;

    public void SetSalary(double salary_amount){
        salary = salary_amount;
    }

    public double GetSalary(){
        return salary;
    }
}


class Student{
    public string studentName = string.Empty;
    public string classEnroll = string.Empty;
    private double studentGrade;

    public void SetGrade(double newGrade){
        studentGrade = newGrade;
    }

    public double GetGrade(){
        return studentGrade;
    }
}