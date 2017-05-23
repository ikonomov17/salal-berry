namespace Main_Program
{
    public interface IHero
    {
        int Age { get; }
        Gender Gender { get; }
        Size Size { get; }

        string GetFields();
        void InitialInformation();
    }
}