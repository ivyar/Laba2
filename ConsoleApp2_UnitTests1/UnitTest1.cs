using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp2;

namespace ConsoleApp2_UnitTests1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForTvChangeVolume1()
        {
            var tv = new TV();
            var remote = new Remote(tv);
            var actual = remote.ChangeVolume(+10);
            var expected = 10;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForTvChangeVolume2()
        {
            var tv = new TV();
            var remote = new Remote(tv);
            var actual = remote.ChangeVolume(+150);
            var expected = 100;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForTvChangeVolume3()
        {
            var tv = new TV();
            var remote = new Remote(tv);
            var actual = remote.ChangeVolume(-10);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForTvChannalDown()
        {
            var tv = new TV();
            var remote = new Remote(tv);
            var actual = remote.ChannalDown();
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForTvChannalUp()
        {
            var tv = new TV();
            var remote = new Remote(tv);
            var actual = remote.ChannalUp();
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForRadioChangeVolume1()
        {
            var radio = new Radio();
            var remote = new Remote(radio);
            var actual = remote.ChangeVolume(+10);
            var expected = 10;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForRadioChangeVolume2()
        {
            var radio = new Radio();
            var remote = new Remote(radio);
            var actual = remote.ChangeVolume(+150);
            var expected = 100;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForRadioChangeVolume3()
        {
            var radio = new Radio();
            var remote = new Remote(radio);
            var actual = remote.ChangeVolume(-10);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForRadioChannalDown()
        {
            var radio = new Radio();
            var remote = new Remote(radio);
            var actual = remote.ChannalDown();
            var expected = 99.4;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForRadioChannalUp()
        {
            var radio = new Radio();
            var remote = new Remote(radio);
            var actual = remote.ChannalUp();
            var expected = 100.6;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForExtendedAdvancedRemoteMute()
        {
            var tv = new TV();
            var remote = new ExtendedAdvancedRemote(tv);
            var actual = remote.Mute();
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }
    }
}
