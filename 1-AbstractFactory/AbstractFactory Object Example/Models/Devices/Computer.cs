using AbstractFactory_Object_Example.Models.Devices.Abstract;

namespace AbstractFactory_Object_Example.Models.Devices
{
    class Computer : DeviceType
    {
        private string _Type = "";

        public override string Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                if (value == "Computer") 
                this._Type = value; 
                else
                {
                   //throw error 
                }
            }
        }

    }
}
