using UnityEngine;
using UnityEngine.InputSystem;

public class Scene2 : MonoBehaviour
{

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
    }

    /// <summary>
    /// Foreach
    /// </summary>
    private void FirstIteration()
    {
        foreach (var prefab in prefabsToSpawn)
        {
            Instantiate(prefab);
        }
    }

    /// <summary>
    /// While
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
    /// For
    /// </summary>
    private void ThirdIteration()
    {
        var pos = Vector3.zero;
        for (var i = 0; i < prefabsToSpawn.Length; i++)
        {
            pos.x = i;
            Instantiate(prefabsToSpawn[i], pos, Quaternion.identity);
        }
    }
    // TODO: À l’aide des tag, récupérer un tableau d’objets préexistants et tous les Destroy
}
