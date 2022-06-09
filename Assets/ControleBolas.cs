using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleBolas : MonoBehaviour
{
    Vector3 posicaoReset;
    public int bolasRestantes;
    public Text bolasRestantesText;

    // Start is called before the first frame update
    void Start()
    {
        posicaoReset = new Vector3(10.52f, 3.94f, -1.19f);
        bolasRestantes = 3;
        bolasRestantesText.text = bolasRestantes.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //bolasRestantesText.text = bolasRestantes.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody) {
            if (bolasRestantes > 0)
            {
                other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
                other.gameObject.transform.position = posicaoReset;
                bolasRestantes--;
                bolasRestantesText.text = bolasRestantes.ToString();
                Debug.Log("Bolas restantes: " + bolasRestantes);
            }
            else {
                bolasRestantesText.text = "Game Over";
                Debug.Log("Game Over");
            }
        }
    }
}
