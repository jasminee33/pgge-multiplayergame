using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PGGE
{
    public class TPCTopDown : TPCBase
    {
        public TPCTopDown(Transform cameraTransform, Transform playerTransform)
            : base(cameraTransform, playerTransform)
        {
        }

        public override void Update()
        {
            //Q1.consistent naming
            // For topdown camera we do not use the x and z offsets
            Vector3 targetPosition = mPlayerTransform.position;
            targetPosition.y += CameraConstants.CameraPositionOffset.y;

            //making codes more readable
            Vector3 newPosition = Vector3.Lerp(mCameraTransform.position, targetPosition, Time.deltaTime * CameraConstants.Damping);
            mCameraTransform.position = newPosition;
            mCameraTransform.rotation = Quaternion.Euler(90.0f, 0.0f, 0.0f);
        }
    }
}