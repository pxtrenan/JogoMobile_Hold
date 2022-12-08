using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    private int sceneToContinue;
    
    public void ContinueGame()
    {
        sceneToContinue = PlayerPrefs.GetInt("SavedScene");

        if (sceneToContinue != 0)
            SceneManager.LoadScene(sceneToContinue);
        

        else
            SceneManager.LoadScene("Jogo1");
    }

    private void Start()
    {
       //PlayerPrefs.DeleteAll();
    }
}
