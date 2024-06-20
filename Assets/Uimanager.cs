using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Uimanager : MonoBehaviour
{
    [SerializeField] public GameObject Entry;
    [SerializeField] public GameObject Level;

    public void play()
    {
        Debug.Log("pressed");
        Entry.SetActive(false);
        Level.SetActive(true);
    }
    public void exit()
    {
        Application.Quit();
    }
    public void Home()
    {
        Entry.SetActive(true);
        Level.SetActive(false);
    }
    public void level1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void level2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void level3()
    {
        SceneManager.LoadScene("Level 3");
    }
    public void level4()
    {
        SceneManager.LoadScene("Level 4");
    }
    public void level5()
    {
        SceneManager.LoadScene("Level 5");
    }
    public void level6()
    {
        SceneManager.LoadScene("Level 6");
    }
    public void level7()
    {
        SceneManager.LoadScene("Level 7");
    }
    public void level8()
    {
        SceneManager.LoadScene("Level 8");
    }
    public void level9()
    {
        SceneManager.LoadScene("Level 9");
    }
    public void level10()
    {
        SceneManager.LoadScene("Level 10");
    }
    public void level11()
    {
        SceneManager.LoadScene("Level 11");
    }
    public void level12()
    {
        SceneManager.LoadScene("Level 12");
    }
    public void level13()
    {
        SceneManager.LoadScene("Level 13");
    }
    public void level14()
    {
        SceneManager.LoadScene("Leve 14");
    }
    public void level15()
    {
        SceneManager.LoadScene("Level 15");
    }
    public void level16()
    {
        SceneManager.LoadScene("Level 16");
    }
}
