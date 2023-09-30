using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour
{

    public int velocidadeM = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            FindObjectOfType<GameManager>().TirarMoedas(1);
            Destroy(gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * velocidadeM * Time.deltaTime,Space.World);
    }
}
