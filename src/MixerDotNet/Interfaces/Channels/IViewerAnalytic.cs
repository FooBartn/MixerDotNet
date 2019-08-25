namespace MixerDotNet.Interfaces.Channels
{
    public interface IViewerAnalytic : IChannelAnalytic
    {
        ulong Anon { get; }

        ulong Authed { get; }
    }
}
