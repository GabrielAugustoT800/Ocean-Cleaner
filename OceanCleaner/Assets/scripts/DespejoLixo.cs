using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class DespejoLixo : MonoBehaviour
{
    GameObject player;
    GameObject cacambaMetal;
    GameObject cacambaVidro;
    GameObject cacambaPapel;
    GameObject cacambaPlastico;

    bool Zona = false;
    private MensagemLimit messageController;
    
    public bool Colocou = false;
    public int contadorLixos;
    public TextMeshProUGUI lixoTextMetal;
    public TextMeshProUGUI lixoTextVidro;
    public TextMeshProUGUI lixoTextPapel;
    public TextMeshProUGUI lixoTextPlastico;

    public UnityEvent<DespejoLixo> OnLixoFora;
    // Start is called before the first frame update
    void Start()
    {
       
        player = GameObject.FindGameObjectWithTag("barco");
        cacambaMetal = GameObject.FindGameObjectWithTag("CacambaMetal");
        cacambaVidro = GameObject.FindGameObjectWithTag("CacambaVidro");
        cacambaPapel = GameObject.FindGameObjectWithTag("CacambaPapel");
        cacambaPlastico = GameObject.FindGameObjectWithTag("CacambaPlastico");
        messageController = FindObjectOfType<MensagemLimit>();
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("barco"))
        {
            Zona = true;
            messageController.ShowMessage("Clique no botão ' E'");
           
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("barco"))
        {
            Zona = false;
            messageController.HideMessage();
        }
    }

    // Update is called once per frame
    void Update()
    {
        LixoFora();

    }
    public void UpdateJogalixoText()
    {
        

    }
    public void LixoFora()
    {
        

            if (Zona & Input.GetKeyDown(KeyCode.E))
            {
            if (gameObject.CompareTag("CacambaMetal"))
            {
                if ((player.GetComponent<PlayerInventory>().NumdeLixosMetal >= 10))
                {
                    player.GetComponent<PlayerInventory>().NumdeLixosMetal = 0;
                    lixoTextMetal.SetText("0");

                    //contadorLixos = 0;

                    Colocou = true;
                    messageController.ShowMessage("lixos amarelos dispensado!");
                }
                 else if ((player.GetComponent<PlayerInventory>().NumdeLixosMetal == 0) & (Input.GetKeyDown(KeyCode.E)))
                {
                    messageController.ShowMessage("você não tem lixos amarelos!");
                    Colocou = false;
                }
                else if ((player.GetComponent<PlayerInventory>().NumdeLixosMetal >= 1 && player.GetComponent<PlayerInventory>().NumdeLixosMetal <= 10) & (Input.GetKeyDown(KeyCode.E)))
                {
                    messageController.ShowMessage("você não tem a quantidade certa de lixos amarelos!");
                    Colocou = false;

                }

            }
            if (gameObject.CompareTag("CacambaVidro"))
            {
                if ((player.GetComponent<PlayerInventory>().NumdeLixosVidro >= 10))
                {
                    player.GetComponent<PlayerInventory>().NumdeLixosVidro -= 10;
                    contadorLixos = 0;
                    lixoTextVidro.SetText("0");
                    Colocou = true;
                    messageController.ShowMessage("lixos verdes dispensado!");
                }
                else if ((player.GetComponent<PlayerInventory>().NumdeLixosVidro == 0) & (Input.GetKeyDown(KeyCode.E)))
                {
                    messageController.ShowMessage("você não tem lixos verdes!");
                    Colocou = false;
                }
                else if ((player.GetComponent<PlayerInventory>().NumdeLixosVidro >= 1 && player.GetComponent<PlayerInventory>().NumdeLixosVidro <= 10) & (Input.GetKeyDown(KeyCode.E)))
                {
                    messageController.ShowMessage("você não tem a quantidade certa de lixos verdes!");
                    Colocou = false;

                }

            }
            if (gameObject.CompareTag("CacambaPapel"))
            {
                if ((player.GetComponent<PlayerInventory>().NumdeLixosPapel >= 10))
                {
                    player.GetComponent<PlayerInventory>().NumdeLixosPapel -= 10;
                    contadorLixos = 0;
                    lixoTextPapel.SetText("0");
                    Colocou = true;
                    messageController.ShowMessage("lixos azuis dispensado!");
                }
                else if ((player.GetComponent<PlayerInventory>().NumdeLixosPapel == 0) & (Input.GetKeyDown(KeyCode.E)))
                {
                    messageController.ShowMessage("você não tem lixos azuis!");
                    Colocou = false;
                }
                else if ((player.GetComponent<PlayerInventory>().NumdeLixosPapel >= 1 && player.GetComponent<PlayerInventory>().NumdeLixosPapel <= 10) & (Input.GetKeyDown(KeyCode.E)))
                {
                    messageController.ShowMessage("você não tem a quantidade certa de lixos azuis!");
                    Colocou = false;

                }

            }
            if (gameObject.CompareTag("CacambaPlastico"))
            {
                if ((player.GetComponent<PlayerInventory>().NumdeLixosPlastico >= 10))
                {
                    player.GetComponent<PlayerInventory>().NumdeLixosPlastico -= 10;
                    contadorLixos = 0;
                    lixoTextPlastico.SetText("0");
                    Colocou = true;
                    messageController.ShowMessage("lixos vermelhos dispensado!");
                }
                else if ((player.GetComponent<PlayerInventory>().NumdeLixosPlastico == 0) & (Input.GetKeyDown(KeyCode.E)))
                {
                    messageController.ShowMessage("você não tem lixos vermelhos!");
                    Colocou = false;
                }
                else if ((player.GetComponent<PlayerInventory>().NumdeLixosPlastico >= 1 && player.GetComponent<PlayerInventory>().NumdeLixosPlastico <= 10) & (Input.GetKeyDown(KeyCode.E)))
                {
                    messageController.ShowMessage("você não tem a quantidade certa de lixos vermelhos-!");
                    Colocou = false;

                }

            }
        }


           
        
        
    }
}
