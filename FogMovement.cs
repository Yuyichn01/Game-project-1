using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogMovement : MonoBehaviour
{
    //the speed to scroll of fog
    public float ScrollSpeed;
    //The distance of respawn
    public int RespawnDistance;

    //the start position of the object
    public Vector2 RespawnPosition;

    // Update is called once per frame
    void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * -ScrollSpeed, RespawnDistance);
        transform.position = RespawnPosition + Vector2.right * newPosition;
    }
}
