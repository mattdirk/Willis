using System;
using Xunit;

namespace UniqueEmailAddresses.Tests
{
    public class UniqueEmailAddressesTests
    {
        [Fact]
        public void Test_A()
        {
            string[] emails = new string[] { "team1@somewhere.com", "team.1+bob@somewhere.com", "team1+jill+bob@somewhere.com" };
            int result = UniqueEmailAddresses.NumberOfUniqueEmailAddresses(emails);
            Assert.Equal(1, result) ;
            emails = new string[] { "team2@somewhere.com", "team2@some.where.com" };
            result = UniqueEmailAddresses.NumberOfUniqueEmailAddresses(emails);
            Assert.Equal(2, result);
        }
    }
}