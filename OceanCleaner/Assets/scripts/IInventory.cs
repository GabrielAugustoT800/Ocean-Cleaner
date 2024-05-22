using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class IInventory: MonoBehaviour
{
  
    public TextMeshProUGUI lixoMetal;
    public TextMeshProUGUI lixoVidro;
    public TextMeshProUGUI lixoPapel;
    public TextMeshProUGUI lixoPlastico;
    public int contadorx;

    void Start()
    {
       
        lixoMetal = GetComponent<TextMeshProUGUI>();
        lixoVidro = GetComponent<TextMeshProUGUI>();
        lixoPapel = GetComponent<TextMeshProUGUI>();
        lixoPlastico = GetComponent<TextMeshProUGUI>();
    }


    public void UpdatelixoMetalText(PlayerInventory player)
    {

        lixoMetal.SetText(player.NumdeLixosMetal.ToString());
        Debug.Log(player.NumdeLixosMetal);
        if (FindObjectOfType<DespejoLixo>().Colocou == true)
        {
            lixoMetal.SetText("0");
            FindObjectOfType<DespejoLixo>().Colocou = false;

        }

    }
    public void UpdatelixoVidroText(PlayerInventory player)
    {

        lixoVidro.SetText(player.NumdeLixosVidro.ToString());
        Debug.Log(player.NumdeLixosVidro);


    }
    public void UpdatelixoPapelText(PlayerInventory player)
    {

        lixoPapel.SetText(player.NumdeLixosPapel.ToString());
        Debug.Log(player.NumdeLixosPapel);


    }
    public void UpdatelixoPlasticoText(PlayerInventory player)
    {

        lixoPlastico.SetText(player.NumdeLixosPlastico.ToString());
        Debug.Log(player.NumdeLixosPlastico);


    }
    private void Update()
    {
       
    }
}
