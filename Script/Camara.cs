using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public float suavizado=0.5f;
    public GameObject jugador;
    public Vector2 minimo;
    public Vector2 maximo;
    Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    float posX=Mathf.SmoothDamp(transform.position.x,jugador.transform.position.x,ref velocity.x,suavizado);    
    float posY=Mathf.SmoothDamp(transform.position.y,jugador.transform.position.y,ref velocity.y,suavizado);        
    transform.position=new Vector3(Mathf.Clamp(posX,minimo.x,maximo.x),Mathf.Clamp(posY,minimo.y,maximo.y),transform.position.z);
    }
}
