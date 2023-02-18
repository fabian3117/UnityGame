using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuriken : MonoBehaviour
{
    public float VelocidadX=20f;
    private Rigidbody2D rb;
    //private Gameob
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity=new Vector2(VelocidadX,rb.velocity.y);
        if(rb.position.y<=-1){
            Destroy(gameObject);
        }
    }
}
