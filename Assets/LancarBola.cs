using UnityEngine;
using UnityEngine.UI;

public class LancarBola : MonoBehaviour
{
    Rigidbody bola;
    public int pontuacao;
    public Text pontuacaoText;
    public float forca = 0f;
    float angulo = 160f;
    public bool podeLancar;

    // Start is called before the first frame update
    void Start()
    {
        bola = GetComponent<Rigidbody>();
        pontuacao = 0;
        podeLancar = false;
        pontuacaoText.text = pontuacao.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        pontuacaoText.text = pontuacao.ToString();

        if (podeLancar)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                float xComponent = Mathf.Cos(angulo * Mathf.PI / 180) * forca;
                float yComponent = Mathf.Sin(angulo * Mathf.PI / 180) * forca;

                bola.AddForce(xComponent, yComponent, 0, ForceMode.Impulse);

                forca = 0f;
            }
            else if (Input.GetKey(KeyCode.Space))
            {
                if (forca < 12f)
                {
                    forca += 0.06f;
                }
            }
        }
    }
}
