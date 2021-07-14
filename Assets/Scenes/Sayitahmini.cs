using System.Collections;
using System.Collections.Generic;
using UnityEngine; // impo. for unity 

public class Sayitahmini : MonoBehaviour
{
    int max ;               // heryerden ulaşılsın diye global olarak tanımladık.degerleri sildik cunku oyunabasla fonk da kullandık
    int min ;
    int tahmin ;

    // Start is called before the first frame update

    void Start()
    {
        Oyunabasla();
         
    }
      // Encapsulation
    void Oyunabasla()
    {
        min = 1;
        max = 1500;
        tahmin = 750;
        Debug.Log("....Sayi Tahmini oyunu başlıyor....");
        Debug.Log("Aklindan bir sayi tut ve bu sayiyi sakin bana söyleme!!");
        // print("printtede ekrana yazı yazdırılır ama Debug.Log Unity icin daha kullanıslıdır");
        Debug.Log(+min + "   ile    " + max + " arasında bir sayi tut.");
        Debug.Log("Tuttuğun sayı 750 mi?");
        Debug.Log("Yukarı bas =Yükselt  ,  Aşağı bas =Azalt  Entere bas=Doğru");
        max += 1;

    }
    // Update is called once per frame
    void Update()
    {
        // 750 - 1500
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = tahmin;
            SonrakiTahmin();
            Debug.Log("Yukarı oka basıldı."+tahmin);
        }
        // 1-750 
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = tahmin;
            SonrakiTahmin();
            Debug.Log("Aşağı oka basıldı."+tahmin);
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter a basıldı.");
        }

        void SonrakiTahmin()
        {
            tahmin = (max + min) / 2;

         }
       
    }
}
