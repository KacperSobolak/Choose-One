using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public int punkty;
    public Text punktytext;
    public GameObject pauzapanel;

	void Start () {
        pauzapanel.SetActive(false);
	}
	
	void Update () {
        punktytext.text = punkty.ToString();
	}

    public void PauzaBTN()
    {
        Time.timeScale = 0;
        pauzapanel.SetActive(true);
    }

    public void UnpauseBTN()
    {
        Time.timeScale = 1;
        pauzapanel.SetActive(false);
    }

}
