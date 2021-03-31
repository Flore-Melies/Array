using UnityEngine;

public class Scene4 : MonoBehaviour
{

    [SerializeField] private GameObject toSpawn;
    [SerializeField] private int arraySize;

    private void Start()
    {
        var array = new GameObject[arraySize];
        var pos = Vector3.zero;
        for(var i = 0; i< array.Length; i++)
        {
            pos.x = i;
            array[i] = Instantiate(toSpawn, pos, Quaternion.identity);
        }

        foreach (var obj in array)
        {
            Debug.Log(obj.transform.position);
        }
    }
}
