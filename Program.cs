using csharp_oop;

Building shapesGymPembina = new Building("Red","blue","Shapes",1000);
Building shapesGymDowntown = new Building("Orange","Purple","ShapesDowntown",1221);

Customer Asad = new Customer(new DateTime(2022, 08, 07, 14, 0, 33), "Male", "Yearly","Mo",true,"Asad");

Employee manager1 = new Employee("Manager",true,"Muhammad","Asad");
Employee manager2 = new Employee("Manager", false, "John", "Daavid");
Employee assistantManager1 = new Employee("Assistant Manager", true, "Sushant", "D");
Employee assistantManager2 = new Employee("Assistant Manager", false, "jay", "Dhawan");
Employee receptionist1 = new Employee("Receptionist 1", true, "Hamza", "Ch");
Employee receptionist2 = new Employee("Receptionist 2", true, "Akbar", "Khan");
Employee receptionist3 = new Employee("Receptionist 3", false, "Abdullah", "Sheikh");
Employee receptionist4 = new Employee("Receptionist 4", false, "Wahid","Ali");
Employee instructor1 = new Employee("Instructor 1", true, "Asfand", "Sultan");
Employee instructor2 = new Employee("Instructor 2", false, "Jatin", "Sapal");
Employee Instructor3 = new Employee("Instructor 3", true, "Jaspreet", "Singh");
Employee Instructor4 = new Employee("Instructor4", false, "Lovepreet", "Siani");
Employee Instructor5 = new Employee("Instructor5", true, "Hassan", "Khalid");
Employee Instructor6 = new Employee("Instructor6", false, "Asfand", "Tahir");

shapesGymPembina.Employees.Add(assistantManager1);
shapesGymDowntown.Employees.Add(assistantManager2);
shapesGymPembina.Employees.Add(manager1);
shapesGymDowntown.Employees.Add(manager2);
shapesGymPembina.Employees.Add(receptionist1);
shapesGymPembina.Employees.Add(receptionist2);
shapesGymDowntown.Employees.Add(receptionist3);
shapesGymDowntown.Employees.Add(receptionist4);
shapesGymDowntown.Employees.Add(instructor1);
shapesGymDowntown.Employees.Add(instructor2);
shapesGymDowntown.Employees.Add(Instructor3);
shapesGymPembina.Employees.Add(Instructor4);
shapesGymPembina.Employees.Add(Instructor5);
shapesGymPembina.Employees.Add(Instructor6);



Console.WriteLine(shapesGymPembina.Name);
Console.WriteLine(shapesGymDowntown.Name);