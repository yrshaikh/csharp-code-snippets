using NUnit.Framework;
using Shouldly;
using Snippets.Core.Extensions;

namespace Snippets.UnitTests.Extensions
{
    [TestFixture]
    public class StringExtensionsTest
    {
        [Test]
        [TestCase("hello", 5)]
        [TestCase("good morning", 12)]
        public void AppendZzz_ShouldWorkCorrectly(string input, int expectedWordCount)
        {
            input.GetWordCount().ShouldBe(expectedWordCount);
        }
    }
}