using UnityEngine;

public class Cell
{
    public bool IsTaken;

    public Cell()
    {
        var coinFlip = Random.Range(0, 2);
        IsTaken = coinFlip == 1;
    }
}

public class SecondCell
{
    public GameObject Prefab;
    public SecondCell(GameObject obj)
    {
        Prefab = obj;
    }
}
