using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public float scored = 0;
   
    public Transform ball;
    public Text scoretext; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.position.x <= -13.99f)
            scored += 1f;
        scoretext.text = scored.ToString();

        
    }
}
