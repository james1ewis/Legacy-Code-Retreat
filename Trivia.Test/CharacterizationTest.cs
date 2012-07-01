using ApprovalTests;
using ApprovalTests.Reporters;
using ApprovalUtilities.SimpleLogger;
using NUnit.Framework;
using System;

namespace Trivia.Test
{
    [TestFixture]
    [UseReporter(typeof(WinMergeReporter))]
    public class CharacterizationTest
    {
        [Test]
        public void TestExistingBehaviour()
        {
            var log = Logger.LogToStringBuilder();
            GameRunner.Main2(new Random(0));
            GameRunner.Main2(new Random(10));
            GameRunner.Main2(new Random(11));
            GameRunner.Main2(new Random(16));
            Approvals.Verify(log); //    maybe try approvals.approve...
        }
    }
}
