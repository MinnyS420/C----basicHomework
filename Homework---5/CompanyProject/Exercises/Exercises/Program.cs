using Domain.Classes;
Console.WriteLine("============== Homework part 1 =============");

// Create a Manager instance for the Contractor to be responsible to
Manager mng = new Manager("John", "Doe", 60000);
mng.Department = "Sales";
Console.WriteLine(mng.Department);

Console.WriteLine("============== Homework part 2 =============");
// Create array of employees
Employee[] Company = new Employee[5];
Company[0] = new Contractor("John", "Doe", 40, 20, new Manager("Michael", "Scott", 3000));
Company[1] = new Contractor("Jane", "Doe", 30, 25, new Manager("Dwight", "Schrute", 2500));
Company[2] = new Manager("Pam", "Beesly", 4000);
Company[3] = new Manager("Jim", "Halpert", 4500);
Company[4] = new SalesPerson("Andy", "Bernard");

Manager manager1 = new Manager("Rick", "Rickert", 5000);
manager1.Department = "Sales";
Manager manager2 = new Manager("Mona", "Monalisa", 7000);
manager2.Department = "Storage";
Contractor contractor1 = new Contractor("Bob", "Bobert", 160, 10, manager1);
Contractor contractor2 = new Contractor("Igor", "Igorsky", 200, 12, manager2);
SalesPerson salesPerson1 = new SalesPerson("Lea", "Leova");
salesPerson1.AddSuccessRevenue(3000);

CEO ceoName = new CEO("Ron", "Ronsky", 1500, Company, 14);
ceoName.AddSharesPrice(100);

ceoName.GetInfo();
Console.WriteLine($"CEO: {ceoName.GetInfo()} {ceoName.Salary}");
Console.WriteLine($"Salary of CEO is: {ceoName.GetSalary()}");

Console.WriteLine("===========================");
Console.WriteLine("Employees:");
ceoName.PrintEmployees();

contractor1.GetCurrentPosition();
Console.WriteLine(contractor1.GetCurrentPosition());
Console.WriteLine(contractor2.GetCurrentPosition());
Console.WriteLine("===========================");