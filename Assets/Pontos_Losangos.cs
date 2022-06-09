using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontos_Losangos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision coll)
    {
        Rigidbody ballBody = coll.gameObject.GetComponent<Rigidbody>();
        coll.gameObject.GetComponent<LancarBola>().pontuacao += 750;
        Debug.Log("Pontuacao: " + coll.gameObject.GetComponent<LancarBola>().pontuacao);
    }
}
