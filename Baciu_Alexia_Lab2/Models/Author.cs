namespace Baciu_Alexia_Lab2.Models;

public class Author
{
    public int Id { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public ICollection<Book>? Books { get; set; }
    
    public string FullName => $"{FirstName} {LastName}";
}