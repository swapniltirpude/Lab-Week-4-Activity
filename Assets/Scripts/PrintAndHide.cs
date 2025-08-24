using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{

    public Renderer rend;
    private int i = 3;// Start is called before the first frame update
    private int blueTrigger;
    void Start()
    {
        if (rend == null)
        {
            rend = GetComponent<Renderer>();
        }

        if (CompareTag("Blue"))
        {
            blueTrigger = Random.Range(150, 251);
            Debug.Log(gameObject.name + " is Blue. Will disable Renderer at i = " + blueTrigger);
        }
    }

    // Update is called once per frame
    void Update()
    {

        i++;
        Debug.Log(gameObject.name + ":" + i);

        if (CompareTag("Red") && i == 100)
        {
            Debug.Log(gameObject.name + " is Red and reached i = 100. Deactivating.");
            gameObject.SetActive(false);
        }

        if (CompareTag("Blue") && i == blueTrigger)
        {
            if (rend != null)
            {
                Debug.Log(gameObject.name + " is Blue and reached i = " + blueTrigger + ". Disabling Renderer.");
                rend.enabled = false;
            }
        }   
    }
}
