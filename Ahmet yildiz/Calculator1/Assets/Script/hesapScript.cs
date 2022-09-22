using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class hesapScript : MonoBehaviour
{
    public Image imageFalse;
    public Image imageTrue;
    public InputField kullaniciDeger;
    public Text islemText;
    public int sonuc;

   public void islemUret()
    {
        int sayi1 = Random.Range(5, 10);
        int sayi2 = Random.Range(0, 5);
        int sayi3 = Random.Range(0, 3);
        string islem;
        
        string a = sayi3.ToString();
        if (sayi3 == 0)
        {
            islem = sayi1.ToString() + "-" + sayi2.ToString() + " = ?";
            sonuc = sayi1 - sayi2;
        }
        else if (sayi3 == 1)
        {
            islem = sayi1.ToString() + "- ?"  + " = "+ sayi2.ToString();
            sonuc = sayi1 - sayi2;
        }
        else
        {
            islem =  "? -" + sayi1.ToString()+ " = " + sayi2.ToString();
            sonuc = sayi1 + sayi2;
        }
        islemText.text = islem;
    }

    public void sunuc()
    {

        imageTrue.enabled = false;
        imageFalse.enabled = false;

        if (sonuc.ToString() == kullaniciDeger.text)
        {
            
            imageTrue.enabled = true;
            
            islemUret();
        }
        else
        {
           
            imageFalse.enabled = true;
        }
        
        kullaniciDeger.text = "";
    }

    public void Start()
    {
        imageTrue.enabled = false;
        imageFalse.enabled = false;

    }
}
