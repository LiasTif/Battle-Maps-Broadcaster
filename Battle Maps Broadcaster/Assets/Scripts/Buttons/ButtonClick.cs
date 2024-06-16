using Assets.Scripts.Interfaces;
using UnityEngine;

public class ButtonClick : MonoBehaviour, IButtonClick
{
    public enum ButtonCommand
    {
        Shutdown,
        Redirect
    }

    [SerializeField]
    private ButtonCommand Command;

    public void ExecuteButtonCommand()
    {
        if (Command == ButtonCommand.Shutdown)
        {
            Shutdown.Execute();
            Debug.Log("Quit");
        }
    }
}