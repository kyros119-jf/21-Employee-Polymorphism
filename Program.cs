List<Employee> employees = new List<Employee>
{
    new Manager(),
    new Developer()
};  

foreach (Employee e in employees)
{
  Console.WriteLine($"{e.GetType().Name} Bonus: ${e.CalculateBonus()}");
}