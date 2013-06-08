namespace Models
{
    public interface IPerson
    {
        string Name { get; set; }
        Alignment Alignment { get; }
        string Gloat();
    }
}