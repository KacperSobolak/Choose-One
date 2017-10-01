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
    
	void Start () {
        moznaruszyc = true;
        myvector = transform.position;
        gamecon = GameObject.Find("GameController");
    }
	
	void Update () {
        if (moznaruszyc == false)
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
        }
    }

    public void Lewo()
    {
        cubeanimator.SetTrigger("Lewo");
        myvector.x -= 2;
        myvector.z += 2;
        moznaruszyc = false;
    }

    public void Prawo()
    {
        cubeanimator.SetTrigger("Prawo");
        myvector.x += 2;
        myvector.z += 2;
        moznaruszyc = false;
    }

    public void Przod()
    {
        cubeanimator.SetTrigger("Przod");
        myvector.z += 2;
        moznaruszyc = false;
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

}
