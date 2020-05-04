using AbstractFactory_Object_Example.Interfaces;
using System;

namespace AbstractFactory_Object_Example.Models.Devices.Abstract
{
    abstract class DeviceType : Interfaces.IElectronics
    {
        private String _Name = "";
        private String _Company = "";
        public virtual string Type { get; set; }//virtual property to be overriden which contains disticnt behaviour

        //Common behaviour for the distinct models

        #region Common Behaviour 
            public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
            }
        } 
            public string Company
        {
            get
            {
                return this._Company;
            }
            set
            {
                this._Company = value;
            }
        }
        #endregion

    }
}
