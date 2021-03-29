using UnityEngine;

public class Scene5 : MonoBehaviour
{

    [SerializeField] private int lineSize;
    [SerializeField] private GameObject[] prefabs;

    private SecondCell[] cells;
    private void Start()
    {
        cells = new SecondCell[lineSize];
        var pos = Vector3.zero;
        for (var i = 0; i < lineSize; i++)
        {
            cells[i] = new SecondCell(prefabs[Random.Range(0,prefabs.Length)]);
        }

        for (var i = 1; i < lineSize - 1; i++)
        {
            if (cells[i - 1].Prefab == cells[i + 1].Prefab)
            {
                cells[i].Prefab = cells[i - 1].Prefab;
            }
        }

        for (var i = 0; i < lineSize; i++)
        {
            pos.x = i;
            Instantiate(cells[i].Prefab, pos, Quaternion.identity);
        }
    }
}
