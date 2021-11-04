using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int maxNumber;
    [SerializeField] int minNumber;
    [SerializeField] TextMeshProUGUI m_Object;


    int guess;

    // Start is called before the first frame update
    void Start()
    {
        
        StartGame();
        
    }

    void StartGame()
    {

        NextGuess();
        
    }

    public void OnPressHigher()
    {
        minNumber = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        maxNumber = guess - 1;
        NextGuess();
    }



    void NextGuess()
    {
        guess = (minNumber + maxNumber) / 2;
        m_Object.text = guess.ToString();
    }




}
