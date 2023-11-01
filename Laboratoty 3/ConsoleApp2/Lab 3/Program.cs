namespace Lab_3;

 // See https://aka.ms/new-console-template for more information
internal abstract class Program
{
    static void Main(string[] args)
    {
        var header = new Layout("Создать заголовок",200);
        var burgerMenu = new Design("Сделать дизайн меню", 100); 
        var site = new WebSite<TaskBase>();
        site.Tasklist.Add(header);
        site.Tasklist.Add(burgerMenu);
        site.PrintCompleteTasks();
    }
}