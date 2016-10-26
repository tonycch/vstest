// Copyright (c) Microsoft. All rights reserved.

namespace SampleUnitTestProject
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The unit test 1.
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// The passing test.
        /// </summary>
        [Priority(2)]
        [TestMethod]
        public void PassingTest()
        {
            Assert.AreEqual(2, 2);
        }

        /// <summary>
        /// The failing test.
        /// </summary>
        [TestCategory("CategoryA")]
        [Priority(3)]
        [TestMethod]
        public void FailingTest()
        {
            Assert.AreEqual(2, 3);
        }

        /// <summary>
        /// The skipping test.
        /// </summary>
        [TestProperty("Property1", "Value1")]
        [Ignore]
        [TestMethod]
        public void SkippingTest()
        {
        }
    }
}
