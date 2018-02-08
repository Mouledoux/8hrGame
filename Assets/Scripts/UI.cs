using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class UI : MonoBehaviour
{
    public GameObject pauseMenu;

    private void Start()
    {
        Time.timeScale = 1f;
        AudioListener.volume = AudioListener.volume * Time.timeScale;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(pauseMenu)
            {
                pauseMenu.SetActive(!pauseMenu.activeSelf);
                Time.timeScale = pauseMenu.activeSelf ? 0f : 1f;
                AudioListener.volume = AudioListener.volume * Time.timeScale;
            }
        }
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Restart()
    {
        LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SetMasterVolume(UnityEngine.UI.Slider volumeSlider)
    {
        AudioListener.volume = volumeSlider.value;
    }
}
