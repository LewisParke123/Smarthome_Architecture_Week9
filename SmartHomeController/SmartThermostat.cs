using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    internal class SmartThermostat : SmartDevice
    {
        // private fields

        private double currentTemp;
        private double targetTemp;

        // public properties

        public double CurrentTemp
        {
            get { return currentTemp; }
            set { currentTemp = value; }
        }

        public double TargetTemp
        {
            get { return targetTemp; }
            set { targetTemp = value; }
        }

        // constructors

        public SmartThermostat(int smartDeviceID, string smartDeviceName, bool smartDeviceStatus, double currentTemp, double targetTemp)
            : base(smartDeviceID, smartDeviceName, smartDeviceStatus)
        {
            CurrentTemp = currentTemp;
            TargetTemp = targetTemp;
        }

        public void SetTemperature()
        {
        }

        public void SetCurrentTemperature()
        {
        }

        public override void GetStatus()
        {

        }
    }
}
