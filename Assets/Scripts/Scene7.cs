using UnityEngine;

public class Scene7 : MonoBehaviour
{
    [SerializeField] private int lineSizeX, lineSizeY;
    [SerializeField] private GameObject[] prefabs;

    private SecondCell[,] cells;

    private void Start()
    {
        cells = new SecondCell[lineSizeX, lineSizeY];
        var pos = Vector3.zero;
        for (var i = 0; i < lineSizeX; i++)
        {
            for (var j = 0; j < lineSizeY; j++)
            {
                cells[i, j] = new SecondCell(prefabs[Random.Range(0, prefabs.Length)]);
            }
        }

        for (var i = 1; i < lineSizeX - 1; i++)
        {
            for (var j = 1; j < lineSizeY - 1; j++)
            {
                if (cells[i - 1, j].Prefab == cells[i + 1, j].Prefab)
                {
                    cells[i, j].Prefab = cells[i - 1, j].Prefab;
                }
            }
        }

        for (var i = 0; i < lineSizeX; i++)
        {
            for (var j = 0; j < lineSizeY; j++)
            {
                pos.x = i;
                pos.y = j;
                Instantiate(cells[i, j].Prefab, pos, Quaternion.identity);
            }
        }
    }

    //TODO:Reproduire la scène 8
}
