# LINQ Demos in C#

This repository demonstrates the use of LINQ (Language Integrated Query) in C#. The examples include basic LINQ queries applied to a collection of `Student` objects.

## Prerequisites

To run the code, ensure you have:

- .NET SDK installed ([Download .NET SDK](https://dotnet.microsoft.com/download))
- A code editor such as Visual Studio or Visual Studio Code

## Code Overview

### Student Class
The `Student` class is a model that represents student data:
```csharp
public class Student
{
    public int Rno { get; set; }
    public string Name { get; set; }
    public string Branch { get; set; }
    public int sem { get; set; }
    public double CPI { get; set; }

    public static List<Student> GetStudents()
    {
        List<Student> students = new List<Student>()
        {
            new Student{Rno=101, Name="Namra", Branch="CSE", sem=6, CPI=7.5 },
            new Student{Rno=102, Name="Jensi", Branch="CSE", sem=6, CPI=7.5 },
            new Student{Rno=103, Name="Sumit", Branch="CSE", sem=6, CPI=5.5 },
            new Student{Rno=104, Name="Meet", Branch="CSE", sem=6, CPI=6.5 },
            new Student{Rno=105, Name="Krisha", Branch="CSE", sem=6, CPI=2.5 },
            new Student{Rno=106, Name="Reni", Branch="CSE", sem=6, CPI=7.5 },
            new Student{Rno=107, Name="Rohan", Branch="CSE", sem=6, CPI=3.5 },
            new Student{Rno=108, Name="Raj", Branch="CSE", sem=6, CPI=7.9 },
            new Student{Rno=109, Name="Riya", Branch="CSE", sem=6, CPI=7.8 },
            new Student{Rno=110, Name="Rohan", Branch="CSE", sem=6, CPI=7.5 },
        };
        return students;
    }
}
```

### LINQ Demos

#### Demo 1: Displaying All Students
This demo retrieves all students and prints their details using a `foreach` loop.
```csharp
var students = Student.GetStudents();
foreach(var student in students)
{
    Console.WriteLine($"Roll No: {student.Rno}, Name: {student.Name}, Branch: {student.Branch}, Sem: {student.sem}, CPI: {student.CPI}");
}
```

#### Demo 2: Selecting Students into a New List
This demo uses LINQ's `Select` method to create a new collection of `Student` objects and displays the data.
```csharp
var studentList = Student.GetStudents().Select(x => new Student()
{
    Rno = x.Rno,
    Name = x.Name,
    Branch = x.Branch,
    sem = x.sem,
    CPI = x.CPI
});
foreach(var student in studentList)
{
    Console.WriteLine($"Roll No: {student.Rno}, Name: {student.Name}, Branch: {student.Branch}, Sem: {student.sem}, CPI: {student.CPI}");
}
```

#### Demo 3: Projecting Specific Properties
This demo uses LINQ's `Select` method to project specific properties into an anonymous type.
```csharp
var studentList1 = Student.GetStudents()
    .Select(x => new
    {
        NameAndRno = x.Name + "-" + x.Rno,
        Branch = x.Branch,
        sem = x.sem,
        CPI = x.CPI
    });
foreach(var student in studentList1)
{
    Console.WriteLine($"Name and Roll No: {student.NameAndRno}, Branch: {student.Branch}, Sem: {student.sem}, CPI: {student.CPI}");
}
```

## Running the Code

1. Clone the repository.
2. Open the project in Visual Studio or Visual Studio Code.
3. Build and run the application using `dotnet run`.

## Output
The output of the program will include three demos:

### Demo 1 Output
Displays all student details.
```
Roll No: 101, Name: Namra, Branch: CSE, Sem: 6, CPI: 7.5
...
```

### Demo 2 Output
Displays all student details from the newly created list.
```
Roll No: 101, Name: Namra, Branch: CSE, Sem: 6, CPI: 7.5
...
```

### Demo 3 Output
Displays the projected data with `NameAndRno` and other details.
```
Name and Roll No: Namra-101, Branch: CSE, Sem: 6, CPI: 7.5
...
```

## License
This project is licensed under the MIT License. Feel free to use and modify it as needed.
