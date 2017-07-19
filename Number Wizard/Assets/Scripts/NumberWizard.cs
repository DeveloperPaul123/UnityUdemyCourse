using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

    int guess;
    int max;
    int min;
	// Use this for initialization
	void Start () {
        StartGame();
    }
	
    void StartGame()
    {
        guess = 500;
        max = 1000;
        min = 1;
        print("=========================");
        print("Welcome to Number Wizard!");
        print("Pick a number in your head, but don't tell me.");

        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);

        print("Is the number higher or lower than " + guess + "?");
        print("Up = higher, down = lower, return = equal.");
        max += 1;
    }

    void NextGuess()
    {
        guess = (int)(max + min) / 2;
        print("Is the number higher or lower than " + guess + "?");
        print("Up = higher, down = lower, return = equal.");
    }

	// Update is called once per frame
	void Update () {
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
        else if (Input.GetKeyDown(KeyCode.KeypadEnter)) 
        {
            print("I won!");
            StartGame();
        }
	}


}
