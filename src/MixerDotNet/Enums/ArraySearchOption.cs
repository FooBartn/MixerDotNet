using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MixerDotNet.Enums
{
    public enum ArraySearchOption
    {
        [EnumMember(Value = "in")]
        Contains,

        [EnumMember(Value = "notin")]
        DoesNotContain
    }
}
