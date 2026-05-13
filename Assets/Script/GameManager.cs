using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public int score;

    protected override void Awake()
    {
        base.Awake();
    }
}