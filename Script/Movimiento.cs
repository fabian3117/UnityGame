using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float VelocidadX=10f;
    public float VelocidadY=30f;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    public GameObject shuriken;
    public Joystick JoyMovi;
    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
        sprite=GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = (JoyMovi.Horizontal+Input.GetAxis("Horizontal")) * VelocidadX;
        float moveY = (JoyMovi.Vertical+Input.GetAxis("Vertical")) * VelocidadY;
        rb.velocity = new Vector2(moveX, (moveY>0)?moveY:rb.velocity.y);
        if(moveX<0){
        sprite.transform.localScale = new Vector3(-1, 1, 1);
        }
        else{
                    sprite.transform.localScale = new Vector3(1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.X))
    {
        Vector2 pos=rb.position;
        pos.x+=1;
        Instantiate(shuriken, pos, Quaternion.identity);
    }
    }
    public void Saltar(){
        rb.velocity +=Vector2.up*VelocidadY*2;
       
    }
    public void Shuriken(){
        Vector2 pos=rb.position;
        pos.x+=1;
        Instantiate(shuriken, pos, Quaternion.identity);

    }
}
