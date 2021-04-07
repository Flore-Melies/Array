using UnityEngine;

/// <summary>
/// Correction de la question à la fin de Scene 8
/// </summary>
public class Scene9 : MonoBehaviour
{
    [SerializeField] private int lineSizeX, lineSizeY;
    [SerializeField] private GameObject[] prefabs;

    private ThirdCell[,] cells;
    private GameObject[,] cellsObjects;

    private void Start()
    {
        cells = new ThirdCell[lineSizeX, lineSizeY];
        cellsObjects = new GameObject[lineSizeX, lineSizeY];
        var pos = Vector3.zero;
        for (var i = 0; i < lineSizeX; i++)
        {
            for (var j = 0; j < lineSizeY; j++)
            {
                cells[i, j] = new ThirdCell(prefabs[Random.Range(0, prefabs.Length)]);
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
                cellsObjects[i, j] = Instantiate(cells[i, j].Prefab, pos, Quaternion.identity);
            }
        }

        for (var i = 0; i < lineSizeX; i++)
        {
            for (var j = 0; j < lineSizeY; j++)
            {
                if (cells[i, j].IsTaken)
                {
                    cellsObjects[i, j].GetComponent<SpriteRenderer>().color = Color.grey;
                }
            }
        }
    }
}
