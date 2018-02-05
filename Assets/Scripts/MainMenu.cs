using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public GameObject tracksMenuUI;
    static bool isLoaded = false;

    public void Start()
    {
        if (!isLoaded)
        {
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
            isLoaded = true;
            Time.timeScale = 1f;
            AudioListener.volume = 1f;
        }
    }

    public void PlayGame()
    {
        if (tracksMenuUI.activeSelf == false)
            tracksMenuUI.SetActive(true);
        else tracksMenuUI.SetActive(false);
    }

    public void Quit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void LoadTrack01()
    {
        SceneManager.LoadScene("Track01");
    }
}
