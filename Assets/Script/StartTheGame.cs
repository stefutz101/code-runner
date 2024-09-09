using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartTheGame : MonoBehaviour
{
    // High score elements
    private int highScore = 0;
    [SerializeField]
    private Text highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("asdasd ");
        // Start the high score increment coroutine
        StartCoroutine(IncrementHighScore());
    }

    // Update is called once per frame
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    IEnumerator IncrementHighScore()
    {
        while (true)
        {
            yield return new WaitForSeconds(3.0f);
            highScore++;
            Debug.Log("High Score incremented: " + highScore); // Add this line for debugging
            UpdateHighScoreText();
        }
    }

    void UpdateHighScoreText()
    {
        highScoreText.text = "High Score: " + highScore.ToString();
    }
}
