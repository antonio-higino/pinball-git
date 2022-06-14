using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toco : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject destino;
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
        Vector3 velocity = ballBody.velocity;
        velocity.z = 0;

        coll.gameObject.GetComponent<LancarBola>().pontuacao +=  500;

        Debug.Log("Pontuacao: " + coll.gameObject.GetComponent<LancarBola>().pontuacao);


        if (gameObject.name == "Toco_2")
        {
            ballBody.position = new Vector3(2.08f, 6.66f, -11.65f);
        }
        else if (gameObject.name == "Toco_1")
        {
            ballBody.position = new Vector3(1.93f, 6.72f, -4.48f);
        }

        ballBody.velocity = velocity;
    }
}
