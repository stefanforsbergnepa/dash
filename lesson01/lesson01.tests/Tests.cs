using System;
using Shouldly;
using Xunit;

namespace lesson01.tests
{
    public class Tests
    {
        [Fact]
        public void FirstTest()
        {
            (3 + 3).ShouldBe(0);
        }

        [Fact]
        public void SecondTest()
        {
            var calculator = new Calculator();
            calculator.Add(4, 5).ShouldBe(9);
        }

        [Fact]
        public void ThirdTest()
        {
            var calculator = new Calculator();

            var numbers = new Numbers();
            numbers.A = 3;
            numbers.B = 4;

            calculator.AddWithClass(numbers).ShouldBe(7);
        }
    }
}
