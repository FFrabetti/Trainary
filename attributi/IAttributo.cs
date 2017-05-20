namespace Trainary
{
    public interface IAttributo
    {

        double Valore { get; }
        Units Unita { get; }

        IAttributo Add(IAttributo that); // can throw exceptions
        IAttributo ToStandard();
        // ToString()
    }
}
