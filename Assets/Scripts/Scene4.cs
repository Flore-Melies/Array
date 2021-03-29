using UnityEngine;

public class Scene4 : MonoBehaviour
{

    [SerializeField] private int lineSize;
    [SerializeField] private GameObject takenPrefab, availablePrefab;

    private Cell[] cells;
    private void Start()
    {
        cells = new Cell[lineSize];
        var pos = Vector3.zero;
        for (var i = 0; i < lineSize; i++)
        {
            cells[i] = new Cell();
        }

        for (var i = 1; i < lineSize - 1; i++)
        {
            if (cells[i - 1].IsTaken & cells[i + 1].IsTaken)
            {
                cells[i].IsTaken = true;
            }
        }

        for (int i = 0; i < lineSize; i++)
        {
            pos.x = i;
            if (cells[i].IsTaken)
            {
                Instantiate(takenPrefab, pos, Quaternion.identity);
            }
            else
            {
                Instantiate(availablePrefab, pos, Quaternion.identity);
            }
        }
    }
}