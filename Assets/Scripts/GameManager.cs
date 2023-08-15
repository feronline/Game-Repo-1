using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    bool gamehasended = false;

    public float restartDelay = 1f;
    public GameObject completelevelui;
    public void CompleteLevel()
    {
        completelevelui.SetActive(true);
    }

    public void Endgame()
    {
        if (gamehasended == false) { 
        gamehasended = true;
        Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
