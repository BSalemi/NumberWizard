using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    int max = 1000;
    int min = 1;
    void Start()
    {
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number between " + min + "and " + max + " and I bet I can guess it!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
