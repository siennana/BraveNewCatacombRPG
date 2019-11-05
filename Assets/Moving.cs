using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float _rotationSpeed = 180;
    private Animator anim;

    public Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        this.rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * _rotationSpeed * Time.deltaTime, 0);
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, 3 * Input.GetAxis("Vertical") * Time.deltaTime);
        transform.Rotate(0f, Input.GetAxisRaw("Horizontal") * _rotationSpeed * Time.deltaTime, 0f);
        anim.SetFloat("Speed", Input.GetAxisRaw("Vertical"));
    }

    public void MoveForward()
    {
        transform.Translate(0f, -5, 0.5f);

    }
}
