using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int maxNumber;
    int minNumber;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();

    }

    void StartGame()
    {
        maxNumber = 1000;
        minNumber = 1;
        guess = 500;

        Debug.Log("Welcom to Number Wizard");
        Debug.Log("Pick a number. don't tell me what it is");
        Debug.Log("The Highest number is:" + maxNumber);
        Debug.Log("The Lowest number is:" + minNumber);
        Debug.Log("Tell me if your number is higher or lower than:" + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        maxNumber = maxNumber + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           
            minNumber = guess;
            NextGuess();
 

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {

            maxNumber = guess;
            NextGuess();

        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {

            Debug.Log("You are genius!");
            StartGame();

        }
    }

    void NextGuess()
    {
        guess = (maxNumber + minNumber) / 2;
        Debug.Log("Is it higher or lower than..." + guess);
    }
}
