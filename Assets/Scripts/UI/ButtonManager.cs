using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public void ClickOnLink(string link)
    {
        Application.OpenURL(link);
    }

    public void CallScreen()
    {
        Application.OpenURL("tel://3883281895");
    }
}
