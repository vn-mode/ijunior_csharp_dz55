public class Program
{
    public static void Main()
    {
        List<CannedFood> cannedFoods = new List<CannedFood>
        {
            new CannedFood("Банка 1", 2018, 5),
            new CannedFood("Банка 2", 2020, 3),
            new CannedFood("Банка 3", 2022, 1)
        };

        int currentYear = DateTime.Now.Year;

        List<CannedFood> expiredCannedFoods = new List<CannedFood>();

        foreach (var cannedFood in cannedFoods)
        {
            if (cannedFood.IsExpired(currentYear))
            {
                expiredCannedFoods.Add(cannedFood);
            }
        }

        foreach (var cannedFood in expiredCannedFoods)
        {
            Console.WriteLine($"{cannedFood.Name} с производственным годом {cannedFood.ProductionYear} просрочена.");
        }
    }
}

public class CannedFood
{
    private string _name;
    private int _productionYear;
    private int _expirationTerm;

    public CannedFood(string name, int productionYear, int expirationTerm)
    {
        _name = name;
        _productionYear = productionYear;
        _expirationTerm = expirationTerm;
    }

    public string Name
    {
        get { return _name; }
    }

    public int ProductionYear
    {
        get { return _productionYear; }
    }

    public int ExpirationTerm
    {
        get { return _expirationTerm; }
    }

    public bool IsExpired(int currentYear)
    {
        return _productionYear + _expirationTerm < currentYear;
    }
}
