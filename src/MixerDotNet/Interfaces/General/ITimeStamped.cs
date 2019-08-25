using MixerDotNet.Models.Base;

namespace MixerDotNet.Interfaces.General
{
    /// <summary>
    /// A type that contains information about creation, update and deletion dates.
    /// </summary>
    public interface ITimeStamped
    {
        TimeStamps TimeStamps { get; }
    }
}
