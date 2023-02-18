using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemig_0 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionStay(Collision collision) {
        Debug.Log("CHOCO CON :" + collision.gameObject.tag);
    }
}
