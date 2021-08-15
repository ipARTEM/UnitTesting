using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTestContextSamples
{
    [TestClass]
    public class MyTestSample
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void TestMethod1()
        {
            TestContext.WriteLine("TestRunDirectory {0}", TestContext.TestRunDirectory);

            TestContext.WriteLine("TestName {0}", TestContext.TestName);

            TestContext.WriteLine("CurrentTextOutcome {0}", TestContext.CurrentTestOutcome);


        }

        [TestCleanup]
        public void CleanUp()
        {
            TestContext.WriteLine("TestName (CleanUp) {0}", TestContext.TestName);
            TestContext.WriteLine("CurrentTestOutcome (Cleanup) {0}", TestContext.CurrentTestOutcome);
        }
    }
}
