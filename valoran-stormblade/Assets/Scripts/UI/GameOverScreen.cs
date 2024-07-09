using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void Restart() {
        Debug.Log("game over");
        DataManager.instance.health = 100;
        DataManager.instance.speed = 20;
        DataManager.instance.damage = 10;
        
        // Load lại màn chơi hiện tại
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }

    public void Quit()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
