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
       StartGame(); 
        
    }

    void StartGame() 
    {
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number between " + min + " and " + max + " and I bet I can guess it!");
        Debug.Log("Is your number higher than, lower than, or exactly " + guess + "?");
        Debug.Log("If it's higher, press Up. If it's lower, press Down. And if it's correct, press Enter.");

        max = max + 1;

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            min = guess;
            NextGuess();
        }
               
        else if (Input.GetKeyDown(KeyCode.DownArrow)) 
        {
            max = guess;
            NextGuess();
        }
        
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Woohoo! I guessed correctly. Your number was " + guess + "!");
        }
            
    }
    void NextGuess() 
    {
        guess = (max + min) / 2;
        Debug.Log("Is your number " + guess +"?");
    }
}
