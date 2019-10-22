using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(3 * Input.GetAxis("Horizontal") * Time.deltaTime, -3 * Input.GetAxis("Vertical") * Time.deltaTime,0f);   
    }

    public void MoveForward()
    {
        transform.Translate(0f, -5, 0.5f);

    }
}
