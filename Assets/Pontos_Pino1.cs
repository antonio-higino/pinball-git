using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontos_Pino1 : MonoBehaviour
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
        other.gameObject.GetComponent<LancarBola>().pontuacao += 1000;
        Debug.Log("Pontuacao: " + other.gameObject.GetComponent<LancarBola>().pontuacao);
    }
}
