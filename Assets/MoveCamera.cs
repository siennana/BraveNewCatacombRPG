using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject Player;
    public Vector3 offset;
    public Vector3 playerRotation;

    void Start()
    {
        offset = transform.position - Player.transform.position;
    }

 
    void LateUpdate()
    {
        //transform.rotation = transform.rotation* Quaternion.AngleAxis(Player.transform.rotation.y, Vector3.up);
        transform.position = Player.transform.position + offset;

    }
}
