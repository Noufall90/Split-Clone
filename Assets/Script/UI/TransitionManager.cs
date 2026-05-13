using UnityEngine;

public class TransitionManager : Singleton<TransitionManager>
{
    public void FadeIn()
    {
        Debug.Log("Fade In");
    }

    public void FadeOut()
    {
        Debug.Log("Fade Out");
    }
}