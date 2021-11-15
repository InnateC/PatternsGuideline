using Microsoft.VisualStudio.TestTools.UnitTesting;
using patterns.creational.factory_method;
using patterns.creational.prototype;
using patterns.creational.singleton;
using patterns.creational.builder;

namespace IntegrationTests
{
    [TestClass]
    public class CreationalTests
    {
        [TestMethod]
        public void FactoryMethodTest()
        {
            Creator woodenDoorCreator = new WoodenDoorCreator();
            Product woodenDoor = woodenDoorCreator.Create();

            Creator ironDoorCreator = new IronDoorCreator();
            Product ironDoor = ironDoorCreator.Create();

            Assert.IsNotNull(woodenDoor);
            Assert.IsNotNull(ironDoor);

            Assert.AreEqual(woodenDoor.Material, "wood");
            Assert.AreEqual(ironDoor.Material, "iron");

        }

        [TestMethod]
        public void SingletonTest()
        {
            
            string serverName = "UDP";
            var server = Singleton.getInstance(serverName);

            Assert.AreEqual(server.Name, serverName);

            serverName = "TCP";
            server = Singleton.getInstance(serverName);

            Assert.AreNotEqual(server.Name, serverName);
            Assert.IsInstanceOfType(server, typeof(Singleton));



        }

        [TestMethod]
        public void prototypeTest()
        {
            var circle = new Circle(25);
            var cloned = circle.Clone();

            Assert.IsNotNull(cloned);
            Assert.AreNotSame(cloned, circle);

            var rect = new Rectangle(24, 12);
            cloned = rect.Clone();

            Assert.IsNotInstanceOfType(cloned, typeof(Circle));
            Assert.IsInstanceOfType(cloned, typeof(Rectangle));
            Assert.AreNotSame(cloned, rect);

        }

        [TestMethod]
        public void builderTest()
        {
            Bartender bartender = new Bartender();
            IBuilder builder = new GreenTeaBuilder();
            Drink tea = bartender.Prepare(builder);

            Assert.AreEqual(tea.TeaLeaves, TeaLeaves.Green);

            builder = new BlackTeaBuilder();
            Drink blackTea = bartender.Prepare(builder);

            Assert.AreEqual(blackTea.TeaLeaves, TeaLeaves.Black);



        }
    }
}
