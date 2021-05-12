using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour
{
    public static bool muze;

    void Start()
    {
        if (muze == false)
        {
            GetComponent<AudioSource>().Play();
            muze = true;
        }
        else {
            GetComponent<AudioSource>().Stop();
        }
    }
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}