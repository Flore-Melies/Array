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

public class ThirdCell
{
    public GameObject Prefab;
    public bool IsTaken;

    public ThirdCell(GameObject obj)
    {
        Prefab = obj;
        var coinFlip = Random.Range(0, 2);
        IsTaken = coinFlip == 1;
    }
}
