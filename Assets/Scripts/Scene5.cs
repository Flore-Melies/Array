using UnityEngine;

/// <summary>
/// Code d'exemple d'un tableau d'instance de classe custom
/// </summary>
public class Scene5 : MonoBehaviour
{
    [SerializeField] private int lineSize;
    // Equivalent de faire 
    // [SerializeField] private GameObject takenPrefab
    // [SerializeField] private GameObject availablePrefab
    [SerializeField] private GameObject takenPrefab, availablePrefab;

    // Tableau de "cellule". Chaque cellule est une instance d'une classe écrite dans un autre fichier
    private Cell[] cells;

    private void Start()
    {
        // Création d'un tableau de cellule de taille "lineSize"
        cells = new Cell[lineSize];

        FillArray();

        ContaminateArray();

        InstantiateArray();
    }

    /// <summary>
    /// On initialise le tableau en le remplissant de nouvelles instances de la classe Cell
    /// </summary>
    private void FillArray()
    {
        for (var i = 0; i < lineSize; i++)
        {
            cells[i] = new Cell();
        }
    }

    /// <summary>
    /// Pour chaque cellule c, on vérifie si les cellules adjacentes sont prises. Si oui la cellule c devient prise également
    /// </summary>
    private void ContaminateArray()
    {
        // On itère pas sur tous les éléments du tableau mais du second élément à l'avant dernier
        // Cela évite de chercher dans une case qui n'existe pas (car les cases précedant la première ou suivant la dernière n'existent pas)
        for (var i = 1; i < lineSize - 1; i++)
        {
            if (cells[i - 1].IsTaken & cells[i + 1].IsTaken)
            {
                cells[i].IsTaken = true;
            }
        }
    }

    /// <summary>
    /// On instancie un prefab différent en fonction de si la cellule est censée être prise ou non
    /// </summary>
    private void InstantiateArray()
    {
        var pos = Vector3.zero;
        for (var i = 0; i < lineSize; i++)
        {
            pos.x = i;
            if (cells[i].IsTaken)
            {
                Instantiate(takenPrefab, pos, Quaternion.identity);
            }
            else
            {
                Instantiate(availablePrefab, pos, Quaternion.identity);
            }
        }
    }
    //TODO: Générer une lignes de cellules qui choisissent un prefab aléatoire parmi une liste, puis si une cellule est entourée de deux cellules identiques, elle est contaminée
}
