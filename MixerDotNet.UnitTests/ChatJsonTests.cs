using FluentAssertions;
using MixerDotNet.Models;
using MixerDotNet.Models.Chats;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MixerDotNet.UnitTests
{
    public class ChatJsonTests
    {
        [Fact]
        public void ShouldReturn_Valid_ChatConnectionInfo()
        {
            var content = TestTools.GetJsonResource("ChatConnectionInfo");
            var chatInfo = JsonConvert.DeserializeObject<ChatConnectionInfo>(content);

            var expectedInfo = new ChatConnectionInfo
            {
                Authkey = "AGo9U7nEmbB3CKEx",
                Endpoints = new string[]
                {
                    "wss://chat.mixer.com:443"
                },
                IsLoadShed = false,
                Permissions = new string[]
                {
                    "chat",
                    "connect"
                },
                Roles = new List<Enums.ChatRole>
                {
                    Enums.ChatRole.User
                }
            };

            chatInfo.Should().BeEquivalentTo(expectedInfo);
        }
    }
}
