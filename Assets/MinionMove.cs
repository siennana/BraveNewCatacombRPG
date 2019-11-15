using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionMove : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    private Vector3 playerPos;
    private Vector3 moveDir;
    private Vector3 unitVector = new Vector3(1, 1, 1);
    private float dist;
    //Start is called before the first frame update
    private void Update()
    {
        dist = Vector3.Distance(enemy.transform.position, player.transform.position);
        if (dist <= 200)
        {
            enemy.transform.LookAt(player.transform);
            moveDir = Vector3.MoveTowards(enemy.transform.position, player.transform.position, 0.7f);
        }
    }
}