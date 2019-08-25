namespace MixerDotNet.Interfaces.Channels
{
    public interface IViewerMetricAnalytic : IChannelAnalytic
    {
        string Country { get; set; }

        string Browser { get; set; }

        string Platform { get; set; }
    }
}
