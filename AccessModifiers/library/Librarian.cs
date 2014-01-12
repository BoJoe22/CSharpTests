
namespace AccessModifiers.library
{
    public class Librarian
    {
        public Librarian()
        {
            Book book = new Book();

            /*** The following two lines of code would work if this were Java 
                 because Java allows free access within the same 'package' to protected modifiers ***/
            //book.author = "ABC";    //compile error: protected member from class Book
            //book.modifyTemplate();  //compile error: protected method from class Book

            /*** The following two lines of code would work if this were Java 
                 because Java allows free access within the same 'package' to 'default' modifiers.
                 C# on the other hand treats 'default' as private.  ***/
            //int c = book.issueCount;    //compile error: access to 'default' member of Book class
            //book.issueHistory();        //compile error: access to 'default' method of Book class
        }
    }
}
