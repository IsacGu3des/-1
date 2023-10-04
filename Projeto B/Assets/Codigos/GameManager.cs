using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private AudioSource source;
    public AudioClip clipMoeda, clipWin;
    public TextMeshProUGUI HUD, GG;
    public int moedasR;
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out source);
        moedasR = FindObjectsOfType<Moeda>().Length;
        HUD.text = $"Moedas restantes {moedasR}";
    }



    public void TirarMoedas(int Valor){
        moedasR = moedasR - Valor;
        HUD.text = $"Moedas restantes {moedasR}";
        source.PlayOneShot(clipMoeda);
        if(moedasR <= 0){
            GG.text = "Parabéns";
            source.Stop();
            source.PlayOneShot(clipWin);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
