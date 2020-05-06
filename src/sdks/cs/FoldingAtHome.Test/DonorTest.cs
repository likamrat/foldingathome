using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FoldingAtHome.Test
{
    public class DonorTest
    {
        [Fact]
        public async void GetTest()
        {
            var donor = await Donor.Get("adgroc");

            Assert.NotNull(donor);
            Assert.False(string.IsNullOrEmpty(donor.Name));
            Assert.True(donor.Credit > 0);
            Assert.True(donor.WorkUnits > 0);
        }
    }
}
