using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public int highScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource dingSFX;
    public TMP_Text highScoreText;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "High Score: " + highScore.ToString();
    }

        [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        dingSFX.Play();
    }



    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true); // Shows the game over button we made 

        if (playerScore > highScore) // If the players current score is better than the current high score, update the high score with the players current score
        { 
            highScore = playerScore; 
            PlayerPrefs.SetInt("HighScore", highScore); // Uses PlayerPrefs to save the score and remembers it for later
        }

        highScoreText.text = "High Score: " + highScore.ToString(); // Changes the text on screen so the player sees their new high score
    }
}
