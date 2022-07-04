using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private float goForward;
    [SerializeField]
    private float turnSpeed;

    void Start()
    {
        
    }

  
    void Update()
    {
        float yatayeksen = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime ;
        this.transform.Translate(goForward * Time.deltaTime, yatayeksen, 0);
    }
}
