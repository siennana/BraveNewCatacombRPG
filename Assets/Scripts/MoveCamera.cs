using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Moving Player;
    public Vector3 offset;
    private Animator anim;
    private bool flipping;

    void Start()
    {
        offset = transform.position - Player.transform.position;
        anim = GetComponent<Animator>();
    }

    void LateUpdate()
    {

        if (!flipping)
        {
            transform.eulerAngles = new Vector3(
            10f,
            transform.rotation.y,
            0f
        );
        }
        var rot = Input.GetAxisRaw("Horizontal") * Time.deltaTime * 180;
        this.transform.RotateAround(Player.transform.position, Vector3.up,rot);
        offset = Quaternion.AngleAxis(rot, Vector3.up) * offset;
        transform.Translate(0f, 0f, 3 * Input.GetAxis("Vertical") * Time.deltaTime);
        transform.position = Player.transform.position + offset;
    }

    public void FlipCamera()
    {
        flipping = true;
        StartCoroutine(SubFlip());
    }
    
    IEnumerator SubFlip()
    {
        float timePassed = 0f;
        do
        {
            transform.Rotate(0f, 0f, 9f);
            yield return new WaitForSeconds(1f / 360f);
            timePassed += Time.deltaTime;
        } while (timePassed < 1.5f);
        flipping = false;
    }
}
