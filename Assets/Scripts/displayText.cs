using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDisplay : MonoBehaviour
{
    //Canvas Element
    [SerializeField]
    private CanvasGroup canvas;
    private Animator anim;

    // hides UI element
    void Start()
    {
        anim = GetComponent<Animator>();
        hide();
    }
    void hide()
    {
        canvas.alpha = 0f;
        canvas.interactable = false;
    }

    // shows UI element
    void show()
    {
        canvas.alpha = 1f;
        canvas.interactable = true;
    }

    public void dialogueOption1()
    {
        anim.SetTrigger("option1");
    }

    public void dialogueOption2()
    {
        anim.SetTrigger("option2");
    }
}
