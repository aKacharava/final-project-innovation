using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageBox : MonoBehaviour
{
    [SerializeField]
    GameObject panelUI;

    public void CloseMessageBox()
    {
        Time.timeScale = 1;
        panelUI.SetActive(false);
    }

    public void OpenMessageBox()
    {
        panelUI.SetActive(true);
    }
}
