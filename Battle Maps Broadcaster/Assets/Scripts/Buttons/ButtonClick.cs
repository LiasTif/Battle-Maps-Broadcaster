using UnityEngine;
using UnityEngine.SceneManagement;

internal class ButtonClick : MonoBehaviour
{
    [SerializeField]
    private Commad buttonCommand;
    [SerializeField]
    private int sceneNumber;

    private enum Commad
    {
        Shutdown,
        Redirect
    }

    public void ExecuteCommand()
    {
        if (buttonCommand == Commad.Redirect)
        {
            RedirectExecute();
        }
        else if (buttonCommand == Commad.Shutdown)
        {
            ShutdownExecute();
        }
    }
    private void RedirectExecute()
    {
        SceneManager.LoadScene(sceneNumber);
    }

    private void ShutdownExecute()
    {
        ShutdownCommand shutdownCommand = new();
        shutdownCommand.Execute();
    }
}