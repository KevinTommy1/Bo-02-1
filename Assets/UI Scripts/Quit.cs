using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{

    public void Stop()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}
