using FluentAssertions;
using Microsoft.Extensions.Logging;
using MixerDotNet.Clients;
using MixerDotNet.Interfaces.Clients;
using MixerDotNet.Models.Oauth;
using MixerDotNet.RestApi;
using Moq;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace MixerDotNet.UnitTests
{
    public class ScopeTests
    {
        [Fact]
        public void ShouldReturn_Valid_CompoundScopes()
        {
            CompoundScopes.SuperUser.Count().Should().Be(57);
            CompoundScopes.BypassRules.Count().Should().Be(4);
        }

        [Fact]
        public async Task ShouldReturn_Valid_AuthUrlWithScopes()
        {
            var credentials = new MixerCredentials("MyClientId", "https://localhost.com", "MyState");
            var mockFactory = new Mock<IHttpClientFactory>();
            var mockClientLogger = new Mock<ILogger<BaseHttpClient>>();
            var mockPolicyProvider = new Mock<IPolicyProvider>();

            var client = new BaseHttpClient(mockFactory.Object, mockPolicyProvider.Object, mockClientLogger.Object);
            client.Initialize(credentials);
            var url = await client.GetAuthorizeUrlAsync(CompoundScopes.SuperUser);
            url.Should().Contain("state=MyState");
            url.Should().Contain("client_id=MyClientId");
            url.Should().Contain("redirect_uri=https%3A%2F%2Flocalhost.com");
            url.Should().Contain("response_type=code");
            url.Should().Contain("scope=user%3Aact_as+achievement%3Aview%3Aself+channel%3Aanalytics%3Aself+channel%3Aclip%3Acreate%3Aself+channel%3Aclip%3Adelete%3Aself+channel%3Acostream%3Aself+channel%3AdeleteBanner%3Aself+channel%3Adetails%3Aself+channel%3Afollow%3Aself+channel%3AstreamKey%3Aself+channel%3Ateststream%3Aview%3Aself+channel%3Aupdate%3Aself+chat%3Abypass_catbot+chat%3Abypass_filter+chat%3Abypass_links+chat%3Abypass_slowchat+chat%3Acancel_skill+chat%3Achange_ban+chat%3Achange_role+chat%3Achat+chat%3Aclear_messages+chat%3Aconnect+chat%3Aedit_options+chat%3Agiveaway_start+chat%3Apoll_start+chat%3Apoll_vote+chat%3Apurge+chat%3Aremove_message+chat%3Atimeout+chat%3Aview_deleted+chat%3Awhisper+delve%3Aview%3Aself+interactive%3Amanage%3Aself+interactive%3Arobot%3Aself+invoice%3Aview%3Aself+log%3Aview%3Aself+oauth%3Amanage%3Aself+recording%3Amanage%3Aself+redeemable%3Acreate%3Aself+redeemable%3Aredeem%3Aself+redeemable%3Aview%3Aself+resource%3Afind%3Aself+subscription%3Acancel%3Aself+subscription%3Acreate%3Aself+subscription%3Arenew%3Aself+subscription%3Aview%3Aself+team%3Amanage%3Aself+transaction%3Acancel%3Aself+transaction%3Aview%3Aself+user%3Aanalytics%3Aself+user%3Adetails%3Aself+user%3AgetDiscordInvite%3Aself+user%3Alog%3Aself+user%3Anotification%3Aself+user%3Aseen%3Aself+user%3Aupdate%3Aself+user%3AupdatePassword%3Aself");
        }
    }
}
