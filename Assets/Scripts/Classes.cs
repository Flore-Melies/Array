using UnityEngine;

/// <summary>
/// Utilisée dans la scene 5
/// </summary>
public class Cell
{
    public bool IsTaken;

    /// <summary>
    /// Constructeur
    /// </summary>
    public Cell()
    {
        var coinFlip = Random.Range(0, 2);
        IsTaken = coinFlip == 1;
    }
}

/// <summary>
/// Utilisée dans les scenes 6 et 8
/// </summary>
public class SecondCell
{
    public GameObject Prefab;

    /// <summary>
    /// Constructeur
    /// </summary>
    public SecondCell(GameObject obj)
    {
        Prefab = obj;
    }
}

/// <summary>
/// Utilisée dans la scène 9
/// </summary>
public class ThirdCell
{
    public GameObject Prefab;
    public bool IsTaken;

    /// <summary>
    /// Constructeur
    /// </summary>
    public ThirdCell(GameObject obj)
    {
        Prefab = obj;
        var coinFlip = Random.Range(0, 2);
        IsTaken = coinFlip == 1;
    }
}
