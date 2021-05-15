
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    bool restart = false;
    public float delay = 1f;
    public GameObject LevelComplete1UI;
    public void LevelComplete()
    {
        Debug.Log("LEVEL WON!!");
        LevelComplete1UI.SetActive(true);
    }
    public void EndGame()
    {
        if (restart == false)
        {
            restart = true;
            Debug.Log("Game Over");
            Invoke("Reset", delay);
        }
    }
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
