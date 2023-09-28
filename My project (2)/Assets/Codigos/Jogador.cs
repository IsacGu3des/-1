using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador: MonoBehaviour
{
    public int velocidade = 10;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out rb);
    }

    // Update is called once per frame
    void Update()
    {
        float J = Input.GetAxis("Jump");
        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(H,J,V)* velocidade);
    }
}
