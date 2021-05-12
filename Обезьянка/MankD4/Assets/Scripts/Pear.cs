using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pear : MonoBehaviour
{
    public ParticleSystem One_Pear;

    void OnTriggerEnter2D(Collider2D pear)
    {
        if (pear.gameObject.tag == "Player" && !Player.lose)
        {       
            instantiate(One_Pear, transform.position);

            //звук 
            AudioSource myAudio;
            myAudio = GetComponent<AudioSource>();
            AudioSource.PlayClipAtPoint(myAudio.clip, transform.position, 1);
        
            Score.scoreAmount2++;       
            Destroy(gameObject);
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
