using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LancarBola : MonoBehaviour
{
    Rigidbody bola;
    public float forca = 0f;
    float angulo = 160f;

    // Start is called before the first frame update
    void Start()
    {
        bola = GetComponent<Rigidbody>();
    }

    //X = 10.59783
    //Y = 3.482284
    //Z = -1.184

    // Update is called once per frame
    void Update()
    {
        //if (transform.position.x <= 10.598f && transform.position.x >= 10.596f) {
            //if (transform.position.z <= -0.96f && transform.position.z >= -1.148f) {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            float xComponent = Mathf.Cos(angulo * Mathf.PI / 180) * forca;
            float yComponent = Mathf.Sin(angulo * Mathf.PI / 180) * forca;

            bola.AddForce(xComponent, yComponent, 0, ForceMode.Impulse);

            forca = 0f;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            if (forca < 10f)
            {
                forca += 0.05f;
            }
        }
    }
}
