using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Correction de la question � la fin de Scene2
/// </summary>
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
        // FindGameObjectsWithTag renvoie un tableau de GameObjects ayant le tag donn� (ToRemove ici)
        var toRemove = GameObject.FindGameObjectsWithTag("ToRemove");
        // "Pour chaque �l�ment pr�sent dans le tableau toRemove
        foreach (var sprite in toRemove)
        {
            // "sprite" est ici un GameObject puisque toRemove ets un tableau de GameObjects
            Destroy(sprite);
        }
    }

}
