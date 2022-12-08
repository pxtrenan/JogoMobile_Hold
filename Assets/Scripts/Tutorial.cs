using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Tuto());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Tuto()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("Menu");
    }
}
