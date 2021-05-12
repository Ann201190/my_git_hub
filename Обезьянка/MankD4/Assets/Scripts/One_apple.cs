using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class One_apple : MonoBehaviour
{
    public ParticleSystem Apple;

    void OnTriggerEnter2D(Collider2D apple)
    {
        if (apple.gameObject.tag == "Player" && !Player.lose)
        {

            instantiate(Apple, transform.position);

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
