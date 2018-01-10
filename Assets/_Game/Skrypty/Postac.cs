using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Postac : MonoBehaviour {

    public Animator cubeanimator;
    public Button[] strzalkiBTN;
    public Text debugtext;
    public bool moznaruszyc;

    GameObject gamecon;
    public GameObject PostacGO;

    public Vector3 myvector;
    Vector3 przsuwanie;
    string AktualenePrzesuniecie;

    public AudioSource audio;
    
	void Start () {
        moznaruszyc = true;
        myvector = transform.position;
        gamecon = GameObject.Find("GameController");
    }
	
	void Update () {
        if (gamecon.GetComponent<GameController>().startg)
        {
            if (Input.GetKeyDown("right"))
            {
                cubeanimator.SetTrigger("Prawo");
                Debug.Log("space key was pressed");
            }
            else if (Input.GetKeyDown("up"))
            {
                cubeanimator.SetTrigger("Przod");
                Debug.Log("space key was pressed");
            }
            else if (Input.GetKeyDown("left"))
            {
                cubeanimator.SetTrigger("Lewo");
                Debug.Log("space key was pressed");
            }
        }
        


        /*if (moznaruszyc == false)
        {
            for (int i = 0; i < strzalkiBTN.Length; i++)
            {
                strzalkiBTN[i].enabled = false;
            }
        }
        else if (moznaruszyc == true)
        {
            for (int i = 0; i < strzalkiBTN.Length; i++)
            {
                strzalkiBTN[i].enabled = true;
            }
        }*/
    }

    public void Lewo()
    {
        cubeanimator.SetTrigger("Lewo");
        myvector.x -= 2;
        myvector.z += 2;
        moznaruszyc = false;
        audio.Play();
    }

    public void Prawo()
    {
        cubeanimator.SetTrigger("Prawo");
        myvector.x += 2;
        myvector.z += 2;
        moznaruszyc = false;
        audio.Play();
    }

    public void Przod()
    {
        cubeanimator.SetTrigger("Przod");
        myvector.z += 2;
        moznaruszyc = false;
        audio.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        moznaruszyc = true;
    }

    void Czasnaklik()
    {

    }

    public void GameOver()
    {
        Destroy(this.gameObject);
    }

    public void StartGamePlay()
    {
        Debug.Log("start");
        cubeanimator.SetTrigger("Start");
    }

}
