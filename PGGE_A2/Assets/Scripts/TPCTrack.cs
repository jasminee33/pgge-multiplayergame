using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PGGE
{
    public class TPCTrack : TPCBase
    {
        public TPCTrack(Transform cameraTransform, Transform playerTransform)
            : base(cameraTransform, playerTransform)
        {
        }

        public override void Update()
        {
            //Q1-Extraction Method
            //ref: https://refactoring.guru/extract-method
            Track(); //calls function
        }

        //Encapulation- privated function
        private void Track()
        {
            Vector3 targetPosition = mPlayerTransform.position;
            targetPosition.y += CameraConstants.CameraPositionOffset.y;

            // Use LookAt to track player
            mCameraTransform.LookAt(targetPosition);
        }
    }
}