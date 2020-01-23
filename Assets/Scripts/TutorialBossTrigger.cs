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
    private bool played;
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
        if (dist <= desireDist && !played)
        {
            //played = true;
            anim.SetFloat("Speed", 0f);
            //StartCoroutine(VillainAttack());
        }
 
        else if (dist <= 100 && dist > desireDist) {
            anim.SetFloat("Speed", 1);
            this.transform.LookAt(player.transform);
            this.transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, speed);
        }

    }

    IEnumerator VillainAttack()
    {
        anim.SetTrigger("Attack");
        yield return new WaitForSeconds(1f);
        MainLevel.SetActive(false);
        BattleObject.SetActive(true);
    }

}
