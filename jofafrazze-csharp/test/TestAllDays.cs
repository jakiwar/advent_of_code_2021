using Xunit;

namespace test
{
    public class Input
    {
        public static readonly string actual = "input.txt";
        public static readonly string example = "example.txt";
    }

    public class TestDay01
    {
        [Fact]
        public void ExampleA() => Assert.Equal(7, aoc.Day01.PartA(Input.example));
        [Fact]
        public void TestA() => Assert.Equal(1301, aoc.Day01.PartA(Input.actual));
        [Fact]
        public void ExampleB() => Assert.Equal(5, aoc.Day01.PartB(Input.example));
        [Fact]
        public void TestB() => Assert.Equal(1346, aoc.Day01.PartB(Input.actual));
    }

    public class TestDay02
    {
        [Fact]
        public void ExampleA() => Assert.Equal(150, aoc.Day02.PartA(Input.example));
        [Fact]
        public void TestA() => Assert.Equal(1727835, aoc.Day02.PartA(Input.actual));
        [Fact]
        public void ExampleB() => Assert.Equal(900, aoc.Day02.PartB(Input.example));
        [Fact]
        public void TestB() => Assert.Equal(1544000595, aoc.Day02.PartB(Input.actual));
    }

    public class TestDay03
    {
        [Fact]
        public void ExampleA() => Assert.Equal(198, aoc.Day03.PartA(Input.example));
        [Fact]
        public void TestA() => Assert.Equal(2261546, aoc.Day03.PartA(Input.actual));
        [Fact]
        public void ExampleB() => Assert.Equal(230, aoc.Day03.PartB(Input.example));
        [Fact]
        public void TestB() => Assert.Equal(6775520, aoc.Day03.PartB(Input.actual));
    }

    public class TestDay04
    {
        [Fact]
        public void ExampleA() => Assert.Equal(4512, aoc.Day04.PartA(Input.example));
        [Fact]
        public void TestA() => Assert.Equal(29440, aoc.Day04.PartA(Input.actual));
        [Fact]
        public void ExampleB() => Assert.Equal(1924, aoc.Day04.PartB(Input.example));
        [Fact]
        public void TestB() => Assert.Equal(13884, aoc.Day04.PartB(Input.actual));
    }

    public class TestDay05
    {
        [Fact]
        public void ExampleA() => Assert.Equal(5, aoc.Day05.PartA(Input.example));
        [Fact]
        public void TestA() => Assert.Equal(6113, aoc.Day05.PartA(Input.actual));
        [Fact]
        public void ExampleB() => Assert.Equal(12, aoc.Day05.PartB(Input.example));
        [Fact]
        public void TestB() => Assert.Equal(20373, aoc.Day05.PartB(Input.actual));
    }

    public class TestDay06
    {
        [Fact]
        public void ExampleA() => Assert.Equal(5934L, aoc.Day06.PartA(Input.example));
        [Fact]
        public void TestA() => Assert.Equal(393019L, aoc.Day06.PartA(Input.actual));
        [Fact]
        public void ExampleB() => Assert.Equal(26984457539, aoc.Day06.PartB(Input.example));
        [Fact]
        public void TestB() => Assert.Equal(1757714216975, aoc.Day06.PartB(Input.actual));
    }

    public class TestDay07
    {
        [Fact]
        public void ExampleA() => Assert.Equal(37, aoc.Day07.PartA(Input.example));
        [Fact]
        public void TestA() => Assert.Equal(348664, aoc.Day07.PartA(Input.actual));
        [Fact]
        public void ExampleB() => Assert.Equal(168, aoc.Day07.PartB(Input.example));
        [Fact]
        public void TestB() => Assert.Equal(100220525, aoc.Day07.PartB(Input.actual));
    }

    public class TestDay08
    {
        [Fact]
        public void ExampleA() => Assert.Equal(26, aoc.Day08.PartA(Input.example));
        [Fact]
        public void TestA() => Assert.Equal(416, aoc.Day08.PartA(Input.actual));
        [Fact]
        public void ExampleB() => Assert.Equal(61229, aoc.Day08.PartB(Input.example));
        [Fact]
        public void TestB() => Assert.Equal(1043697, aoc.Day08.PartB(Input.actual));
    }

    public class TestDay09
    {
        [Fact]
        public void ExampleA() => Assert.Equal(15, aoc.Day09.PartA(Input.example));
        [Fact]
        public void TestA() => Assert.Equal(448, aoc.Day09.PartA(Input.actual));
        [Fact]
        public void ExampleB() => Assert.Equal(1134, aoc.Day09.PartB(Input.example));
        [Fact]
        public void TestB() => Assert.Equal(1417248, aoc.Day09.PartB(Input.actual));
    }

    public class TestDay10
    {
        [Fact]
        public void ExampleA() => Assert.Equal(26397, aoc.Day10.PartA(Input.example));
        [Fact]
        public void TestA() => Assert.Equal(390993, aoc.Day10.PartA(Input.actual));
        [Fact]
        public void ExampleB() => Assert.Equal(288957L, aoc.Day10.PartB(Input.example));
        [Fact]
        public void TestB() => Assert.Equal(2391385187L, aoc.Day10.PartB(Input.actual));
    }

    public class TestDay11
    {
        [Fact]
        public void ExampleA() => Assert.Equal(1656, aoc.Day11.PartA(Input.example));
        [Fact]
        public void TestA() => Assert.Equal(1599, aoc.Day11.PartA(Input.actual));
        [Fact]
        public void ExampleB() => Assert.Equal(195, aoc.Day11.PartB(Input.example));
        [Fact]
        public void TestB() => Assert.Equal(418, aoc.Day11.PartB(Input.actual));
    }
}
