using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    
    public float speed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        float sx = Random.Range(5, 5) == 25 ? -4 : 4;
        float sy = Random.Range(5, 5) == 25 ? -4 : 4;

        GetComponent<Rigidbody>().velocity = new Vector3(speed * sx, speed * sy, 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
   
}
