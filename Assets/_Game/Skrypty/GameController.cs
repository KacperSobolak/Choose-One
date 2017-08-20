using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public int punkty;
    public Text punktytext;
    public GameObject pauzapanel;
    public Canvas Gameplay;
    public Canvas Startgame;
    public Canvas GameOver;
    public GameObject Nowyrekord;
    public Text rekordtext;

    public GameObject pola;

	void Start () {
        rekordtext.text = "Aktualny rekord wynosi " + PlayerPrefs.GetInt("Rekord").ToString();
        pauzapanel.SetActive(false);
        Gameplay.enabled = false;
        Startgame.enabled = true;
        GameOver.enabled = false;
        Nowyrekord.SetActive(false);
        if (PlayerPrefs.HasKey("Rekord") == true)
        {
            return;
        }
        else
        {
            PlayerPrefs.SetInt("Rekord", 0);
        }
    }
	
	void Update () {
        punktytext.text = punkty.ToString();
	}

    public void PauzaBTN()
    {
        Time.timeScale = 0;
        pauzapanel.SetActive(true);
        pauzapanel.GetComponent<Image>().enabled = true;
    }

    public void UnpauseBTN()
    {
        Time.timeScale = 1;
        pauzapanel.SetActive(false);
    }

    public void SpawnPola(Vector3 position)
    {
        Debug.Log("Spawn nowe pola");
        position.y = 0;
        Instantiate(pola, position, Quaternion.identity);
    }

    public void StartGame_BTN()
    {
        Debug.Log("Start game");
        Startgame.enabled = false;
        Gameplay.enabled = true;
    }

    public void SprobojPonownieBTN()
    {
        SceneManager.LoadScene(1);
    }

    public void WyjdzBTN()
    {
        Application.Quit();
    }

    public void KoniecGry()
    {
        Startgame.enabled = false;
        Gameplay.enabled = false;
        GameOver.enabled = true;
        if (punkty > PlayerPrefs.GetInt("Rekord"))
        {
            PlayerPrefs.SetInt("Rekord", punkty);
            Nowyrekord.SetActive(true);
        }
    }

}
