using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITitle : MonoBehaviour
{
    public Button button;

    private void Start()
    {
        button.onClick.AddListener(OnClickStartButton);
    }
    public void OnClickStartButton()
    {
        MoveScene.Instance.MoveToScene("Lobby");
    }
}
