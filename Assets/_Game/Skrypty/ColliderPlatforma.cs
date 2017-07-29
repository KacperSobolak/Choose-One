using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderPlatforma : MonoBehaviour
{

    GameObject GameController;
    public bool dobry = true;

    void Start()
    {
        GameController = GameObject.Find("GameController");
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Dodaje Punkt!");
        if (dobry == true)
        {
            GameController gc = GameController.GetComponent<GameController>();
            gc.punkty++;
        }
    }
}
