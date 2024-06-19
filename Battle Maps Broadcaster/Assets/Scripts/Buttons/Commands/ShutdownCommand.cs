using UnityEngine;

public class ShutdownCommand : MonoBehaviour, IButtonCommand
{
    public void Execute()
    {
        Application.Quit();
    }
}