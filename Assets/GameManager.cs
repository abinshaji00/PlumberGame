using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject PipeHolder;
    public GameObject[] pipes;
    int totalPipe;
    int currectedPipe = 0;
    public TextMeshProUGUI sceneNameText;

    public TextMeshProUGUI timerText;
    public float startTime = 30f;
    private float remainingTime;
    private bool isGameActive = true;
    public GameObject LooseUI;
    public GameObject winnUI;
    private void Start()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        sceneNameText.text = "" + sceneName;
        totalPipe = PipeHolder.transform.childCount;
        pipes = new GameObject[totalPipe];
        for (int i = 0; i < pipes.Length; i++)
        {
            pipes[i] = PipeHolder.transform.GetChild(i).gameObject;
        }
        remainingTime = startTime;
    }

    private void Update()
    {
        if (isGameActive)
        {
            remainingTime -= Time.deltaTime;
            if (remainingTime <= 0)
            {
                remainingTime = 0;
                isGameActive = false;
                HandleTimeout();
            }
            UpdateTimerDisplay();
        }
    }

    public void CurrectMove()
    {
        currectedPipe += 1;
        if (currectedPipe == totalPipe)
        {
            winnUI.SetActive(true);
            isGameActive = false;
        }
    }

    public void WrongMove()
    {
        currectedPipe -= 1;
    }

    private void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(remainingTime / 60F);
        int seconds = Mathf.FloorToInt(remainingTime % 60F);
        timerText.text = string.Format("{0:0}:{1:00}", minutes, seconds);
    }

    private void HandleTimeout()
    {
        LooseUI.SetActive(true);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Home()
    {
        SceneManager.LoadScene("Entry");
    }
    public void win()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
