using System;
using Shouldly;
using Xunit;
using System.Collections.Generic;

namespace lesson04.tests
{
    public class Tests
    {
        [Fact]
        public void NumberedRows1()
        {
            var pyramid = new Pyramid();
            var result = pyramid.NumberedRows1(5);

            var expected = 
@"
1
22
333
4444
55555";

            result.ShouldBe(expected);
        }

        [Fact]
        public void NumberedRows2()
        {
            var pyramid = new Pyramid();
            var result = pyramid.NumberedRows2(5);

            var expected = 
@"
1
23
456
78910
1112131415";

            result.ShouldBe(expected);
        }

        [Fact]
        public void Flipped()
        {
            var pyramid = new Pyramid();
            var result = pyramid.Flipped(5);

            var expected = 
@"
    1
   22
  333
 4444
55555";

            result.ShouldBe(expected);
        }
    }
}