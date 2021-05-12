
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject restsrt;
    public GameObject menu;
    public GameObject pause;
    public GameObject pause_menu;
    //  public GameObject music;
    public ParticleSystem Cocount;

    public static bool lose = false;
    void Awake ()
    {
        lose = false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Cocount")
        {           
            instantiate(Cocount, transform.position);

            //звук 
            AudioSource myAudio;
            myAudio = other.gameObject.GetComponent<AudioSource>();
            AudioSource.PlayClipAtPoint(myAudio.clip, transform.position, 1);


            lose = true;
            restsrt.SetActive(true);
            menu.SetActive(true);
            pause.SetActive(false);
            pause_menu.SetActive(true);
          //  music.SetActive(true);
            // Destroy(other.gameObject);
        }
    }

    private ParticleSystem instantiate(ParticleSystem prefab, Vector3 position)
    {
        ParticleSystem newParticleSystem = Instantiate(prefab, position, Quaternion.identity) as ParticleSystem;
        // Make sure it will be destroyed
        Destroy(newParticleSystem.gameObject, newParticleSystem.startLifetime);

        return newParticleSystem;
    }

}



