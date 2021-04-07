using UnityEngine;

/// <summary>
/// Code d'exemple d'un tableau à deux dimensions
/// </summary>
public class Scene8 : MonoBehaviour
{
    [SerializeField] private int lineSizeX, lineSizeY;
    [SerializeField] private GameObject[] prefabs;

    // Le nombre de virgules entre [] détermine le nombre de dimensions du tableau
    // 0 virgule = 1 dimension, 1 virgule = 2 dimensions etc.
    private SecondCell[,] cells;

    private void Start()
    {
        // On doit déclarer la taille de chaque dimension de notre tableau
        cells = new SecondCell[lineSizeX, lineSizeY];
        var pos = Vector3.zero;
        // On fait une double boucle for pour pouvoir itérer sur tous les éléments du tableau
        // Nombre de for imbriqués = nombre de dimensions du tableau
        for (var i = 0; i < lineSizeX; i++)
        {
            for (var j = 0; j < lineSizeY; j++)
            {
                // On initialise chaque case du tableau avec une nouvelle cellule qui contient un prefab aléatoire
                // Comme le tableau possède 2 dimensions, on doit préciser l'index pour chacune de ces dimensions séparé par une virgule
                cells[i, j] = new SecondCell(prefabs[Random.Range(0, prefabs.Length)]);
            }
        }

        // Pour chaque cellule, si une cellule est entourée (à gauche et à droite) de 2 cellules semblables, elle prend leur apparence
        for (var i = 1; i < lineSizeX - 1; i++)
        {
            for (var j = 1; j < lineSizeY - 1; j++)
            {
                if (cells[i - 1, j].Prefab == cells[i + 1, j].Prefab)
                {
                    cells[i, j].Prefab = cells[i - 1, j].Prefab;
                }
            }
        }

        for (var i = 0; i < lineSizeX; i++)
        {
            for (var j = 0; j < lineSizeY; j++)
            {
                pos.x = i;
                pos.y = j;
                Instantiate(cells[i, j].Prefab, pos, Quaternion.identity);
            }
        }
    }

    //TODO:Reproduire la scène 9
}
