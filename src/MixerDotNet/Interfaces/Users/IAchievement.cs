namespace MixerDotNet.Interfaces.Users
{
    public interface IAchievement
    {
        string Slug { get; }

        string Name { get; }

        string Description { get; }

        ulong Sparks { get; }
    }
}
