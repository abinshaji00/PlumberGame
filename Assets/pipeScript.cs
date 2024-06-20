using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeScript : MonoBehaviour
{
    [SerializeField] float[] rotations = { 0, 90, 180, 270 };
    [SerializeField] float[] currectRotation;
    [SerializeField] bool isCorrect=false;
    [SerializeField] int PossibleRots;
    [SerializeField]GameManager gameManager;
    private void Awake()
    {
        gameManager = GameObject.Find("manager").GetComponent<GameManager>();
    }

    private void Start()
    {
        PossibleRots=currectRotation.Length;
        int rand= Random.Range(0, rotations.Length);
        transform.eulerAngles=new Vector3(0, 0, rotations[rand]);
        if (PossibleRots > 1)
        {
            if (transform.eulerAngles.z == currectRotation[0] || transform.eulerAngles.z == currectRotation[1])
            {
                isCorrect = true;
                gameManager.CurrectMove();
            }
        }
        else
        {
            if (transform.eulerAngles.z == currectRotation[0])
            {
                isCorrect = true;
                gameManager.CurrectMove();
            }
        }

     }
    private void OnMouseDown()
    {
        transform.Rotate(0, 0, 90);
        if (PossibleRots > 1)
        {
            if (transform.eulerAngles.z == currectRotation[0] || transform.eulerAngles.z == currectRotation[1] && isCorrect == false)
            {
                isCorrect = true;
                gameManager.CurrectMove();
            }
            else if (isCorrect == true)
            {
                isCorrect = false;
                gameManager.WrongMove();
            }
        }
        else
        {
            if (transform.eulerAngles.z == currectRotation[0])
            {
                isCorrect = true;
                gameManager.CurrectMove();

            }
            else if (isCorrect == true)
            {
                isCorrect = false;
                gameManager.WrongMove();
            }
        }
    }
}
