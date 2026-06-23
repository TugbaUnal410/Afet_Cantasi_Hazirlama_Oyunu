using UnityEngine;
using TMPro;
using System.Collections;

public class UyariManager : MonoBehaviour
{
    public TMP_Text uyariText;

    public void ShowMessage(string mesaj)
    {
        StopAllCoroutines();
        StartCoroutine(ShowRoutine(mesaj));
    }

    IEnumerator ShowRoutine(string mesaj)
    {
        uyariText.gameObject.SetActive(true);

        uyariText.text = mesaj;

        yield return new WaitForSeconds(2f);

        uyariText.gameObject.SetActive(false);
    }
}