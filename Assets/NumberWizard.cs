using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    int max = 1000;
    int min = 1;

    int guess = 500;
    
    void Start()
    {
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number between " + min + "and " + max + " and I bet I can guess it!");
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up Key if higher, Push Down if lower, and Push Enter if correct.");

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            Debug.Log("Up Arrow was pressed");
            min = guess;
            Debug.Log(guess);
            guess = (max + min) / 2;
        }
               
        else if (Input.GetKeyDown(KeyCode.DownArrow)) 
        {
            Debug.Log("Down Key was pressed");
            max = guess;
            Debug.Log(guess);
            guess = (max + min) / 2;
        }
        
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Woohoo! I guessed correctly. Your number was: " + guess);
        }
            
    }
}
