using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MyPauseMenu : MonoBehaviour
{
    private float m_TimeScaleRef = 1f;
    private float m_VolumeRef = 1f;
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject Result;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else Pause();
        }
    }

    public void Resume()
    {
        if (Result.activeSelf == true)
        {
            Result.GetComponent<Text>().enabled = true;
        }
        pauseMenuUI.SetActive(false);
        Time.timeScale = m_TimeScaleRef;
        AudioListener.volume = m_VolumeRef;
        GameIsPaused = false;
    }

    void Pause()
    {
        if(Result.activeSelf == true)
        {
            Result.GetComponent<Text>().enabled = false;
        }
        pauseMenuUI.SetActive(true);
        m_TimeScaleRef = Time.timeScale;
        Time.timeScale = 0f;
        m_VolumeRef = AudioListener.volume;
        AudioListener.volume = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Resume();
        Time.timeScale = 1f;
        AudioListener.volume = 1f;
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
