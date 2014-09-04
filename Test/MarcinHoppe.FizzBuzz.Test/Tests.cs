using System;
using System.Collections.Generic;

using Xunit;

namespace MarcinHoppe.FizzBuzz.Test
{
    public class Tests
    {
        private IEnumerable<string> Sequence(params string[] strings)
        {
            foreach (var s in strings)
            {
                yield return s;
            }
        }

        [Fact]
        public void One()
        {
            Assert.Equal(
                Sequence("1"), 
                Problem.SolveUpTo(1));
        }

        [Fact]
        public void Two()
        {
            Assert.Equal(
                Sequence("1", "2"), 
                Problem.SolveUpTo(2));
        }

        [Fact]
        public void ThreeShouldPrintFizz()
        {
            Assert.Equal(
                Sequence("1", "2", "Fizz"), 
                Problem.SolveUpTo(3));
        }

        [Fact]
        public void FiveShouldPrintBuzz()
        {
            Assert.Equal(
                Sequence("1", "2", "Fizz", "4", "Buzz"), 
                Problem.SolveUpTo(5));
        }

        [Fact]
        public void FifteenShouldPrintFizzBuzz()
        {
            Assert.Equal(
                Sequence("1", "2", "Fizz", "4", "Buzz",
                         "Fizz", "7", "8", "Fizz", "Buzz",
                         "11", "Fizz", "13", "14", "FizzBuzz"),
                Problem.SolveUpTo(15));
        }
    }
}
