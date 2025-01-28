using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGenerator : MonoBehaviour
{
    // R�f�rence � l'asset (GameObject)
    public GameObject treegenAsset;

    // Plage al�atoire pour la position du GameObject
    public Vector3 spawnRange = new Vector3(50f, 0f, 50f); // Plage ajust�e � 50

    // Position de base o� le GameObject peut appara�tre
    public Vector3 spawnPosition = new Vector3(0, 0, 0);

    void Update()
    {
        // V�rifie si la touche "T" est press�e
        if (Input.GetKeyDown(KeyCode.T))
        {
            // Calcule une position al�atoire dans la plage sp�cifi�e
            Vector3 randomPosition = new Vector3(
                Random.Range(-spawnRange.x, spawnRange.x) + spawnPosition.x,
                spawnPosition.y, // La position Y reste fixe
                Random.Range(-spawnRange.z, spawnRange.z) + spawnPosition.z
            );

            // Affiche la position g�n�r�e dans la console
            Debug.Log("Position al�atoire g�n�r�e: " + randomPosition);

            // Cr�e une rotation al�atoire (par exemple sur l'axe Y)
            Quaternion randomRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);

            // Instancie l'asset � la position al�atoire avec une rotation al�atoire
            if (treegenAsset != null)
            {
                Instantiate(treegenAsset, randomPosition, randomRotation);
            }
            else
            {
                Debug.LogError("Aucun asset assign� !");
            }
        }
    }
}
