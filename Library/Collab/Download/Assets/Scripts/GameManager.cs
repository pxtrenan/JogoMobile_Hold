using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{

    public GameObject moreGames;

    public void MenuButton()
    {
        SceneManager.LoadScene("Menu");
    }

    //Isso é só um teste, deve ser mudado
    public void PlayButton()
    {
        SceneManager.LoadScene("Tutorial");
    }

    //Isso é só um teste, deve ser mudado
    public void ReplayLevel()
    {
        SceneManager.LoadScene("Jogo1");
    }

    public void MoreGamesButton()
    {
        moreGames.gameObject.SetActive(true);
    }
    

}
