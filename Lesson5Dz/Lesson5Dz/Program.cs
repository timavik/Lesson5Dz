namespace Lesson5DzOne
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Book book1 = new Book("Разгавор с мумией", "Эдгард Алон По", 16);
      Console.WriteLine(book1.GetDescription());

      Book book2 = new Book("Алхимик", "Пауло Коэльо", 231);
      Console.WriteLine(book2.GetDescription());
    }
  }
}
