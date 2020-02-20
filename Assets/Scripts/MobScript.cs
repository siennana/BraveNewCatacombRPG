using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobScript : MonoBehaviour
{
    public getDamage lose;
    public GameObject player;
    public Slider EnemyHealth;
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
        if(EnemyHealth.value > 0f)
        {
            StartCoroutine(VillainAttack());
        }


    }

    IEnumerator VillainAttack()
    {
        yield return new WaitForSeconds(1.5f);
        this.transform.position = attackPosition;
        yield return new WaitForSeconds(1f);
        this.transform.position = startPosition;
        menuItems.SetActive(true);
        lose.DmgPlayer();
        //lose.RunWin();
    }
}
