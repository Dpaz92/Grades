using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariablesHoldReference()
        {
            Gradebook g1 = new Gradebook();
            Gradebook g2 = g1;

            g1 = new Gradebook();
            g1.Name = "Scott's grade book";
            Assert.AreEqual(g1.Name, g2.Name);
        }
        
    }
}
