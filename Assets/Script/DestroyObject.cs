using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

    public float delay;
    void Start()
    {
        Destroy(gameObject, delay);
    }

    
    void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
        }
        

    }
}
