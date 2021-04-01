using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Scene7 : MonoBehaviour
{

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

    private void OnDestroyPerformed(InputAction.CallbackContext obj)
    {
        foreach (var instancedGameObject in listObjects)
        {
            Destroy(instancedGameObject);
        }
    }

    private void OnSpawnPerformed(InputAction.CallbackContext obj)
    {
        var randomPrefab = list[Random.Range(0, list.Count)];
        var posX = Random.Range(-9f, 9f);
        var posY = Random.Range(-5f, 5f);
        var pos = new Vector3(posX, posY, 0);
        var instance = Instantiate(randomPrefab, pos, Quaternion.identity);
        listObjects.Add(instance);
    }

    private void Start()
    {
        listObjects = new List<GameObject>();
    }
}
