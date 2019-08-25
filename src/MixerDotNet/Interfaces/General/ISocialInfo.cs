using System;

namespace MixerDotNet.Interfaces.General
{
    public interface ISocialInfo
    {
        Uri Twitter { get; }

        Uri Facebook { get; }

        Uri Youtube { get; }

        Uri Player { get; }

        Uri Discord { get; }

        string[] Verified { get; }
    }
}
