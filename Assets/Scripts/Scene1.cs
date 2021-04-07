using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Code d'exemple sans tableau
/// </summary>
public class Scene1 : MonoBehaviour
{

    [SerializeField] private GameObject prefabToSpawn;
    [SerializeField] private GameObject prefabToSpawn2;
    [SerializeField] private GameObject prefabToSpawn3;
    [SerializeField] private GameObject prefabToSpawn4;
    [SerializeField] private GameObject prefabToSpawn5;

    private Controls controls;

    private void OnEnable()
    {
        controls = new Controls();
        controls.Enable();
        controls.Main.Spawn.performed += OnSpawnPerformed;
    }

    /// <summary>
    /// Quand on appuie sur espace on fait spawner tous les objets
    /// </summary>
    /// <param name="obj"></param>
    private void OnSpawnPerformed(InputAction.CallbackContext obj)
    {
        // Déclaration de la variable qui va contenir la position à laquelle instancier les objets
        var pos = Vector3.zero;
        // https://docs.unity3d.com/ScriptReference/Object.Instantiate.html
        Instantiate(prefabToSpawn, pos, Quaternion.identity);
        // pos.x++ est la meme chose que pos.x += 1 qui est la meme chose que pos.x = pos.x + 1
        pos.x++;
        Instantiate(prefabToSpawn2, pos, Quaternion.identity);
        pos.x++;
        Instantiate(prefabToSpawn3, pos, Quaternion.identity);
        pos.x++;
        Instantiate(prefabToSpawn4, pos, Quaternion.identity);
        pos.x++;
        Instantiate(prefabToSpawn5, pos, Quaternion.identity);
        pos.x++;
    }
}
