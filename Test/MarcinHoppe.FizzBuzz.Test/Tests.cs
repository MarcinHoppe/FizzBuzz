using System;

using Xunit;

namespace MarcinHoppe.FizzBuzz.Test
{
    public class Tests
    {
        [Fact]
        public void One()
        {
            Assert.Equal("1", Problem.SolveUpTo(1));
        }
    }
}
