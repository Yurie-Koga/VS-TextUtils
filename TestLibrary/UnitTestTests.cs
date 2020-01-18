using Xunit;
using TextUtils;
using System.Diagnostics;

namespace TestLibrary
{
    public class TextUtils_GetWordCountShould
    {
        [Fact]
        public void IgnoreCasing()
        {
            var wordCount = WordCount.GetWordCount("Jack", "Jack jack");

            Assert.Equal(2, wordCount);
        }

        [Theory]
        [InlineData(0, "Ting", "Does not appear in the string.")]
        [InlineData(1, "Ting", "Ting appears once.")]
        [InlineData(2, "Ting", "Ting appears twice with Ting.")]
        [InlineData(3, "Devile", "Devile appears three times with Devile and Devile.")]
        public void CountInstancesCorrectly(int count,
                                    string searchWord,
                                    string inputString)
        {
            Assert.Equal(count, WordCount.GetWordCount(searchWord,
                                                       inputString));
        }
    }
}