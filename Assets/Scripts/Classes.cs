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
