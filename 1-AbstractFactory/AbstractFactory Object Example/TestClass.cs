using System.Collections.Generic;
using AbstractFactory_Object_Example.Interfaces;
using AbstractFactory_Object_Example.Models.Devices;

namespace AbstractFactory_Object_Example
{
    class TestClass
    {
        private List<IElectronics> DeviceType = new List<IElectronics>();

        public void GenerateDevices()
        {
            #region Sample Single Initialization
            IElectronics Device1 = new Portable
            {
                Type = "Portable",
                Name = "ThinkPad X1",
                Company = "Lenovo"
            };
            IElectronics Device2 = new Computer
            {
                Type = "Computer",
                Name = "Mark 1.5x",
                Company = "Dell"
            };

            IElectronics Device3 = new Computer
            {
                Type = "Console",
                Name = "Playstation 4",
                Company = "Sony"
            };
            DeviceType.Add(Device1);
            DeviceType.Add(Device2);
            DeviceType.Add(Device3);

            #endregion

            #region Sample Group Initialization
            /* for (int i = 2; i < 100; i++)
             {
                 if (i % 2 == 0)
                 {
                     Studentet.Add(new Computer
                     {
                         Type = "Master",
                         Name = "St" + i.ToString() + "Name",
                         Surname = "St" + i.ToString() + "Surname"
                     }); ; ;
                 }
                 else
                 {
                     Studentet.Add(new Laptop
                     {
                         Type = "Bachelor",
                         Name = "St" + i.ToString() + "Name",
                         Surname = "St" + i.ToString() + "Surname"
                     });
                 }
             }*/
            #endregion
        }

        public List<IElectronics> ReturnDevices()
        {
            return this.DeviceType;
        }
    }
}
