using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI HUD, GG;
    public int moedasR;
    // Start is called before the first frame update
    void Start()
    {
        moedasR = FindObjectsOfType<Moeda>().Length;
        HUD.text = $"Moedas restantes {moedasR}";
    }



    public void TirarMoedas(int Valor){
        moedasR = moedasR - Valor;
        HUD.text = $"Moedas restantes {moedasR}";
        if(moedasR <= 0){
            GG.text = "Parabens";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
