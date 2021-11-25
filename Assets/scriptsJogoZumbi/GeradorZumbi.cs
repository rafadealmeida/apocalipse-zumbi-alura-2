using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorZumbi : MonoBehaviour
{
    public GameObject Zumbi;
    float contadorTempo = 0;
    public float tempoRespawn = 1;
 
    void Update()
    {
        contadorTempo +=Time.deltaTime;

        if(contadorTempo>= tempoRespawn){
            GerarNovoZumbi();
            contadorTempo = 0;
        }
        void GerarNovoZumbi()
        {   
            posicaoCriacao = AleatorizarPosicaoZumbi;
            Instantiate (Zumbi, posicaoCriacao , transform.rotation);
        }
        Vector3 AleatorizarPosicaoZumbi()
        {
            float raio = 3f;
            Vector3 position = Random.insideUnitSphere*raio;
            posicao+=transform.position;
            posicao.y = 0;

            return posicao;
        }
    }
}
