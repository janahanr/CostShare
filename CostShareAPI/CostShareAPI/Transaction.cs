namespace CostShareAPI;

public class Transaction
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int GroupId { get; set; }

    public string Name { get; set; }

    public int Amount { get; set; }
}
