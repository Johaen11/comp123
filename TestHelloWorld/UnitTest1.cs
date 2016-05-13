using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using comp123;

namespace TestHelloWorld
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { 
            string expect = "Hello world";
            string result = comp123.Program.HelloWorld();
            
           Assert.AreEqual(expect, result);

        }
    }
}
