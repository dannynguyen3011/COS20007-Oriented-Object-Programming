using SwinAdventure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class TestMove
    { 
            Move _moveCommand;
            Player _testPlayer;
            Location _testRoom1;
            Location _testRoom2;
            SwinAdventure.Path _testPath;

            [Test]
            public void PlayerMoveTest()
            {
                _moveCommand = new Move();
                _testPlayer = new Player("MD", "The mighty programmer!");

                _testRoom1 = new Location(new string[] { "Room 1" }, "Room 1", "the first room");
                _testRoom2 = new Location(new string[] { "Room 2" }, "Room 2", "the second room");

                _testPlayer.Location = _testRoom1;
                _testPath = new SwinAdventure.Path(new string[] { "north" }, "Door", "A test door", _testRoom1, _testRoom1);
                _testRoom1.AddPath(_testPath);
                string result = _moveCommand.Excecute(_testPlayer, new string[] { "move", "north" });

                Assert.AreEqual(_testPlayer.Location, _testPath.Destination);
                Assert.AreEqual(result, "You have moved north through a Door to the Room 1.\r\n\nYou are standing at Room 1, the first room. At here, you can see:\n");
            }



            [Test]
            public void WrongPathTest()
            {
                _moveCommand = new Move();
                _testPlayer = new Player("MD", "The mighty programmer!");

                _testRoom1 = new Location(new string[] { "Room 1" }, "Room 1", "the first room");
                _testRoom2 = new Location(new string[] { "Room 2" }, "Room 2", "the second room");
                _testPlayer.Location = _testRoom1;
                _testPath = new SwinAdventure.Path(new string[] { "north" }, "Door", "A test door", _testRoom1, _testRoom2);
                _testRoom1.AddPath(_testPath);

                Assert.AreEqual(_moveCommand.Excecute(_testPlayer, new string[] { "move", "south" }), "Error in input");
                Assert.AreNotEqual(_testPlayer.Location, _testRoom2);
            }
        }
    }
