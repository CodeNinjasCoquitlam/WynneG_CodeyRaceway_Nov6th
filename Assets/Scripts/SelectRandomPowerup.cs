using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{
    public List<GameObject> powerupList;
    public int randomNumberInList;
    public GameObject chosenPowerup;
    public Vector3 playerpos;
    public bool abc;
    void Start()
    {
        abc = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && chosenPowerup&&abc)
        {
            Debug.Log("abajaba");
            Instantiate(chosenPowerup, new Vector3(transform.position.x, transform.position.y+3, transform.position.z)+transform.forward*2, transform.rotation);//Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z));
            abc = false;
        }
    }
    private void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.tag == "itemBoxes")
        {
            randomNumberInList = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
            abc = true;
        }
    }
}

