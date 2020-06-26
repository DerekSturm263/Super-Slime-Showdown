using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] [Tooltip("The GameObject that the camera follows.")] private GameObject target = null;
    [SerializeField] [Tooltip("How fast the camera follows the target. Set to 0 to remove lerping.")] private float followSpeed = 1f;
    private float cameraDistance;

    private void Awake()
    {
        cameraDistance = transform.position.z;
    }

    private void FixedUpdate()
    {
        if (followSpeed != 0)
            transform.position = Vector3.Lerp(transform.position, target.transform.position + new Vector3(0, 0, cameraDistance), followSpeed * Time.deltaTime);
        else
            transform.position = target.transform.position - new Vector3(0, 0, cameraDistance);
    }
}
