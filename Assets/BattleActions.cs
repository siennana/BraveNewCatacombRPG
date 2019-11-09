using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleActions : MonoBehaviour
{
    private Vector3 startPosition;
    private Vector3 attackPosition;
    private Vector3 offset = new Vector3(0.1f, 0f, 0.1f);
    //private Vector3 moveVector;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {   
        startPosition = this.transform.position;
        attackPosition = (enemy.transform.position - startPosition)/30f;
        Debug.Log(startPosition);

    }

    public void AttackAction()
    {
        StartCoroutine(AttackCoroutine());
    }

    IEnumerator AttackCoroutine()
    {
        float timePassed = 0;
        while(timePassed < 0.6f) { 
            this.transform.Translate(0f, attackPosition.x, attackPosition.z);
            yield return new WaitForSeconds(0.5f / 40);
            timePassed += Time.deltaTime;
        }
        Debug.Log(this.transform.position);
        while (timePassed < 1) {
            this.transform.Rotate(45/30f, 0, 0);
            yield return new WaitForSeconds(0.5f / 30);
            timePassed += Time.deltaTime;
        }

        yield return new WaitForSeconds(1);
        this.transform.Rotate(-45, 0, 0);
        this.transform.position = startPosition;
    }
}
