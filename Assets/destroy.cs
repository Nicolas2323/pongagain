﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroy : MonoBehaviour
{

    public float counter = 11;
    public Text countertext;
    public object obj;

    void Update()
    {
        countertext.text = counter.ToString();
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag.Equals("DestrucCol"))
        {
            Destroy(col.gameObject);
            counter += 1;

           
        }

        if (counter == 12)
        {

            

            if (col.gameObject.tag.Equals("todo"))
            {
                
                Destroy(col.gameObject);
            }
        }
    }

}
