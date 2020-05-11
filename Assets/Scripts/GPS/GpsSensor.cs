using System;
using UnityEngine;

namespace RosSharp.RosBridgeClient
{
    public class GpsSensor : UnityPublisher<MessageTypes.Sensor.NavSatFix>
    {
        public string FrameId = "gps";
        private MessageTypes.Sensor.NavSatFix message;

        protected override void Start()
        {
            base.Start();
            InitializeMessage();
        }

        private void FixedUpdate()
        {
            UpdateMessage();
        }

        private void InitializeMessage()
        {
            message = new MessageTypes.Sensor.NavSatFix();
            message.header.frame_id = FrameId;
        }

        private void UpdateMessage()
        {
            message.header.Update();
            GetLatitude();
            GetLongitude();
            GetAltitude();
            Publish(message);
        }

        private void GetLatitude()
        {

        }

        private void GetLongitude()
        {

        }

        private void GetAltitude()
        {

        }
    }
}