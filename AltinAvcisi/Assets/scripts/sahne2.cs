using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahne2 : MonoBehaviour
{
    public oyunKontrol2 oyunKontrol2;
    public UnityEngine.UI.Text altinSonucTxt;

    
    // Start is called before the first frame update
    void Start()
    {
     
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    public void yenidenOyna(){
        SceneManager.LoadScene("SampleScene");
    }
  
}
