using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextOnlyHide : MonoBehaviour
{
    public GameObject canvas;

    public void StartNewLevel()
    {
        canvas.gameObject.SetActive(false);
    }
}
