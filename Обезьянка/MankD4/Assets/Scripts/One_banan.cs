using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class One_banan : MonoBehaviour
{
    public ParticleSystem One_Banan;

    void OnTriggerEnter2D(Collider2D banan)
    {
        if (banan.gameObject.tag == "Player" && !Player.lose)
        {

            instantiate(One_Banan, transform.position);

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
