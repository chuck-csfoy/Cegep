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
    public class CardCellTests
    {
        private void MakeSureThisMethodCompiles()
        {
            CardCell cell = new CardCell(7);

            int value = cell.Value;
            bool isMarked = cell.IsMarked;
            cell.MarkCell(7);
        }

        
    }
}