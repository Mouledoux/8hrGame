using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class UI : MonoBehaviour
{
public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
