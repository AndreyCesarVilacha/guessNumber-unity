using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{

    public InputField userInput;
    public Text textUI;
    public Button buttonUi;

    public int minNumber;
    public int maxNumber;

    //Declaring a variable
    //Private is an access modifier - makes this variable only
    //accessible from this script
    private int randomNum;
    private bool isGameWon = false;

    // Start is called before the first frame update
    void Start()
    {
        ResetGame();

    }

    //Creating a function to handle the click button event
    public void OnButtonClick() 
    {

        string userInputValue = userInput.text;
        if(userInputValue != "")
        {
            int answer = int.Parse(userInputValue);

            if (answer == randomNum)
            {
                textUI.text = "Correct";
                isGameWon = true;
                ResetGame();
                //buttonUi.interactable = false;
            }
            else if (answer > randomNum)
            {
                textUI.text = "Try lower!";
            }
            else
            {
                textUI.text = "Try Higher";
            }
        }
        else
        {
            textUI.text = "Please enter with a number";
        }

        

        //Debug.Log("Button clicked");
        //Debug.Log("Value of Input: " + userInput.text);
        //Debug.Log("The valor of randoNum: " + randomNum);
        //Debug.Log("Value of answer: " + answer);

    }

    //Function responsible for return a random number
    private int GetRandoNumber(int min, int max)
    {
        int random = Random.Range(min, max);

        return random;
    }

    private void ResetGame()
    {
        if (isGameWon)
        {
            textUI.text = "You Won!";
            isGameWon = false;
        }
        else
        {
            textUI.text = "Guess a number between " + minNumber + " and " + (maxNumber-);
            userInput.text = "";
            randomNum = GetRandoNumber(minNumber, maxNumber);
        }
        
        
    }

}
