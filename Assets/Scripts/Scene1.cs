using UnityEngine;
using UnityEngine.InputSystem;

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

    private void OnSpawnPerformed(InputAction.CallbackContext obj)
    {
        FirstIteration();
    }

    /// <summary>
    /// Façon naive de faire
    /// </summary>
    private void FirstIteration()
    {
        var pos = Vector3.zero;
        Instantiate(prefabToSpawn, pos, Quaternion.identity);
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
