using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {

    int guess;
    int max;
    int min;
    int maxGuessesAllowed;

    public Text NumberGuessText;

	// Use this for initialization
	void Start () {
        StartGame();
    }
	
    void StartGame()
    {
        
        max = 1000;
        min = 1;
        maxGuessesAllowed = 5;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max+1);
        NumberGuessText.text = guess.ToString();
        maxGuessesAllowed--;
        if (maxGuessesAllowed <= 0)
        {
            SceneManager.LoadScene("Win");
        }
    }

	// Update is called once per frame
	void Update () {
        
	}

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }


}
