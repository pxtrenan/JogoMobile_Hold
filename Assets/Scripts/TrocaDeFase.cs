using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaDeFase : MonoBehaviour
{

    private int nextSceneToLoad;
    private int currentSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Troca());
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator Troca()
    {
        print(Time.time);
        yield return new WaitForSeconds(1);
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentSceneIndex);
        SceneManager.LoadScene(nextSceneToLoad);
        print(Time.time);
    }
}
