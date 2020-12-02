using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyuncuKontrol : MonoBehaviour
{
    public AudioClip fall, goldSound,WinSound;
    public oyunKontrol2 oyunKontrol2;
    public sahne2 sahne2;
    public float hiz= 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(oyunKontrol2.oyunAktif){
        float x= Input.GetAxis("Horizontal");
        float y=Input.GetAxis("Vertical");
        x*=Time.deltaTime * hiz;
        y*=Time.deltaTime * hiz;
        transform.Translate(x,0f,y);
        }
    }
    void OnCollisionEnter(Collision c){
        if(c.gameObject.tag.Equals("altin")){
            oyunKontrol2.AltinArttir();
            Destroy(c.gameObject);
            GetComponent<AudioSource> ().PlayOneShot(goldSound,1f);

        }else if(c.gameObject.tag.Equals("dusman")){
            oyunKontrol2.oyunAktif=false;
             GetComponent<AudioSource> ().PlayOneShot(fall,1f);
             SceneManager.LoadScene("Sonuc");
             
             
        } 
        else if(c.gameObject.tag.Equals("bitis")){
            oyunKontrol2.oyunAktif=false;
            GetComponent<AudioSource> ().PlayOneShot(WinSound,1f);
             SceneManager.LoadScene("Sonuc");
        } 
    }
}
