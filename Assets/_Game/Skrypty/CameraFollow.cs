using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    
    public GameObject player;

    Vector3 pozycja;
    private Vector3 offset;        

    void Start()
    {        
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        pozycja.x = player.transform.position.x;
        pozycja.z = player.transform.position.z;
        transform.position = pozycja + offset;
    }
}