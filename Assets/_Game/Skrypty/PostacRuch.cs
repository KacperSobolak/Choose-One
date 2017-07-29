using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PostacRuch : MonoBehaviour {

    public Animator cubeanimator;
    public Button[] strzalkiBTN;
    public Text debugtext;

    public GameObject Empty;
    
	void Start () {
		 
	}
	
	void Update () {
		
	}

    public void Lewo()
    {
        cubeanimator.SetTrigger("Lewo");
        Debug.Log("Lewo");
        debugtext.text = "Lewo";
    }

    public void Prawo()
    {
        cubeanimator.SetTrigger("Prawo");
        Debug.Log("Prawo");
        debugtext.text = "Prawo";
    }

    public void Przod()
    {
        cubeanimator.SetTrigger("Przod");
        Debug.Log("Przod");
        debugtext.text = "Przod";
    }
}
