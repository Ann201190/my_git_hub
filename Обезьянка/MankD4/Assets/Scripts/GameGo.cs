using UnityEngine;
using UnityEngine.SceneManagement;

public class GameGo : MonoBehaviour
{
    public GameObject Music;
    void OnMouseDown()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}





