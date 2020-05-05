using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FoldingAtHome;

namespace FoldingAtHome.Test
{
    public class TeamTest
    {
        [Fact]
        public async void GetTest()
        {
            var team = await Team.Get(264470);

            Assert.NotNull(team);
            Assert.False(string.IsNullOrEmpty(team.Name));
            Assert.True(team.Score > 0);
            Assert.True(team.Donors.Count > 0);
        }


    }
}
