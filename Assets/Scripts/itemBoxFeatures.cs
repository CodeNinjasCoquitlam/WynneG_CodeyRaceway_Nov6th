using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxFeatures : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * 30f);
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Codey")
        {
            gameObject.SetActive(false);
            Invoke("itemBoxRespawn", 10f);
        }
    }
    private void itemBoxRespawn()
    {
        gameObject.SetActive(true);
    }
}
