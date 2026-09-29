public class Employee
{
    public virtual decimal CalculateBonus()
    {
        // Base implementation for calculating bonus
        return 0;
    }
}

public class Manager : Employee
{
    public override decimal CalculateBonus()
    {
        return 1000;
    }
}

public class Developer : Employee
{
    public override decimal CalculateBonus()
    {
        return 500;
    }
}   

