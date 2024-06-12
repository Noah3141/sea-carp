
namespace sea_carp.Models;

public class ToDo
{
    public int Id { get; set; }
    public bool IsComplete { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }


    public override bool Equals(object? obj)
    {
        return obj is ToDo todo &&
               Id == todo.Id;
    }

    public override string ToString()
    {
        return $"{Title} - {Id}";
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }
}