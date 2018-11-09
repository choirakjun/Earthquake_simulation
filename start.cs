using System.Collections;

using UnityEngine;

public class start : MonoBehaviour {
    void Awake()
    {
    }
    public void StartButton() {
        Invoke("startgame", 1.0f); 
    }
    void startgame()
    {
        Application.LoadLevel("level1");
    }
    }


