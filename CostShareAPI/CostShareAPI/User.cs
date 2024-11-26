namespace CostShareAPI;

public class User
{
    public int Id { get; set; }

    public string Name { get; set; }

    public float TotalOwed { get; set; }

    public float TotalOwing => 1 - TotalOwed;
}
