﻿using System;
using NUnit.Framework;

namespace NUnitTestProject1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestFixture]
    public class NUnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual(5, 5);
        }
    }
}