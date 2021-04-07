// using nécessaire à l'utilisation de Listes
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Code d'exemple d'une liste de GameObjects
/// </summary>
public class Scene7 : MonoBehaviour
{
    // Exemple pour l'inspecteur
    [SerializeField] private List<GameObject> list;

    private List<GameObject> listObjects;
    private Controls controls;

    private void OnEnable()
    {
        controls = new Controls();
        controls.Enable();
        controls.Main.Spawn.performed += OnSpawnPerformed;
        controls.Main.Destroy.performed += OnDestroyPerformed;
    }

    private void Start()
    {
        // Initialisation de la liste (vide pour l'instant)
        listObjects = new List<GameObject>();
    }

    /// <summary>
    /// Quand on appuie sur espace, on fait spawn un objet et on l'ajoute à la liste "list"
    /// </summary>
    /// <param name="obj"></param>
    private void OnSpawnPerformed(InputAction.CallbackContext obj)
    {
        // On choisit un prefab aléatoire
        var randomPrefab = list[Random.Range(0, list.Count)];
        // On choisit une position aléatoire comprise dans les limites de la caméra
        var posX = Random.Range(-9f, 9f);
        var posY = Random.Range(-5f, 5f);
        var pos = new Vector3(posX, posY, 0);
        // On instancie l'objet
        var instance = Instantiate(randomPrefab, pos, Quaternion.identity);
        // On ajoute l'objet instancié à la liste
        listObjects.Add(instance);
    }

    /// <summary>
    /// Quand on appuie sur Entrée, on détruit tous les objets contenus dans la liste "list"
    /// </summary>
    /// <param name="obj"></param>
    private void OnDestroyPerformed(InputAction.CallbackContext obj)
    {
        foreach (var instancedGameObject in listObjects)
        {
            Destroy(instancedGameObject);
        }
    }
}
