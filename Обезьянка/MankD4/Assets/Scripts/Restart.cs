
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{


    void OnMouseDown ()
    {
       // SceneManager.LoadScene("Level_1");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
