using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;

    [SerializeField]
    private GameObject blueObj;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 postionRed = new Vector3(2.2f, 0, 0);
        Vector3 postionBlue = new Vector3(-2.2f, 0, 0);
        Quaternion rotation = Quaternion.identity;
        GameObject instanceRed = Instantiate(redObj, postionRed, rotation);
        GameObject instanceBlue = Instantiate(blueObj, postionBlue, rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
