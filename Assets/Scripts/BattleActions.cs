using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleActions : MonoBehaviour
{
    public getDamage dmg;
    private float verticalVelocity;
    private float gravity = 14.0f;
    private Vector3 startPosition;
    private Vector3 attackPosition;
    private CharacterController controller;
    private Animator anim;
    private Vector3 moveVector;
    private Vector3 gravityVector;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        transform.position = new Vector3(transform.position.x, Terrain.activeTerrain.SampleHeight(transform.position), transform.position.z);
        startPosition = transform.position;
        attackPosition = (enemy.transform.position - startPosition);
        moveVector = new Vector3((attackPosition.x-1.9f)/25f, 0f,(attackPosition.z-1.9f)/25f);

    }

    public void SpinAttack()
    {
        StartCoroutine(SpinCoroutine());
    }

    public void DropAttack()
    {
        StartCoroutine(DropCoroutine());
    }
    public void SpecialAttack()
    {
        StartCoroutine(SpecialCoroutine());
    }
    public void Heal()
    {
        anim.SetTrigger("Heal");
        StartCoroutine(HealPlayer());
    }

    IEnumerator HealPlayer()
    {
        yield return new WaitForSeconds(1.5f);
        dmg.HealPlayer();
    }

    IEnumerator SpinCoroutine()
    {
        anim.SetBool("Run", true);
        if (controller.isGrounded)
        {
            verticalVelocity = 0;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }
        gravityVector.y = verticalVelocity * Time.deltaTime;
        float timePassed = 0;
        while(timePassed < 0.5f) {
            controller.Move(moveVector);
            controller.Move(gravityVector);
            yield return new WaitForSeconds(0.5f / 40);
            timePassed += Time.deltaTime;
        }

        anim.SetBool("Run", false);
        anim.SetTrigger("Spinkick");


        yield return new WaitForSeconds(1);

        this.transform.position = startPosition;
        dmg.DmgEnemy(1f);

    }

    IEnumerator DropCoroutine()
    {
        anim.SetBool("Run", true);
        if (controller.isGrounded)
        {
            verticalVelocity = 0;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }
        gravityVector.y = verticalVelocity * Time.deltaTime;
        float timePassed = 0;
        while (timePassed < 0.5f)
        {
            controller.Move(moveVector);
            controller.Move(gravityVector);
            yield return new WaitForSeconds(0.5f / 40);
            timePassed += Time.deltaTime;
        }

        anim.SetBool("Run", false);
        anim.SetTrigger("Dropkick");


        yield return new WaitForSeconds(1);

        this.transform.position = startPosition;
        dmg.DmgEnemy(1f);

    }

    IEnumerator SpecialCoroutine()
    {
        anim.SetTrigger("Special");
        yield return new WaitForSeconds(1);
        dmg.DmgEnemy(5f);
    }
}
