using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    internal class SmartSecurityCamera : SmartDevice
    {
        //fields
        private string resolutionStatus;
        private bool recordingStatus;
        //properties

        public string ResolutionStatus
        {
            get { return resolutionStatus; }
            set { resolutionStatus = value; }
        }
        public bool RecordingStatus
        {
            get { return recordingStatus; }
            set { recordingStatus = value; }
        }
        // constructor

        public SmartSecurityCamera(int smartDeviceID, string smartDeviceName, bool smartDeviceStatus, string resolutionStatus, bool recordingStatus)
            : base(smartDeviceID, smartDeviceName, smartDeviceStatus)
        {

        }

        public void StartRecording()
        {

        }

        public void StopRecording()
        {

        }

        public override void GetStatus()
        {

        }
    }
}
