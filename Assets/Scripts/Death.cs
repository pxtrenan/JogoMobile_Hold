using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Death : MonoBehaviour {

    public GameObject ball;
    public GameObject canvasLevelPassed;
    public GameObject canvasLevel;
    
    public bool death;


    private int nextSceneToLoad;
    private int currentSceneIndex;

    private void Start()
    {
        //nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Death")
        {
            ball.gameObject.SetActive(false);
            Handheld.Vibrate();

            int scene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
        }
        if (other.tag == "End")
        {
            canvasLevelPassed.gameObject.SetActive(true);
            canvasLevel.gameObject.SetActive(false);
            ball.gameObject.SetActive(false);
            
            //PlayerPrefs.SetInt("SavedScene", currentSceneIndex);
            //SceneManager.LoadScene(nextSceneToLoad);
        }

       
    }


}
