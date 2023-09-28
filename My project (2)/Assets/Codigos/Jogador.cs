using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogador: MonoBehaviour
{
    private int velocidade = 10;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out rb);
    }

    // Update is called once per frame
    void Update()
    {
        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");
        
        Vector3 direcao = new Vector3(H,0,V);
        rb.AddForce(direcao * velocidade * Time.deltaTime,ForceMode.Impulse);

        if(transform.position.y <= -5 ){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
