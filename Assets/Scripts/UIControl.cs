using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    public GameObject entry;
    public GameObject level;
    public GameObject loose;
    public TextMeshProUGUI timeText;
    public int time = 60;
    private bool isLevelActive = false;

    private void Start()
    {
        entry.SetActive(true);
        level.SetActive(false);
        loose.SetActive(false);
        UpdateTimeText();
    }

    private void Update()
    {
        if (isLevelActive)
        {
            Timeer();
        }
        Debug.Log(timeText.text);
    }

    private void Timeer()
    {
        time -= (int)(1f * Time.deltaTime);
        if (time < 0)
        {
            time = 0;
            isLevelActive = false;
            loos();
        }
        UpdateTimeText();
    }

    private void UpdateTimeText()
    {
        if (timeText != null)
        {
            timeText.text = "Time: " + time.ToString();
        }
    }

    public void newGame()
    {
        entry.SetActive(false);
        level.SetActive(true);
        loose.SetActive(false);
        time = 60;
        isLevelActive = true;
        UpdateTimeText();
    }

    public void loos()
    {
        entry.SetActive(false);
        level.SetActive(false);
        loose.SetActive(true);
        isLevelActive = false;
    }

    public void level1()
    {
        entry.SetActive(false);
        level.SetActive(false);
        loose.SetActive(false);
        time = 60;
        isLevelActive = true;
    }

    public void level2()
    {
        entry.SetActive(false);
        level.SetActive(false); 
        loose.SetActive(false);
        isLevelActive = true;
    }
}
