using System;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private UnityEngine.Vector3 offset = new UnityEngine.Vector3(0f, 0f, -10f);
    private float smoothTime = 0.25f;
    private UnityEngine.Vector3 velocity = UnityEngine.Vector3.zero;

    [SerializeField] private Transform target;

    // Update is called once per frame
    private void Update()
    {
        UnityEngine.Vector3 targetPosition = target.position + offset;
        transform.position = UnityEngine.Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
