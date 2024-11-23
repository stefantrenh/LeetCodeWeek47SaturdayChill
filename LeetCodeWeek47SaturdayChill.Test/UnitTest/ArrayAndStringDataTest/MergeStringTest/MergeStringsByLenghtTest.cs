using FluentAssertions;
using LeetCodeWeek47SaturdayChill.Model;
using LeetCodeWeek47SaturdayChill.Domain.Entities;
using Xunit;

namespace LeetCodeWeek47SaturdayChill.Test.UnitTest.ArrayAndStringDataTest.MergeStringTest
{
    /*
     You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1.
    If a string is longer than the other, append the additional letters onto the end of the merged string.
    Return the merged string.

       Example 1: - Done
       
       Input: word1 = "abc", word2 = "pqr"
       Output: "apbqcr"
       Explanation: The merged string will be merged as so:
       word1:  a   b   c
       word2:    p   q   r
       merged: a p b q c r
       
       Example 2: - Done
       
       Input: word1 = "ab", word2 = "pqrs"
       Output: "apbqrs"
       Explanation: Notice that as word2 is longer, "rs" is appended to the end.
       word1:  a   b 
       word2:    p   q   r   s
       merged: a p b q   r   s
       
       Example 3: - Done
       
       Input: word1 = "abcd", word2 = "pq"
       Output: "apbqcd"
       Explanation: Notice that as word1 is longer, "cd" is appended to the end.
       word1:  a   b   c   d
       word2:    p   q 
       merged: a p b q c   d

     */
    public class MergeStringsByLenghtTest
    {
        protected readonly WordsDTO WordsDTO;
        protected readonly MergedWords MergedWords;

        public MergeStringsByLenghtTest(WordsDTO wordsDTO)
        {
            WordsDTO = wordsDTO;
            MergedWords = new MergedWords();
        }
    }


    public class Merged_String_Equal_Lenght_Test : MergeStringsByLenghtTest
    {
        public Merged_String_Equal_Lenght_Test() : base(new WordsDTO { Word1 = "abc", Word2 = "pqr" })
        {
        }

        [Fact]
        public void Should_Merge_Equal_Length_Strings()
        {
            var result = MergedWords.MergeWords(WordsDTO);

            result.MergedWord.Should().BeEquivalentTo("apbqcr");
        }
    }

    public class Merged_String_By_Longest_String_Word1 : MergeStringsByLenghtTest
    {
        public Merged_String_By_Longest_String_Word1() : base(new WordsDTO { Word1 = "ab", Word2 = "pqrs" })
        {
        }

        [Fact]
        public void Should_Merge_Equal_Length_Strings()
        {
            var result = MergedWords.MergeWords(WordsDTO);

            result.MergedWord.Should().BeEquivalentTo("apbqrs");
        }
    }

    public class Merged_String_By_Longest_String_Word2 : MergeStringsByLenghtTest
    {
        public Merged_String_By_Longest_String_Word2() : base(new WordsDTO { Word1 = "abcd", Word2 = "pq" })
        {
        }

        [Fact]
        public void Should_Merge_Equal_Length_Strings()
        {
            var result = MergedWords.MergeWords(WordsDTO);

            result.MergedWord.Should().BeEquivalentTo("apbqcd");
        }
    }






}




