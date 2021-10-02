using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    bool GameIsOver = false;

    public float RestartInterval = 1f;

    public GameObject completeLevelUI;

    

    public void LevelComplete()
    {
        Debug.Log("WOONN");
        completeLevelUI.SetActive(true);

    }

    public void GameOver()
    {
        if(GameIsOver == false)
        {
            GameIsOver = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", RestartInterval);
            
        }
    }

    void Restart (){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }        
}
