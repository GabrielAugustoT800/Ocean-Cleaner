using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour

{
    public int NumdeLixosMetal { get; set; }
    public int NumdeLixosVidro { get; set; }
    public int NumdeLixosPapel { get; set; }
    public int NumdeLixosPlastico { get; set; }
    public int contadorlixos;
    private MensagemLimit messageController;
    public UnityEvent<PlayerInventory> OnlixoColetadoMetal;
    public UnityEvent<PlayerInventory> OnlixoColetadoVidro;
    public UnityEvent<PlayerInventory> OnlixoColetadoPapel;
    public UnityEvent<PlayerInventory> OnlixoColetadoPlastico;
    public bool canCollectMetal = true;
    public bool canCollectVidro = true;
    public bool canCollectPapel = true;
    public bool canCollectPlastico = true;
    public void lixoColetadoMetal()
    {
        

        if ((canCollectMetal && NumdeLixosMetal < 10))
        {
            
            NumdeLixosMetal++;
            OnlixoColetadoMetal.Invoke(this);
            Debug.Log("passou aqui2:" + NumdeLixosMetal);



        }
      



        else if (NumdeLixosMetal >= 10)
        {
            canCollectMetal = false;
            Debug.Log("O player não consegue mais coletar metal");
        }
        ////////////////////////////////////////////////////////////////////////////////////



    }
    public void lixoColetadoVidro()
    {

        if ((canCollectVidro && NumdeLixosVidro < 10))
        {

            NumdeLixosVidro++;
            OnlixoColetadoVidro.Invoke(this);
           Debug.Log("passou aqui:"+NumdeLixosVidro);




        }




        else if (NumdeLixosVidro >= 10)
        {
            canCollectVidro = false;
            Debug.Log("O player não consegue mais coletar vidro");
        }
    }
    public void lixoColetadoPapel()
    {

        if ((canCollectPapel && NumdeLixosPapel < 10))
        {

            NumdeLixosPapel++;
            OnlixoColetadoPapel.Invoke(this);
            Debug.Log("coletou -" + NumdeLixosPapel+ "papel");




        }




        else if (NumdeLixosPapel >= 10)
        {
            canCollectPapel = false;
            Debug.Log("O player não consegue mais coletar papel");
        }
    }
    public void lixoColetadoPlastico()
    {

        if ((canCollectPlastico && NumdeLixosPlastico < 10))
        {

            NumdeLixosPlastico++;
            OnlixoColetadoPlastico.Invoke(this);
            Debug.Log("coletou -" + NumdeLixosPlastico + "plastico");




        }




        else if (NumdeLixosPlastico >= 10)
        {
            canCollectPlastico = false;
            Debug.Log("O player não consegue mais coletar plastico");
        }
    }
    private void Start()
    {
        canCollectMetal = true;
        canCollectVidro = true;
        canCollectPapel = true;
        canCollectPlastico = true;
    }

    private void Update()
    {


        if (FindObjectOfType<DespejoLixo>().Colocou == true) 
        { 
            canCollectMetal = true;
            canCollectVidro = true;
            canCollectPapel = true;
            canCollectPlastico = true;
        }
       
    }
   
   
}
