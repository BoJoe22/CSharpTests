
namespace AccessModifiers.library
{
    public class CourseBook : Book
    {
        public CourseBook()
        {
            author = "ABC";     //protected member from the Book class
            modifyTemplate();   //protected method from the Book class

            /*** The following two lines of code would work if this were Java 
                 because Java allows free access within the same 'package' to 'default' modifiers.
                 C# on the other hand treats 'default' as private.  ***/
            //int c = issueCount; //compile error: access to 'default' member of Book class
            //issueHistory();     //compile error: access to 'default' method of Book class
        }
    }
}
