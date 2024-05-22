using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;



public class getObject : MonoBehaviour
{


    GameObject lixoMetal;
    GameObject lixoVidro;
    GameObject lixoPapel;
    GameObject lixoPlastico;

    private MensagemLimit messageController;
    private PlayerInventory playerInventory;
    int contadorVidro;
    int contadorMetal;
    int contadorPapel;
    int contadorPlastico;


    private void Start()
    {
        messageController = FindObjectOfType<MensagemLimit>();
        lixoMetal = GameObject.FindGameObjectWithTag("TrashMetal");
        lixoVidro = GameObject.FindGameObjectWithTag("TrashVidro");
        lixoPapel = GameObject.FindGameObjectWithTag("TrashPapel");
        lixoPlastico = GameObject.FindGameObjectWithTag("TrashPlastico");
    }

    void OnTriggerEnter(Collider other)
    {
        playerInventory = other.GetComponent<PlayerInventory>();


        if (playerInventory != null)
        {
            if (gameObject.CompareTag("TrashMetal"))
            {

                if (playerInventory.NumdeLixosMetal < 10)
                {

                    playerInventory.lixoColetadoMetal();

                    gameObject.SetActive(false);
                    Invoke(nameof(Respawn), 60f); ;
                    gameObject.GetComponent<SphereCollider>().enabled = false;

                }
                else
                {

                    gameObject.GetComponent<Collider>().enabled = false;

                }
            }

            if (gameObject.CompareTag("TrashVidro"))
            {

                if (playerInventory.NumdeLixosVidro < 10)
                {
                 
                    playerInventory.lixoColetadoVidro();

                    gameObject.SetActive(false);
                    Invoke(nameof(Respawn), 40f); ;
                    gameObject.GetComponent<SphereCollider>().enabled = false;

                }
                else
                {

                    gameObject.GetComponent<Collider>().enabled = false;

                }

            }
            if (gameObject.CompareTag("TrashPapel"))
            {

                if (playerInventory.NumdeLixosPapel < 10)
                {

                    playerInventory.lixoColetadoPapel();

                    gameObject.SetActive(false);
                    Invoke(nameof(Respawn), 20f); ;
                    gameObject.GetComponent<SphereCollider>().enabled = false;

                }
                else
                {

                    gameObject.GetComponent<Collider>().enabled = false;

                }
            }
            if (gameObject.CompareTag("TrashPlastico"))
            {

                if (playerInventory.NumdeLixosPlastico < 10)
                {

                    playerInventory.lixoColetadoPlastico();

                    gameObject.SetActive(false);
                    Invoke(nameof(Respawn), 35f); ;
                    gameObject.GetComponent<SphereCollider>().enabled = false;

                }
                else
                {

                    gameObject.GetComponent<Collider>().enabled = false;

                }
            }


        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (contadorVidro ==1)
        {
            messageController.HideMessage();
            contadorVidro = 0;
        }
        if (contadorMetal == 1)
        {
            messageController.HideMessage();
            contadorMetal = 0;
        }
        if (contadorPapel == 1)
        {
            messageController.HideMessage();
            contadorPapel = 0;
        }
        if (contadorPlastico == 1)
        {
            messageController.HideMessage();
            contadorPlastico = 0;

        }
    }

    void OnTriggerStay(Collider other)
    {
      
        if (playerInventory.NumdeLixosVidro == 10 && gameObject.CompareTag("TrashVidro"))
            {
            
                messageController.ShowMessage("você atingiu o limite de lixos verdes!");
            contadorVidro = 1;

            }
        if (playerInventory.NumdeLixosMetal == 10 && gameObject.CompareTag("TrashMetal"))
        {

            messageController.ShowMessage("você atingiu o limite de lixos amarelos!");
            contadorMetal = 1;

        }
        if (playerInventory.NumdeLixosPapel == 10 && gameObject.CompareTag("TrashPapel"))
        {

            messageController.ShowMessage("você atingiu o limite de lixos azuis!");
            contadorPapel = 1;

        }
        if (playerInventory.NumdeLixosPlastico == 10 && gameObject.CompareTag("TrashPlastico"))
        {

            messageController.ShowMessage("você atingiu o limite de lixos vermelhos!");
            contadorPlastico = 1;

        }


        // Se o jogador não atingiu o limite e o inventário é válido, garanta que a mensagem esteja oculta

    }
  


    private void Respawn()
    {
        gameObject.SetActive(true);
        gameObject.GetComponent<SphereCollider>().enabled = true;
    }

}




