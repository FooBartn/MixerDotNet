using FluentAssertions;
using MixerDotNet.Models.Users;
using Newtonsoft.Json;
using System.Collections.Generic;
using Xunit;

namespace MixerDotNet.UnitTests
{
    public class AchievementJsonTests
    {
        [Fact]
        public void ShouldReturn_Valid_Achievements()
        {
            var content = TestTools.GetJsonResource("Achievements");
            var achievements = JsonConvert.DeserializeObject<IReadOnlyCollection<Achievement>>(content);

            achievements.Count.Should().Be(4);
        }

        [Fact]
        public void ShouldReturn_Valid_Achievement()
        {
            var content = TestTools.GetJsonResource("Achievement");
            var achievement = JsonConvert.DeserializeObject<Achievement>(content);
            var expectedAchievement = new Achievement
            {
                Slug = "alpha-user",
                Name = "Alpha",
                Description = "Be a part of Beam's Alpha testing phase.",
                Sparks = 0
            };

            achievement.Should().BeEquivalentTo(expectedAchievement);
        }
    }
}