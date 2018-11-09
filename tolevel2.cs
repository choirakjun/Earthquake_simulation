using System.Collections;

using UnityEngine;

public class tolevel2 : MonoBehaviour
{
    void Awake()
    {
    }
    public void StartButton()
    {
        Invoke("startgame", 1.0f);
    }
    void startgame()
    {
        Application.LoadLevel("level2");
    }
}

