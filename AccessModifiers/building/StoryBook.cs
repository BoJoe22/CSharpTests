using AccessModifiers.library;

namespace AccessModifiers.building
{
    public class StoryBook : Book
    {
        public StoryBook()
        {
            author = "ABC";     //protected member from class Book
            modifyTemplate();   //protected method from class Book

            //int c = issueCount; //'default' member from class Book
            //issueHistory();     //'default' member from class Book
        }
    }
}
