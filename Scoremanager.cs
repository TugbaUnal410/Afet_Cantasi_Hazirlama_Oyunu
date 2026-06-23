using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Linq;

public class ScoreTableManager : MonoBehaviour
{
public TMP_Text bilgeDedeText;


public AudioSource bilgilendirmeAudio;

public TMP_InputField inputPlayerName;

public TMP_Text scoreText;

class Oyuncu
{
    public string isim;
    public int puan;

    public Oyuncu(string isim, int puan)
    {
        this.isim = isim;
        this.puan = puan;
    }
}

public void Bilgilendirme()
{
    if (bilgilendirmeAudio.isPlaying)
    {
        bilgilendirmeAudio.Stop();

        bilgeDedeText.text = "";

        CancelInvoke("YaziyiKapat");
    }
    else
    {
        bilgeDedeText.text =
        "Bilge Dede 112 sesli bilgilendirmeyi yapıyor...";

        bilgilendirmeAudio.Play();

        Invoke(
            "YaziyiKapat",
            bilgilendirmeAudio.clip.length
        );
    }
}

void YaziyiKapat()
{
    bilgeDedeText.text = "";
}

public void Kaydet()
{
    string oyuncuAdi = inputPlayerName.text;

    if (string.IsNullOrEmpty(oyuncuAdi))
    {
        oyuncuAdi = "İsimsiz Oyuncu";
    }

    int oyuncuPuani =
        PlayerPrefs.GetInt("SonPuan", 0);

    List<Oyuncu> oyuncular =
        new List<Oyuncu>()
    {
        new Oyuncu("Fatma",100),
        new Oyuncu("Emre",95),
        new Oyuncu("Emel",85),
        new Oyuncu("Ayşe",70),
        new Oyuncu("Mehmet",60),
        new Oyuncu("Kadir",50),
        new Oyuncu("Zeynep",40),
        new Oyuncu("Gokhan",35),
        new Oyuncu("Peri",25),

        new Oyuncu(
            oyuncuAdi,
            oyuncuPuani
        )
    };

    oyuncular = oyuncular
        .OrderByDescending(x => x.puan)
        .ToList();

    string tablo = "SIRALAMA\n";

    for (int i = 0; i < oyuncular.Count; i++)
    {
        tablo +=
            (i + 1) + ". " +
            oyuncular[i].isim +
            " - " +
            oyuncular[i].puan +
            "\n";
    }

    scoreText.text = tablo;
}

public void Kapat()
{
    SceneManager.LoadScene("Menu");
}


}
