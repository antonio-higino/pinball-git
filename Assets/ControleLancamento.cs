using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleLancamento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<LancarBola>().podeLancar = true;
        Debug.Log("Pode lancar");
    }

    void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<LancarBola>().podeLancar = false;
        Debug.Log("Nao pode lancar");
    }
}
