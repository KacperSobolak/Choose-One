using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

    public GameObject gameCon;
    public bool startgame = false;

	void Start () {
        startgame = true;
        GameController gc = gameCon.GetComponent<GameController>();
        Debug.Log(gc);
        gc.SpawnPola(this.transform.position);
    }
	void Update () {

	}

    /*private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("COL");
        if (startgame == false)
        {
            startgame = true;
            GameController gc = gameCon.GetComponent<GameController>();
            Debug.Log(gc);
            gc.SpawnPola(this.transform.position);
        } 
    }*/

}
