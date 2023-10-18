namespace Lab_3;

public abstract class TaskBase
{
    protected TaskBase(string taskName, decimal price)
    {
        if (!string.IsNullOrEmpty(taskName))
        {
            TaskName = taskName;
        }
        else
        {
            throw new ArgumentException(null, nameof(taskName));
        }
        
        Price = price;
    }

    public decimal Price { get; set; }
    public string TaskName { get; set; }
}