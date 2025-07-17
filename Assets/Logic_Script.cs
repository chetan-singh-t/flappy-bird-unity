using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Logic_Script : MonoBehaviour
{
    public int score;
    public Text Score_Text;
    public GameObject gameOverScreen;
    public void addscore(int Score_add)
    {
        score+= Score_add;
        Score_Text.text = score.ToString();
    }
    public void resetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       
        Time.timeScale = 1.0f;
        
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        
    }
}
