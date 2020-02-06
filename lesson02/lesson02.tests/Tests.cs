using System;
using Shouldly;
using Xunit;

namespace lesson02.tests
{
    public class Tests
    {
        [Fact]
        public void SayHi()
        {
            var greeter = new Greeter();
            greeter.Hi("hi").ShouldBe("hi");
        }

        [Fact]
        public void SortNumbers()
        {
            var sorter = new Sorter();
            sorter.SortDesc(new int[] {4,5,1,2}).ShouldBe(new int[] {1,2,4,5});
            sorter.SortAsc(new int[] {4,5,1,2}).ShouldBe(new int[] {5,4,2,1});
        }
       
        [Fact]
        public void ConcatStrings()
        {
            var concater = new Concater();
            concater.Concat("We", "are", "the", "robots").ShouldBe("We are the robots");
            concater.ConcatFromArray(new string[]{"We", "are", "the", "robots", "also!"}).ShouldBe("We are the robots also!");
        }

        [Fact]
        public void RoundNumbers()
        {
            var rounder = new Rounder();

            rounder.RoundUp(1.64).ShouldBe(2.00);
            rounder.RoundDown(1.64).ShouldBe(1.00);
            rounder.Round(1.64).ShouldBe(2.00);
        }

        [Fact]
        public void GetOddOrEvenNumbers()
        {
            var oddOrEvenNumbersDeliverer = new OddOrEvenNumbers();
            oddOrEvenNumbersDeliverer.GetOddNumbers(5).ShouldBe(new int[]{1,3,5});
            oddOrEvenNumbersDeliverer.GetEvenNumbers(5).ShouldBe(new int[]{2,4});
        }
        
        [Fact]
        public void GreetRightDependingOnHour()
        {
            // Om klockan är mellan 8 och 12 ska meddelandet vara "Good morning!".
            // Om klockan är mellan 12 och 18 ska meddelandet vara "Good afternoon!".
            // Om klockan är mellan 18 och 24 ska meddelandet vara "Good evening!'.
            // Om klockan är mellan 24 och 8 ska meddelandet vara 'Good night!'.
            var greeter = new Greeter();
            greeter.GreetByHour(9).ShouldBe("Good morning!");
            greeter.GreetByHour(12).ShouldBe("Good afternoon!");
            greeter.GreetByHour(19).ShouldBe("Good evening!");
            greeter.GreetByHour(2).ShouldBe("Good night!");
        }

        [Fact]
        public void ReplaceHyphens()
        {
            var hyphenReplacer = new HyphenReplacer();
            hyphenReplacer.usingFor("Hello-World!").ShouldBe("Hello World!");
            hyphenReplacer.usingWhile("Hello-World-please-be-nice!").ShouldBe("Hello World please be nice!");
        }

        [Fact]
        public void CreateTriangle()
        {
             // Console.WriteLine av den här med base 5 ska se ut såhär
            // #
            // ##
            // ###
            // ####
            // #####
            var triangleCreator = new TriangleCreator();
            triangleCreator.create(5).ShouldBe($"#{Environment.NewLine}##{Environment.NewLine}###{Environment.NewLine}####{Environment.NewLine}#####");
        }  
    }
}
