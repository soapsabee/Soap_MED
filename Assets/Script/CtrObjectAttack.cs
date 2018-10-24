using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrObjectAttack : MonoBehaviour {

    Rigidbody2D rigidbody;
    public Vector2 velocity;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        rigidbody.velocity = velocity;
    }
}
