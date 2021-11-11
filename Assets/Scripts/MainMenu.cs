using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private Transform[] howToPlayUI;
    GameObject gameObj;

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //public void HowToPlay()
    //{
    //    GameObject.Find("Canvas").SetActive(false);

    //    gameObject = GameObject.Find("Explanation Canvas");
    //    howToPlayUI = gameObject.transform.GetComponentsInChildren<Transform>(true);
    //    foreach (Transform howToPlayUIObject in howToPlayUI)
    //    {
    //        howToPlayUI.gameObject.SetActive(true);
    //    }
    //}

    public void QuitGame()
    {
        Debug.Log("Quit Game Button pressed");
        Application.Quit();
    }
}
