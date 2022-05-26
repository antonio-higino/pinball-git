using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LancarBola : MonoBehaviour
{
    Rigidbody bola;
    public float forca = 0f;
    float angulo = 340f;

    // Start is called before the first frame update
    void Start()
    {
        bola = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        while (Input.GetKeyDown(KeyCode.Space)) {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            forca += 1f;

            if (forca >= 25f) {
                break;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            float xComponent = Mathf.Cos(angulo * Mathf.PI / 180) * forca;
            float yComponent = Mathf.Sin(angulo * Mathf.PI / 180) * forca;

            bola.AddForce(xComponent, yComponent, 0, ForceMode.Impulse);

            forca = 0f;
        }
    }
}
