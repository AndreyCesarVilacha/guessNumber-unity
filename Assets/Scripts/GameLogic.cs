using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{

    public InputField userInput;

    //Declaring a variable
    //Private is an access modifier - makes this variable only
    //accessible from this script
    private int randomNum;

    // Start is called before the first frame update
    void Start()
    {
        randomNum = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Creating a function to handle the click button event
    public void OnButtonClick() 
    {

        string userInputValue = userInput.text;
        int answer = int.Parse(userInputValue);

        if (answer == randomNum)
        {
            Debug.Log("Correct");
        }
        else
        {
            Debug.Log("Wrong");
        }

        //Debug.Log("Button clicked");
        //Debug.Log("Value of Input: " + userInput.text);
        //Debug.Log("The valor of randoNum: " + randomNum);
        //Debug.Log("Value of answer: " + answer);

    }

}
