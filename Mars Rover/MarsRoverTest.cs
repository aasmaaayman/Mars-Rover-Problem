using System;
using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTest
{
    [TestClass]
    public class MarsRoverTest
    {
        [TestMethod]
        public void TestScanrio_42E_FLFFFRFLB()
        {
            position pos = new position();
            pos.Coord.x = 4;
            pos.Coord.y = 2;
            pos.Direction = Directions.E;
            var moves = "FLFFFRFLB";
            pos.StartMoving(moves);
            var actualOutput = pos.Coord.x +" "+pos.Coord.y+" "+pos.Direction.ToString();
            var expectedOutput = "6 4 N";
            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [TestMethod]
        public void TestScanrio_12N_LFLFLFLFF()
        {
            position pos = new position();
            pos.Coord.x = 1;
            pos.Coord.y = 2;
            pos.Direction = Directions.N;
            var moves = "LFLFLFLFF";
            pos.StartMoving(moves);
            var actualOutput = pos.command_string + " " + pos.Coord.x + " " + pos.Coord.y + " " + pos.Direction.ToString();
            var expectedOutput = "LFLFLFLFF 1 3 N";
            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [TestMethod]
        public void TestScanrio_34W_FBBLFR()
        {
            position pos = new position();
            pos.Coord.x = 3;
            pos.Coord.y = 4;
            pos.Direction = Directions.W;
            var moves = "FBBLFR";
            pos.StartMoving(moves);
            var actualOutput = pos.command_string + " " + pos.Coord.x + " " + pos.Coord.y + " " + pos.Direction.ToString();
            var expectedOutput = "FBBLFR 4 3 W";
            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [TestMethod]
        public void TestScanrio_33E_FRRFFRFRRF()
        {
            position pos = new position();
            pos.Coord.x = 3;
            pos.Coord.y = 3;
            pos.Direction = Directions.E;
            var moves = "FRRFFRFRRF";
            pos.StartMoving(moves);
            var actualOutput = pos.command_string + " " + pos.Coord.x + " " + pos.Coord.y + " " + pos.Direction.ToString();
            var expectedOutput = "FRRFFRFRRF 2 3 S";
            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [TestMethod]
        public void TestScanrio_73S_FRLFFRFLLF()
        {
            position pos = new position();
            pos.Coord.x = 7;
            pos.Coord.y = 3;
            pos.Direction = Directions.S;
            var moves = "FRLFFRFLLF";
            pos.StartMoving(moves);
            var actualOutput = pos.command_string + " " + pos.Coord.x + " " + pos.Coord.y + " " + pos.Direction.ToString();
            var expectedOutput = "FRLFFRFLLF 7 0 E";
            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [TestMethod]
        public void TestScanrio_13N_FBBLFRLLB()
        {
            position pos = new position();
            pos.Coord.x = 1;
            pos.Coord.y = 3;
            pos.Direction = Directions.N;
            var moves = "FBBLFRLLB";
            pos.StartMoving(moves);
            var actualOutput = pos.command_string + " " + pos.Coord.x + " " + pos.Coord.y + " " + pos.Direction.ToString();
            var expectedOutput = "BBBLFRLLB 0 1 S";
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
