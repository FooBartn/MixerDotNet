using MixerDotNet.Interfaces.Api;

namespace MixerDotNet.Models.Base
{
    public abstract class MixerApiIncluded
    {
        public IMixerRestApi RestApi { get; internal set; }
    }
}
