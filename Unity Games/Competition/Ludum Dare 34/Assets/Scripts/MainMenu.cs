using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    public Timer times;

    void Start()
    {
        times = FindObjectOfType<Timer>();
    }

    public void OnStart()
    {
        Application.LoadLevel("Level 1");
        times.levelTime = 0;
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit the game.");
    }
}
