namespace Home_Work_4_3
{
    internal class Program
    {
        static void Main()
        {
            Book book = new Book("The Lord of the rings");

            book.Text = "Part 1";
            book.AuthorName = "John Ronald Reuel Tolkien";

            book.Show();

            Console.ReadLine();
        }
    }
}