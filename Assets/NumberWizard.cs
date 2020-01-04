using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int min;
    int max;
    int guess;

    // Start is called before the first frame update
    void Start() {
        StartGame();
    }

    void StartGame() {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number!");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than my guess " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max += 1;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            NextGuess();
        }
         else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            NextGuess();
        }
         else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("Restart Game");
            StartGame();
        }

    }
    void NextGuess() {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than: " + guess);

    }

}