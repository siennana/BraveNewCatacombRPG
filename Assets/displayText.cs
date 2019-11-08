using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDisplay : MonoBehaviour
{
    //Canvas Element
    [SerializeField]
    private CanvasGroup canvas;

    // hides UI element
    void Start()
    {
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
}
