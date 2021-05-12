using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class SpecialEffectsHelper : MonoBehaviour
{
   public static SpecialEffectsHelper Instance;

    public ParticleSystem One_Banan;
    public ParticleSystem Candy;
    public ParticleSystem Cocount;
    public ParticleSystem Pear;

    void Awake()
      {
        // Register the singleton
        if (Instance != null)
        {
            Debug.LogError("Multiple instances of SpecialEffectsHelper!");
        }
        Instance = this;
      }

    public void Explosion(Vector3 position, string obejct)
    {
         if (obejct == "Pear")
        {
            instantiate(Pear, position);
        }
        if (obejct== "Candy")
        {
            instantiate(Candy, position);
        }
        if (obejct == "One_Banan" || obejct == "Banan")
        {
            instantiate(One_Banan, position);
        }
        if (obejct == "Cocount")
        {
            instantiate(Cocount, position);
        }    
    }

    private ParticleSystem instantiate(ParticleSystem prefab, Vector3 position)
    {
        ParticleSystem newParticleSystem = Instantiate(prefab,position,Quaternion.identity) as ParticleSystem;
        // Make sure it will be destroyed
        Destroy(newParticleSystem.gameObject,newParticleSystem.startLifetime);

        return newParticleSystem;
    }
}*/