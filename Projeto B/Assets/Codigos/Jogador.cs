using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogador: MonoBehaviour
{
    private int velocidade = 10;
    private Rigidbody rb;
    public int forcaPulo = 7;
    public bool noChao;


    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out rb);
    }
    private void OnCollisionEnter(Collision collision){
        throw new NotImplementedExcepition();
    }


    // Update is called once per frame
    void Update()
    {
        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");
        if(Input.GetKeyDown(KeyCode.Space)){
            rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
        }
        
        
        Vector3 direcao = new Vector3(H,0,V);
        rb.AddForce(direcao * velocidade * Time.deltaTime,ForceMode.Impulse);

        if(transform.position.y <= -5 ){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
