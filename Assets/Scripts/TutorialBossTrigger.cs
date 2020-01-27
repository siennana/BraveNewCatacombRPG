using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialBossTrigger : MonoBehaviour
{
    public GameObject BattleObject;
    public GameObject MainLevel;
    public GameObject player;
    private Vector3 movePlace;
    private Animator anim;
    public float speed;
    public float desireDist = 0;
    private float dist;
    public float range = 1;
    private AnimatorStateInfo attackState;

    public float DesireDist { get => desireDist; set => desireDist = value; }

    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.enabled = true;
    }

    private void Update()
    {
        dist = Vector3.Distance(this.transform.position, player.transform.position);
        if (dist <= desireDist)
        {
            anim.SetFloat("Speed", 0f);

        }
 
        else if (dist <= range && dist > desireDist) {
            anim.SetFloat("Speed", 1);
            this.transform.LookAt(player.transform);
            this.transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, speed);
        }

    }

    public void startBattle()
    {
        StartCoroutine(VillainAttack());
    }

    IEnumerator VillainAttack()
    {
        anim.SetTrigger("Attack");
        yield return new WaitForSeconds(3f);
        MainLevel.SetActive(false);
        BattleObject.SetActive(true);
    }

}
