using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    public GameObject restsrt2;
    public GameObject menu2;
    public GameObject Pause_men;
   // public GameObject music;


    void OnMouseDown()
    {     
        if (Time.timeScale!=0)
        {
            Time.timeScale = 0;
           
            restsrt2.SetActive(true);
            menu2.SetActive(true);
            Pause_men.SetActive(true);
        //    music.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            restsrt2.SetActive(false);
            menu2.SetActive(false);
            Pause_men.SetActive(false);
        //    music.SetActive(false);
        }
    }

}



