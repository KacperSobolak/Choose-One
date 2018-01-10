using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    
    public GameObject player;
    public GameObject StartGO;

    Vector3 pozycja;
    private Vector3 offset;        

    void Awake()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        pozycja.x = player.transform.position.x;
        pozycja.z = player.transform.position.z;
        if (StartGO.GetComponent<StartGame>().startgame == false)
        {
            pozycja.y = player.transform.position.y;
        }
        transform.position = pozycja + offset;
    }
}