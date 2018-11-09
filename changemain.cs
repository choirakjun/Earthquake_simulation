using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changemain : MonoBehaviour
{

    public float delay = 2;
    public string NewLevelString = "main2";
    void Start()
    {
        StartCoroutine(LoadLevelAfterDelay(delay));
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Application.LoadLevel(NewLevelString);
    }
}