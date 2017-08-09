using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FindAndReplace.Models;
using System;

namespace FindAndReplace.Tests
{
    [TestClass]
    public class FindAndReplaceTest
    {
      [TestMethod]
      public void FindAndReplace_SetMainArticle_Void()
      {
          //Arrange
          string expected = "hello world";
          //Act
          FindReplace.SetMainArticle("hello world");
          string actual = FindReplace.GetMainArticle();
          //Assert
          Assert.AreEqual(expected, actual);
      }

        [TestMethod]
        public void FindAndReplace_FindWordReplaceWithNewWord_String()
        {
            //Arrange
            string expected = "hello universe";
            FindReplace findReplace = new FindReplace("world", "universe");
            //Act
            string actual = findReplace.FindAndReplace();

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
