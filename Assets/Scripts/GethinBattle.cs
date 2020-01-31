using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GethinBattle : MonoBehaviour
{
    public getDamage endGame;
    private Animator anim;
    public GameObject menuItems;
    public GameObject attackItems;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.enabled = true;
    }

    public void AttackAction()
    {
        menuItems.SetActive(false);
        attackItems.SetActive(false);
        StartCoroutine(VillainAttack());

    }

    IEnumerator VillainAttack()
    {
        yield return new WaitForSeconds(0.5f);
        anim.Play("SwordAttack");
        yield return new WaitForSeconds(1.7f);
        endGame.RunToBe();
    }
}
