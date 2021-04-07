using UnityEngine;

/// <summary>
/// Correction de la question à la fin de Scene 5
/// </summary>
public class Scene6 : MonoBehaviour
{

    [SerializeField] private int lineSize;
    [SerializeField] private GameObject[] prefabs;

    private SecondCell[] cells;

    private void Start()
    {
        cells = new SecondCell[lineSize];
        var pos = Vector3.zero;
        for (var i = 0; i < lineSize; i++)
        {
            // Chaque case du tableau est remplie par un objet 
            // Cet objet est choisi aléatoirement parmi tous les objets disponibles dans le ableau "prefabs"
            // Equivalent de :
            // var randomIndex = Random.Range(0,prefabs.Length)
            // var chosenPrefab = prefabs[randomIndex]
            // cells[i] = new SecondCell(chosenPrefab);
            cells[i] = new SecondCell(prefabs[Random.Range(0,prefabs.Length)]);
        }

        // Pour chaque cellule, si une cellule est entourée de 2 cellules semblables, elle prend leur apparence
        for (var i = 1; i < lineSize - 1; i++)
        {
            if (cells[i - 1].Prefab == cells[i + 1].Prefab)
            {
                cells[i].Prefab = cells[i - 1].Prefab;
            }
        }

        // Pour chaque cellule, faire spawn l'objet correspondant
        for (var i = 0; i < lineSize; i++)
        {
            pos.x = i;
            Instantiate(cells[i].Prefab, pos, Quaternion.identity);
        }
    }
}
