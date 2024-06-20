using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{

    public void nextLevel()
    {
        PlayerPrefs.SetInt("ReachedLevel", PlayerPrefs.GetInt("ReachedLevel") + 1);
        Application.LoadLevel("Level");
    }
}
