using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplayici : MonoBehaviour
{
    GameObject anak�p;
    public GameObject gamefinish;
    float high;
    public static bool isPaused;

    void Start()
    {
        anak�p = GameObject.Find("Center");
    }

    void Update()
    {
        anak�p.transform.position = new Vector3(transform.position.x, high, transform.position.z);
        this.transform.position = new Vector3(transform.position.x,0.5f , transform.position.z);
    }

    public void highDecrease()
    {
        high--;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Topla"&&other.gameObject.GetComponent<Cube>().GetToplandiMi()==false)
        {
            high += 1;
            other.gameObject.GetComponent<Cube>().Toplandi();
            other.gameObject.GetComponent<Cube>().IndexAyarla(high);
            other.gameObject.transform.parent = anak�p.transform;

        }

        if (other.gameObject.tag=="Finish")
        {

            gamefinish.SetActive(true);
            Time.timeScale = 0;
            isPaused = true;

        }
    }

   
}
