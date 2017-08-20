using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforma : MonoBehaviour{

    GameObject GameController;
    public bool dobryB = false;
    public GameObject[] platformyobok;
    public Kolory kolory_skrypt;
    public LosowanieDobrejPlatformy ldps;
    public Color zlyk;
    public Color kolorplatformy;

    void Start()
    {
        kolorplatformy = GetComponent<Renderer>().material.color;
        zlyk = kolory_skrypt.zlykolor;
        GameController = GameObject.Find("GameController");
        if (dobryB == true)
        {
            for (int i = 0; i < platformyobok.Length; i++)
            {
                platformyobok[i].GetComponent<Renderer>().material.color = zlyk;
            }
        }
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < platformyobok.Length; i++)
        {
            Destroy(platformyobok[i]);
        }
        if (dobryB == true)
        {
            Debug.Log("Dodaje Punkt!");
            dobryB = false;
            GameController gc = GameController.GetComponent<GameController>();
            gc.punkty++;
            gc.SpawnPola(this.transform.position);
            GetComponent<Renderer>().material.color = kolorplatformy; 
        }
        else if (dobryB == false)
        {
            other.gameObject.GetComponent<Postac>().GameOver();
            Destroy(this.gameObject);
            GameController.GetComponent<GameController>().KoniecGry();

        }
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(this.gameObject);
    }
}
