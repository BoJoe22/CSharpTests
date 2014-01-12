using AccessModifiers.library;

namespace AccessModifiers.building
{
    public class House
    {
        public House()
        {
            Book book = new Book();

            //book.author = "ABC";    //compile error: access to protected member of class Book
            //book.modifyTemplate();  //compile error: access to protected method of class Book

            //int c = book.issueCount;  //compile error: access to 'default' member of class Book
            //book.issueHistory();      //compile error: access to 'default' method of class Book
        }
    }
}
