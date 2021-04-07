using UnityEngine;


/// <summary>
/// Code d'exemple de création d'un taleau en dehors de l'inspector
/// </summary>
public class Scene4 : MonoBehaviour
{
    [SerializeField] private GameObject toSpawn;
    [SerializeField] private int arraySize;

    private void Start()
    {
        // On enregistre dans la variable "array" un tableau de GameObjects avec une taille équivalente à arraySize
        var array = new GameObject[arraySize];
        var pos = Vector3.zero;
        // On initialise le tableau en donnant une valeur à chacune des cases de ce dernier
        for(var i = 0; i< array.Length; i++)
        {
            pos.x = i;
            // La case numéro "i" est remplie par un instance du prefab "toSpawn"
            array[i] = Instantiate(toSpawn, pos, Quaternion.identity);
        }

        // On peut itérer sur tous les éléments du tableau maintenant qu'il est initialisé
        foreach (var obj in array)
        {
            Debug.Log(obj.transform.position);
        }
    }
}
