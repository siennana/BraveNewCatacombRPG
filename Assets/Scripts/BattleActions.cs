using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleActions : MonoBehaviour
{
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
        startPosition = this.transform.position;
        attackPosition = (enemy.transform.position - startPosition);
        moveVector = new Vector3((attackPosition.x-2f)/25f, 0f,(attackPosition.z-2f)/25f);
        Debug.Log(startPosition);

    }

    public void AttackAction()
    {
        StartCoroutine(AttackCoroutine());
    }

    IEnumerator AttackCoroutine()
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
        //Debug.Log(this.transform.position);
        //while (timePassed < 1) {
        //    this.transform.Rotate(45/30f, 0, 0);
        //    yield return new WaitForSeconds(0.5f / 30);
        //    timePassed += Time.deltaTime;
        //}

        yield return new WaitForSeconds(1);

        //this.transform.Rotate(-45, 0, 0);
        this.transform.position = startPosition;
    }
}
