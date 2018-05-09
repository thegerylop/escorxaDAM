using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHelpers.Tests
{
    [TestClass()]
    public class SafataHelperTests
    {

        ClassHelpers.SafataHelper helper = new ClassHelpers.SafataHelper();

        //[TestMethod()]
        //public void EstatSafataTest()
        //{
        //    Assert.Fail();
        //}
        [TestMethod()]
        public void PesSafataFaTest()
        {
            // arrange  
            string TipusSafata = "familiar";
            bool expected = true;
            // act  
            bool actual = helper.PesSafata(TipusSafata);
            // assert  
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void PesSafataEsTest()
        {
            // arrange  
            string TipusSafata = "estalvi";
            bool expected = true;
            // act  
            bool actual = helper.PesSafata(TipusSafata);
            // assert  
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void PesSafataNoTest()
        {
            // arrange  
            string TipusSafata = "normal";
            bool expected = true;
            // act  
            bool actual = helper.PesSafata(TipusSafata);
            // assert  
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void EspectografFaTest()
        {
            // arrange  
            string TipusSafata = "familiar";
            bool expected = true;
            // act  
            bool actual = helper.EstatEspectograf(TipusSafata);
            // assert  
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void EspectograNofTest()
        {
            // arrange  
            string TipusSafata = "normal";
            bool expected = true;
            // act  
            bool actual = helper.EstatEspectograf(TipusSafata);
            // assert  
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void EspectografEsTest()
        {
            // arrange  
            string TipusSafata = "estalvi";
            bool expected = true;
            // act  
            bool actual = helper.EstatEspectograf(TipusSafata);
            // assert  
            Assert.AreEqual(expected, actual);
        }
    }
}