using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LosowanieDobrejPlatformy : MonoBehaviour {

    int ktora;
    public int materialint;
    public Color DobryKolor;
    public GameObject[] pola;
    public Material Dobrymaterial;
    public Material Zlymaterial;

    public Kolory Kolory_Skrypt;

    private void Awake()
    {
        ktora = Random.Range(0, 3);
        pola[ktora].GetComponent<Platforma>().dobryB = true;

    }

    public void Start () {
        DobryKolor = Kolory_Skrypt.dobrykolor;
        Dobrymaterial.color = DobryKolor;
        pola[ktora].GetComponent<Renderer>().material = Dobrymaterial;
	}
	
	void Update () {
		
	}
}
