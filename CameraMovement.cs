using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 2, 0); // Offset for camera position
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        // Update camera position to follow the player with the offset
        Vector3 desiredPosition = player.transform.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // Rotate the camera based on player rotation
        transform.rotation = Quaternion.Lerp(transform.rotation, player.transform.rotation, smoothSpeed);
    }
}
