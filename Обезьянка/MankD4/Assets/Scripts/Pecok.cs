using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pecok : MonoBehaviour
{
    public GameObject restsrt1;
    public GameObject menu1;
    public GameObject pause1;
    public GameObject pause_men2;
    public GameObject music;
    //  public GameObject brok_banan;
    void OnTriggerEnter2D(Collider2D pesochek)
    {
        if (pesochek.gameObject.tag == "Banan" || pesochek.gameObject.tag == "One_Banan" || pesochek.gameObject.tag == "Pear")
        {

          //  Instantiate(brok_banan, transform.position, Quaternion.Euler(0, -3.8f, 0));
          //  brok_banan.SetActive(true);
            Player.lose = true;
            restsrt1.SetActive(true);
            menu1.SetActive(true);
            pause1.SetActive(false);
            pause_men2.SetActive(true);
            music.SetActive(true);
        }
    }
}
