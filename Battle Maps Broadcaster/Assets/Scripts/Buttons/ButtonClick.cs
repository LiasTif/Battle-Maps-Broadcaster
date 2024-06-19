using UnityEngine;
using UnityEngine.SceneManagement;

internal class ButtonClick : MonoBehaviour
{
    [SerializeField]
    private Commad buttonCommand;
    [SerializeField]
    private int sceneNumber;
    [SerializeField]
    private Canvas popUp;

    private enum Commad
    {
        Shutdown,
        Redirect,
        OpenPopUp
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
        else if (buttonCommand == Commad.OpenPopUp)
        {
            OpenPopUpExecute();
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

    private void OpenPopUpExecute()
    {
        popUp.enabled = !popUp.enabled;
    }
}