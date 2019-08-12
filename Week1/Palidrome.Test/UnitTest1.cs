using System;
using Xunit;
using Palidrome.Logic;

namespace Palidrome.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
          var newPalindrome1 = new Class1("civic");
          var expected1 = true;
          var actual = newPalindrome1.findPlain();
          Assert.True(expected1 == actual);


        }
    }
}
