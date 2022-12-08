using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour
{
    private int nextSceneToLoad;
    private int currentSceneIndex;
    private int sceneToContinue;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Troca());
        
    }

    IEnumerator Troca()
    {
        print(Time.time);
        yield return new WaitForSeconds(3);
        sceneToContinue = PlayerPrefs.GetInt("SavedScene");

        if (sceneToContinue != 0)
            SceneManager.LoadScene(sceneToContinue);
        else
            SceneManager.LoadScene("Jogo1");

        print(Time.time);
    }
}
