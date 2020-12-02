using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyunKontrol2 : MonoBehaviour
{
    public UnityEngine.UI.Text altinTxt;
    public bool oyunAktif=true;
    public int altinSayisi=0;
    public UnityEngine.UI.Button baslaButonu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
        
    }
    public void AltinArttir(){
        altinSayisi+=1;
        altinTxt.text="Coins: "+altinSayisi;
    }
    public void OyunaBasla(){
    
   
    
          baslaButonu.gameObject.SetActive(false);
     oyunAktif=true;
        
    }
}
