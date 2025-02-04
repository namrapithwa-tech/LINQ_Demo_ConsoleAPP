// Student output start (Select Operations)

    // Demo 1
    Console.WriteLine("LINQ DEMO 1");
    var students = Student.GetStudents();
    foreach(var student in students)
    {
        Console.WriteLine($"Roll No: {student.Rno}, Name: {student.Name}, Branch: {student.Branch}, " +
            $"Sem: {student.sem}, CPI: {student.CPI}");
    }
    Console.WriteLine("__________________________");

    // Demo 2
    Console.WriteLine("LINQ DEMO 2");
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
        Console.WriteLine($"Roll No: {student.Rno}, Name: {student.Name}, Branch: {student.Branch}, " +
            $"Sem: {student.sem}, CPI: {student.CPI}");
    }
    Console.WriteLine("__________________________");

    // Demo 3
    Console.WriteLine("LINQ DEMO 3");
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
        Console.WriteLine($"Name and Roll No: {student.NameAndRno}, Branch: {student.Branch}, " +
            $"Sem: {student.sem}, CPI: {student.CPI}");
    }
    Console.WriteLine("__________________________");

    // Demo 4 where clause
    Console.WriteLine("LINQ DEMO 4 Where Clause");
    var studentList2 = Student.GetStudents()
        .Where(x => x.CPI > 7)
        .Select(x => new
        {
            NameAndRno = x.Name + "-" + x.Rno,
            Branch = x.Branch,
            sem = x.sem,
            CPI = x.CPI
        });
    foreach(var student in studentList2)
        {
        Console.WriteLine($"Name and Roll No: {student.NameAndRno}, Branch: {student.Branch}, " +
            $"Sem: {student.sem}, CPI: {student.CPI}");
        }
    Console.WriteLine("__________________________");

    // Demo 5 Where clause with multiple conditions
    //Console.WriteLine("LINQ DEMO 5 Where Clause with multiple conditions");
    //Console.WriteLine(
    //    "Enter the minimum CPI: ");
    //Console.WriteLine(
    //    "Enter the minimum sem: ");
    //var minCPI = Convert.ToDouble(Console.ReadLine());
    //var minSem = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine(
    //    "Enter the maximum CPI: ");
    //Console.WriteLine(
    //    "Enter the maximum sem: ");
    //var maxCPI = Convert.ToDouble(Console.ReadLine());
    //var maxSem = Convert.ToInt32(Console.ReadLine());
    //var studentList3 = Student.GetStudents()
    //    .Where(x => x.CPI >= minCPI && x.CPI <= maxCPI && x.sem >= minSem && x.sem <= maxSem)
    //    .Select(x => new
    //    {
    //        NameAndRno = x.Name + "-" + x.Rno,
    //        Branch = x.Branch,
    //        sem = x.sem,
    //        CPI = x.CPI
    //    });
    //foreach(var student in studentList3)
    //    {
    //    Console.WriteLine($"Name and Roll No: {student.NameAndRno}, Branch: {student.Branch}, " +
    //        $"Sem: {student.sem}, CPI: {student.CPI}");
    //    }
    //Console.WriteLine("__________________________");

// Student Output end (Select Operations)

Console.WriteLine("*/*/*/*/*//*/*/*/*/*/*/*/*/*/*/*/*/*/*/*");

// Employee output start (Diffrent types of where clause)

    var employees = Employee.GetEmployees();

    // 1. Select all whose age is greater than 25
    Console.WriteLine("1. Employees whose age is greater than 25:");
    var ageAbove25 = employees.Where(e => e.Age > 25);
    foreach (var emp in ageAbove25)
        Console.WriteLine($"EmpId: {emp.EmpId}, Name: {emp.Name}, Age: {emp.Age}, Email: {emp.Email}, Gender: {emp.Gender}, Salary: {emp.Salary}");
    Console.WriteLine("____________");

    // 2. Select data of all female employees
    Console.WriteLine("2. All female employees:");
    var femaleEmployees = employees.Where(e => e.Gender == "Female");
    foreach (var emp in femaleEmployees)
        Console.WriteLine($"EmpId: {emp.EmpId}, Name: {emp.Name}, Age: {emp.Age}, Email: {emp.Email}, Gender: {emp.Gender}, Salary: {emp.Salary}");
    Console.WriteLine("____________");

    // 3. Select all data whose age is between 25 to 30
    Console.WriteLine("3. Employees whose age is between 25 and 30:");
    var ageBetween25And30 = employees.Where(e => e.Age >= 25 && e.Age <= 30);
    foreach (var emp in ageBetween25And30)
        Console.WriteLine($"EmpId: {emp.EmpId}, Name: {emp.Name}, Age: {emp.Age}, Email: {emp.Email}, Gender: {emp.Gender}, Salary: {emp.Salary}");
    Console.WriteLine("____________");

    // 4. Select all female employees whose EmpId is between 1003 to 1006
    Console.WriteLine("4. Female employees whose EmpId is between 1003 and 1006:");
    var femaleEmpIdRange = employees.Where(e => e.Gender == "Female" && e.EmpId >= 1003 && e.EmpId <= 1006);
    foreach (var emp in femaleEmpIdRange)
        Console.WriteLine($"EmpId: {emp.EmpId}, Name: {emp.Name}, Age: {emp.Age}, Email: {emp.Email}, Gender: {emp.Gender}, Salary: {emp.Salary}");
    Console.WriteLine("____________");

    // 5. Select data whose name is Jensi
    Console.WriteLine("5. Employee whose name is Jensi:");
    var jensi = employees.Where(e => e.Name == "Jensi");
    foreach (var emp in jensi)
        Console.WriteLine($"EmpId: {emp.EmpId}, Name: {emp.Name}, Age: {emp.Age}, Email: {emp.Email}, Gender: {emp.Gender}, Salary: {emp.Salary}");
    Console.WriteLine("____________");

    // 6. Select data of candidates whose age is 30
    Console.WriteLine("6. Employees whose age is 30:");
    var age30 = employees.Where(e => e.Age == 30);
    foreach (var emp in age30)
        Console.WriteLine($"EmpId: {emp.EmpId}, Name: {emp.Name}, Age: {emp.Age}, Email: {emp.Email}, Gender: {emp.Gender}, Salary: {emp.Salary}");
    Console.WriteLine("____________");

    // 7. Select data of candidates whose name starts with "J"
    Console.WriteLine("7. Employees whose name starts with 'J':");
    var nameStartsWithJ = employees.Where(e => e.Name.StartsWith("J"));
    foreach (var emp in nameStartsWithJ)
        Console.WriteLine($"EmpId: {emp.EmpId}, Name: {emp.Name}, Age: {emp.Age}, Email: {emp.Email}, Gender: {emp.Gender}, Salary: {emp.Salary}");
    Console.WriteLine("____________");

    // 8. Select data of candidates who is containing 'mra' in email id
    Console.WriteLine("8. Employees whose email contains 'mra':");
    var emailContainsMra = employees.Where(e => e.Email.Contains("mra"));
    foreach (var emp in emailContainsMra)
        Console.WriteLine($"EmpId: {emp.EmpId}, Name: {emp.Name}, Age: {emp.Age}, Email: {emp.Email}, Gender: {emp.Gender}, Salary: {emp.Salary}");
    Console.WriteLine("____________");

    // 9. Select data of candidates whose name is having Namra
    Console.WriteLine("9. Employee whose name is Namra:");
    var nameIsNamra = employees.Where(e => e.Name == "Namra");
    foreach (var emp in nameIsNamra)
        Console.WriteLine($"EmpId: {emp.EmpId}, Name: {emp.Name}, Age: {emp.Age}, Email: {emp.Email}, Gender: {emp.Gender}, Salary: {emp.Salary}");
    Console.WriteLine("____________");

    // 10. Select data of candidates whose name contains 'mi'
    Console.WriteLine("10. Employees whose name contains 'mi':");
    var nameContainsMi = employees.Where(e => e.Name.Contains("mi"));
    foreach (var emp in nameContainsMi)
        Console.WriteLine($"EmpId: {emp.EmpId}, Name: {emp.Name}, Age: {emp.Age}, Email: {emp.Email}, Gender: {emp.Gender}, Salary: {emp.Salary}");
    Console.WriteLine("____________");

    // 11. Select data of candidates whose age is either 20, 25, or 27
    Console.WriteLine("11. Employees whose age is either 20, 25, or 27:");
    var specificAges = employees.Where(e => e.Age == 20 || e.Age == 25 || e.Age == 27);
    foreach (var emp in specificAges)
        Console.WriteLine($"EmpId: {emp.EmpId}, Name: {emp.Name}, Age: {emp.Age}, Email: {emp.Email}, Gender: {emp.Gender}, Salary: {emp.Salary}");
    Console.WriteLine("____________");
// Employee output end (Diffrent types of where clause)

// Employe_New output start

    // 1. Get a list of employee names.
    var employeeNames = Employee_New.GetEmployees().Select(e => e.Name).ToList();
    Console.WriteLine("Employee Names:");
    employeeNames.ForEach(name => Console.WriteLine(name));
    Console.WriteLine("____________");

    // 2. Get names and their respective departments.
    var namesAndDepartments = Employee_New.GetEmployees().Select(e => new { e.Name, e.Department }).ToList();
    Console.WriteLine("Names and Departments:");
    namesAndDepartments.ForEach(nd => Console.WriteLine($"Name: {nd.Name}, Department: {nd.Department}"));
    Console.WriteLine("____________");

    // 3. Get names of employees earning more than 5000.
    var highEarners = Employee_New.GetEmployees().Where(e => e.Salary > 5000).Select(e => e.Name).ToList();
    Console.WriteLine("Employees earning more than 5000:");
    highEarners.ForEach(name => Console.WriteLine(name));
    Console.WriteLine("____________");

    // 4. Get the names in uppercase.
    var upperCaseNames = Employee_New.GetEmployees().Select(e => e.Name.ToUpper()).ToList();
    Console.WriteLine("Employee Names in Uppercase:");
    upperCaseNames.ForEach(name => Console.WriteLine(name));
    Console.WriteLine("____________");

    // 5. Get employee IDs along with salaries as strings.
    var idsAndSalaries = Employee_New.GetEmployees().Select(e => new { e.EmployeeID, SalaryString = e.Salary.ToString() }).ToList();
    Console.WriteLine("Employee IDs and Salaries:");
    idsAndSalaries.ForEach(idSal => Console.WriteLine($"EmployeeID: {idSal.EmployeeID}, Salary: {idSal.SalaryString}"));
    Console.WriteLine("____________");

    // 6. Get all unique skills.
    var uniqueSkills = Employee_New.GetEmployees().SelectMany(e => e.Skills).Distinct().ToList();
    Console.WriteLine("Unique Skills:");
    uniqueSkills.ForEach(skill => Console.WriteLine(skill));
    Console.WriteLine("____________");

    // 7. Get employees who know "C#".
    var knowsCSharp = Employee_New.GetEmployees().Where(e => e.Skills.Contains("C#")).Select(e => e.Name).ToList();
    Console.WriteLine("Employees who know C#:");
    knowsCSharp.ForEach(name => Console.WriteLine(name));
    Console.WriteLine("____________");

    // 8. Get department-wise skill sets.
    var departmentSkills = Employee_New.GetEmployees()
        .GroupBy(e => e.Department)
        .Select(g => new { Department = g.Key, Skills = g.SelectMany(e => e.Skills).Distinct().ToList() })
        .ToList();
    Console.WriteLine("Department-wise Skill Sets:");
    departmentSkills.ForEach(ds =>
    {
        Console.WriteLine($"Department: {ds.Department}");
        ds.Skills.ForEach(skill => Console.WriteLine($"  Skill: {skill}"));
    });
    Console.WriteLine("____________");

    // 9. Get employees older than 30.
    var olderThan30 = Employee_New.GetEmployees().Where(e => e.Age > 30).Select(e => e.Name).ToList();
    Console.WriteLine("Employees older than 30:");
    olderThan30.ForEach(name => Console.WriteLine(name));
    Console.WriteLine("____________");

    // 10. Get permanent employees.
    var permanentEmployees = Employee_New.GetEmployees().Where(e => e.IsPermanent).Select(e => e.Name).ToList();
    Console.WriteLine("Permanent Employees:");
    permanentEmployees.ForEach(name => Console.WriteLine(name));
    Console.WriteLine("____________");


// Employe_New output end


// Student class Start
public class Student()
{
    public int Rno { get; set; }
    public string Name { get; set; }
    public string Branch { get; set; }
    public int sem { get; set; }
    public double CPI { get; set; }

    public static List<Student>GetStudents()
    {
        List<Student> students = new List<Student>()
        {
            new Student{Rno=101, Name="Namra", Branch="CSE", sem=6, CPI=7.5 },
            new Student{Rno=102, Name="Jensi", Branch="CSE", sem=6, CPI=7.5 },
            new Student{Rno=103, Name="Sumit", Branch="CSE", sem=5, CPI=5.5 },
            new Student{Rno=104, Name="Meet", Branch="CSE", sem=5, CPI=6.5 },
            new Student{Rno=105, Name="Krisha", Branch="CSE", sem=6, CPI=2.5 },
            new Student{Rno=106, Name="Reni", Branch="CSE", sem=4, CPI=7.5 },
            new Student{Rno=107, Name="Rohan", Branch="CSE", sem=6, CPI=3.5 },
            new Student{Rno=108, Name="Raj", Branch="CSE", sem=6, CPI=7.9 },
            new Student{Rno=109, Name="Riya", Branch="CSE", sem=3, CPI=7.8 },
            new Student{Rno=110, Name="Rohan", Branch="CSE", sem=6, CPI=7.5 },
        };
        return students;
    }
}

// Student class End

// Employee class Start

public class Employee
{
    public int EmpId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string Gender { get; set; }
    public double Salary { get; set; }

    public static List<Employee> GetEmployees()
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee{EmpId=101, Name="Namra", Age=22, Email="namra@gmail.com",Gender="Male" , Salary=50000 },
            new Employee{EmpId=102, Name="Jensi", Age=22, Email="jensi@gmail.com",Gender="Female",Salary=10000 },
            new Employee{EmpId=103, Name="Sumit", Age=25, Email="sumit@gmail.com", Gender="Male", Salary=30000 },
            new Employee{EmpId=104, Name="Riya", Age=23, Email="riya@gmail.com", Gender="Female", Salary=35000 },
            new Employee{EmpId=105, Name="Raj", Age=26, Email="raj@gmail.com", Gender="Male", Salary=45000 },
            new Employee{EmpId=106, Name="Krisha", Age=24, Email="krisha@gmail.com", Gender="Female", Salary=40000 },
            new Employee{EmpId=107, Name="Rohan", Age=28, Email="rohan@gmail.com", Gender="Male", Salary=55000 },
            new Employee{EmpId=108, Name="Reni", Age=22, Email="reni@gmail.com", Gender="Female", Salary=30000 },
            new Employee{EmpId=109, Name="Meet", Age=27, Email="meet@gmail.com", Gender="Male", Salary=60000 },
            new Employee{EmpId=110, Name="Priya", Age=21, Email="priya@gmail.com", Gender="Female", Salary=25000 },
        };
        return employees;
    }
}

// Employee class End

// New Employee class Start

public class Employee_New 
{
    public int EmployeeID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
    public List<string> Skills { get; set; }
    public int Age { get; set; }
    public bool IsPermanent { get; set; }

    public static List<Employee_New> GetEmployees()
    {
        List<Employee_New> employeesnew = new List<Employee_New>()
        {
            new Employee_New { EmployeeID = 1, Name = "John", Department = "IT", Salary = 5000, Skills = new List<string> { "C#", "SQL" }, Age = 30, IsPermanent = true },
            new Employee_New { EmployeeID = 2, Name = "Emma", Department = "HR", Salary = 4000, Skills = new List<string> { "Communication", "Management" }, Age = 28, IsPermanent = false },
            new Employee_New { EmployeeID = 3, Name = "Michael", Department = "IT", Salary = 7000, Skills = new List<string> { "Java", "Python" }, Age = 35, IsPermanent = true },
            new Employee_New { EmployeeID = 4, Name = "Sophia", Department = "Finance", Salary = 6000, Skills = new List<string> { "Accounting", "Excel" }, Age = 32, IsPermanent = true },
            new Employee_New { EmployeeID = 5, Name = "Daniel", Department = "IT", Salary = 5500, Skills = new List<string> { "C#", "JavaScript" }, Age = 27, IsPermanent = false },
            new Employee_New { EmployeeID = 6, Name = "Olivia", Department = "Marketing", Salary = 4800, Skills = new List<string> { "SEO", "Advertising" }, Age = 29, IsPermanent = true },
            new Employee_New { EmployeeID = 7, Name = "David", Department = "IT", Salary = 6500, Skills = new List<string> { "Python", "Machine Learning" }, Age = 40, IsPermanent = true },
            new Employee_New { EmployeeID = 8, Name = "Liam", Department = "HR", Salary = 4200, Skills = new List<string> { "Public Relations", "Recruiting" }, Age = 26, IsPermanent = false },
            new Employee_New { EmployeeID = 9, Name = "Isabella", Department = "Finance", Salary = 5800, Skills = new List<string> { "Budgeting", "Taxation" }, Age = 31, IsPermanent = true },
            new Employee_New { EmployeeID = 10, Name = "Ethan", Department = "Marketing", Salary = 5200, Skills = new List<string> { "Social Media", "Copywriting" }, Age = 33, IsPermanent = false }

        };
        return employeesnew;
    }
}

// New Employee class End