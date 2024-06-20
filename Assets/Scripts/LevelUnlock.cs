using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class LevelUnlock : MonoBehaviour
{
    [SerializeField] public GameObject Image;
    [SerializeField] public GameObject UIText;
    private void Start()
    {
        UIText.SetActive(true);
        Image.SetActive(false);
    }

}
