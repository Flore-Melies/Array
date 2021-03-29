using UnityEngine;
using UnityEngine.InputSystem;

public class Scene3 : MonoBehaviour
{

    private Controls controls;

    private void OnEnable()
    {
        controls = new Controls();
        controls.Enable();
        controls.Main.Spawn.performed += OnSpacePerformed;
    }

    private void OnSpacePerformed(InputAction.CallbackContext obj)
    {
        var toRemove = GameObject.FindGameObjectsWithTag("ToRemove");
        foreach (var sprite in toRemove)
        {
            Destroy(sprite);
        }
    }

}
