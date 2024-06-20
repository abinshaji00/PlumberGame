using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    LevelUnlock levelUnlock;
    Button[] button;
    private void Awake()
    {
        levelUnlock = GetComponent<LevelUnlock>();
        int reachedLevel = PlayerPrefs.GetInt("ReachedLevel", 1);
        if (PlayerPrefs.GetInt("Level") >= 2)
        {
            reachedLevel = PlayerPrefs.GetInt("Level");
        }
        button=new Button[transform.childCount];
        for (int i = 0; i < button.Length; i++)
        {
            button[i] = transform.GetChild(i).GetComponent<Button>();
            button[i].GetComponentInChildren<TextMeshProUGUI>().text = (i + 1).ToString();
            if (i + 1 > reachedLevel)
            {
                button[i].interactable = false;
            }
        }
    }
    public void LoadScene(int Levels)
    {
        PlayerPrefs.SetInt("Level", Levels);
        ///Application.LoadLevel("Loading");
    }

}
