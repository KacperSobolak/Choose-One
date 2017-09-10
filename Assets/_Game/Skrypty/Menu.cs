using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public Text monety;

	void Start () {
        if (PlayerPrefs.HasKey("Monety") == true)
        {
            monety.text = "Posiadasz " + PlayerPrefs.GetInt("Monety").ToString() + " monet";
        }
        else
        {
            PlayerPrefs.SetInt("Monety", 0);
            monety.text = "Posiadasz " + PlayerPrefs.GetInt("Monety").ToString() + " monet";
        }
    }
	
	void Update () {
		
	}
}
