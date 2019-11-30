using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobScript : MonoBehaviour
{
    public getDamage lose;
    public GameObject player;
    private Vector3 startPosition;
    private Vector3 attackPosition;
    public GameObject menuItems;
    public GameObject attackItems;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = this.transform.position;
        attackPosition = (player.transform.position + startPosition);
    }

    public void AttackAction()
    {
        menuItems.SetActive(false);
        attackItems.SetActive(false);
        StartCoroutine(VillainAttack());

    }

    IEnumerator VillainAttack()
    {
        yield return new WaitForSeconds(1.5f);
        this.transform.position = attackPosition;
        yield return new WaitForSeconds(1f);
        this.transform.position = startPosition;
        lose.RunWin();
    }
}
