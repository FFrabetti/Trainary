namespace Trainary
{
    interface IMeasureConverter
    {
        Units Unita { get;  }

        double Convert(double value);
        double Revert(double value);
    }
}
