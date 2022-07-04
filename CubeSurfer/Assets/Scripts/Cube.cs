using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    bool toplandimi;
    float index;
    public Toplayici toplayici;
    void Start()
    {
        toplandimi = false;
    }

    void Update()
    {
        if (toplandimi==true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, 0, -index);
            }
        }
        

    }

    public bool GetToplandiMi()
    {
        return toplandimi;
    }

    public void Toplandi()
    {
        toplandimi = true;
    }
    public void IndexAyarla(float index)
    {
        this.index = index;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag== "Obstacle")
        {
            toplayici.highDecrease();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

}
