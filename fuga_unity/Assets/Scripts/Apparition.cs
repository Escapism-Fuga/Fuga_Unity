using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGenerator : MonoBehaviour
{
    // Référence à l'asset (GameObject)
    public GameObject treegenAsset;

    // Plage aléatoire pour la position du GameObject
    public Vector3 spawnRange = new Vector3(50f, 0f, 50f); // Plage ajustée à 50

    // Position de base où le GameObject peut apparaître
    public Vector3 spawnPosition = new Vector3(0, 0, 0);

    void Update()
    {
        // Vérifie si la touche "T" est pressée
        if (Input.GetKeyDown(KeyCode.T))
        {
            // Calcule une position aléatoire dans la plage spécifiée
            Vector3 randomPosition = new Vector3(
                Random.Range(-spawnRange.x, spawnRange.x) + spawnPosition.x,
                spawnPosition.y, // La position Y reste fixe
                Random.Range(-spawnRange.z, spawnRange.z) + spawnPosition.z
            );

            // Affiche la position générée dans la console
            Debug.Log("Position aléatoire générée: " + randomPosition);

            // Crée une rotation aléatoire (par exemple sur l'axe Y)
            Quaternion randomRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);

            // Instancie l'asset à la position aléatoire avec une rotation aléatoire
            if (treegenAsset != null)
            {
                Instantiate(treegenAsset, randomPosition, randomRotation);
            }
            else
            {
                Debug.LogError("Aucun asset assigné !");
            }
        }
    }
}
