using Jproect;

//Calculator calculator= new Calculator();
//calculator.Calculation(6, 2);







Employee employee1 = new Employee();
employee1.Name = "Sahin";
employee1.Surname = "Zakirov";
employee1.Age = 25;
employee1.Salary = 1650;


Employee employee2 = new Employee();
employee2.Name = "Nail";
employee2.Surname = "Veliev";
employee2.Age = 29;
employee2.Salary = 1140;



Employee employee3 = new Employee();
employee3.Name = "Samir";
employee3.Surname = "Agayev";
employee3.Age = 42;
employee3.Salary = 950;



Employee employee4 = new Employee();
employee4.Name = "Leyla";
employee4.Surname = "Rustemova";
employee4.Age = 23;
employee4.Salary = 875;

Employee[] employes = {employee1,employee2,employee3,employee4};
foreach (var item in employes)
{
	if (1000 < item.Salary && item.Salary < 2000) ;
	{
		Console.WriteLine(item.Name + " " + item.Surname + " " + item.Age + " " + item.Salary);
	}
}