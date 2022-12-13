using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4_DaniyalRaza
{
    [TestClass]

    public class ScenarioA_Q1
    {
        [TestMethod]
        [DataRow(new[] { 1, 2, 3, 4, 5, 5 },new[] {3,6,8,9},new[] { 1, 2, 3, 4 })]
        public void Verify_Sum()
        {
            
        }
    }
}
