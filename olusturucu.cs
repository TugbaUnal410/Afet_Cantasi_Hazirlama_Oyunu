using UnityEngine;
using System.Collections.Generic;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] items;

    public Transform player;

    public float spawnDelay = 2f;

    public float spawnDistance = 20f;

    private float timer = 0f;

    // Kullanılacak karışık liste
    private List<GameObject> shuffledItems =
        new List<GameObject>();

    void Start()
    {
        RefillList();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnDelay)
        {
            SpawnItem();

            timer = 0f;
        }
    }

    void SpawnItem()
    {
        // Liste bittiyse tekrar doldur
        if (shuffledItems.Count == 0)
        {
            RefillList();
        }

        // İlk elemanı al
        GameObject item =
            shuffledItems[0];

        // Listeden kaldır
        shuffledItems.RemoveAt(0);

        // Rastgele X
        float randomX =
            Random.Range(-2f, 2f);

        // Spawn pozisyonu
        Vector3 spawnPos =
            player.position +
            new Vector3(randomX, 1f, spawnDistance);

        // Oluştur
        Instantiate(item, spawnPos, Quaternion.identity);
    }

    void RefillList()
    {
        // Listeyi temizle
        shuffledItems.Clear();

        // Tüm itemları ekle
        foreach (GameObject item in items)
        {
            shuffledItems.Add(item);
        }

        // Karıştır
        for (int i = 0; i < shuffledItems.Count; i++)
        {
            GameObject temp = shuffledItems[i];

            int randomIndex =
                Random.Range(i, shuffledItems.Count);

            shuffledItems[i] =
                shuffledItems[randomIndex];

            shuffledItems[randomIndex] = temp;
        }
    }
}