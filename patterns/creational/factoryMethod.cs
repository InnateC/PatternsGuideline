using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.creational
{
    namespace factory_method
    {
        public abstract class Product
        {
            public string Material { get; private set; }

            public Product(string material) => this.Material = material; 
            
        }

        public class WoodenDoor : Product
        {
            public WoodenDoor() : base("wood") {}
        }

        public class IronDoor : Product
        {
            public IronDoor(): base("iron")
            {

            }
        }

        public abstract class Creator
        {
            public abstract Product Create();
        }

        public class IronDoorCreator : Creator
        {
            public override Product Create()
            {
                return new IronDoor();
            }
        }

        public class WoodenDoorCreator : Creator
        {
            public override Product Create()
            {
                return new WoodenDoor();
            }
        }
    }
}

