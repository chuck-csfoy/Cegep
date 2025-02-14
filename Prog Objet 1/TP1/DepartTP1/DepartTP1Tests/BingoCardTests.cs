using DepartTP1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolutionTP1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionTP1.Tests
{
    [TestClass()]
    public class BingoCardTests
    {
        private void MakeSureThisMethodCompiles()
        {
            NumberGenerator generator = new NumberGenerator();
            BingoCard card = new BingoCard(5, generator);
            card.MarkNumber(3);
            int score = card.ComputeScore();
        }

        /*
         * Placez vos tests ici
         */
    }
}