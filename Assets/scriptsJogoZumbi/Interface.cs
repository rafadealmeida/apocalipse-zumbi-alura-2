using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interface : MonoBehaviour
{
    private controlaJogador scriptControlaJogador;
    public Slider SliderVidaJogador;
    
    // Start is called before the first frame update
    void Awake()
    {
        scriptControlaJogador = GameObject.FindWithTag("Player").GetComponent<controlaJogador>();

        SliderVidaJogador.maxValue =100; //scriptControlaJogador.statusJogador.Vida;
       AtualizarSliderVidaJogador();
    }
    
    public void AtualizarSliderVidaJogador(){
        SliderVidaJogador.value = scriptControlaJogador.statusJogador.Vida;
    }
}
