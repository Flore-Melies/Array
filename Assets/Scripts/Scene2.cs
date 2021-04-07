using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Code d'exemple avec des tableaux
/// </summary>
public class Scene2 : MonoBehaviour
{
    // Ajouter [] après le type de variable: créer un tableau du type de la variable déclarée
    // Par exemple ici on crée un tableau de GameObjects
    [SerializeField] private GameObject[] prefabsToSpawn;

    private Controls controls;

    private void OnEnable()
    {
        controls = new Controls();
        controls.Enable();
        controls.Main.Spawn.performed += OnSpawnPerformed;
    }

    private void OnSpawnPerformed(InputAction.CallbackContext obj)
    {
        FirstIteration();
        //SecondIteration();
        //ThirdIteration();
    }

    /// <summary>
    /// Utilisation d'une boucle foreach pour itérer sur tous les éléments d'un tableau sans distinction
    /// </summary>
    private void FirstIteration()
    {
        foreach (var prefab in prefabsToSpawn)
        {
            Instantiate(prefab);
        }
    }

    /// <summary>
    /// Utilisation d'une boucle while pour itérer sur un nombre d'éléments arbitraire
    /// </summary>
    private void SecondIteration()
    {
        var i = 0;
        var pos = Vector3.zero;
        while (i < prefabsToSpawn.Length)
        {
            pos.x = i;
            Instantiate(prefabsToSpawn[i], pos, Quaternion.identity);
            i++;
        }
    }

    /// <summary>
    /// Utilisation d'une boucle for pour itérer sur un nombre d'éléments arbitraire avec une syntaxe plus condensée
    /// </summary>
    private void ThirdIteration()
    {
        var pos = Vector3.zero;
        for (var i = 0; i < prefabsToSpawn.Length; i++)
        {
            pos.x = i;
            // On peut accéder à une case d'un tableau en faisant "nomDuTableau[index]
            // Par exemple "prefabsToSpawn[0]" est une référence qu premier objet du tableau "prefabsToSpawn"
            Instantiate(prefabsToSpawn[i], pos, Quaternion.identity);
        }
    }
    // TODO: À l’aide des tag, récupérer un tableau d’objets préexistants et tous les Destroy
}
