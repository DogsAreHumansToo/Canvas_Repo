using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGameFollow : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public float yOffset = 1f;

    public Transform targert;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(targert.position.x, targert.position.y + yOffset, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
    }
}
