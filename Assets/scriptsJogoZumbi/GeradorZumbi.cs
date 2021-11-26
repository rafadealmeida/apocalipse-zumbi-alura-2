using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorZumbi : MonoBehaviour
{
    public GameObject Zumbi;
    float contadorTempo = 0;
    public float tempoRespawn = 1;
    public LayerMask LayerZumbi;

 
    void Update()
    {
        contadorTempo +=Time.deltaTime;

        if(contadorTempo>= tempoRespawn){
            StartCoroutine(GerarNovoZumbi());
            contadorTempo = 0;
        }
        IEnumerator GerarNovoZumbi()
        {   
            Vector3 posicaoCriacao = AleatorizarPosicaoZumbi();
            Collider [] colisores = Physics.OverlapSphere(posicaoCriacao,1,LayerZumbi);
            
            while(colisores.Length>0){
            posicaoCriacao = AleatorizarPosicaoZumbi();
            colisores = Physics.OverlapSphere(posicaoCriacao,1,LayerZumbi);

            yield return null;
            }
            
            Instantiate (Zumbi, posicaoCriacao , transform.rotation);
        }
        Vector3 AleatorizarPosicaoZumbi()
        {
            float raio = 3f;
            Vector3 posicao = Random.insideUnitSphere*raio;
            posicao+=transform.position;
            posicao.y = 0;

            return posicao;
        }
    }
}
