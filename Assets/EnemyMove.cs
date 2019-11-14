using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    private Vector3 playerPos;
    private Vector3 moveDir;
    private Vector3 unitVector = new Vector3(1, 1, 1);
    // Start is called before the first frame update

    private void OnTriggerStay(Collider other)
    {
        moveDir = (player.transform.position - enemy.transform.position);
        Debug.Log(moveDir);
        moveDir.Normalize();
        Debug.Log(moveDir);
        enemy.transform.Translate(-moveDir.x, 0f, -moveDir.z);
    }

}

