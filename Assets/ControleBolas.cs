using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleBolas : MonoBehaviour
{
    Vector3 posicaoReset;
    public int bolasRestantes;

    // Start is called before the first frame update
    void Start()
    {
        posicaoReset = new Vector3(10.52f, 3.94f, -1.19f);
        bolasRestantes = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody) {
            if (bolasRestantes > 0)
            {
                other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
                other.gameObject.transform.position = posicaoReset;
                bolasRestantes--;
                Debug.Log("Bolas restantes: " + bolasRestantes);
            }
            else {
                Debug.Log("Game Over");
            }
        }
    }
}
