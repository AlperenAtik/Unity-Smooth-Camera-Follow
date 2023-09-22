using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{

    public Transform target; // Object the camera will follow
    public float smoothTime = 0.3f; // Camera follow speed
    public Vector3 offset; // Distance between camera and target

    private Vector3 velocity = Vector3.zero;

    private void LateUpdate()
    {
        // Calculate target position
        Vector3 targetPosition = target.position + offset;

        // Smooth Follow
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
