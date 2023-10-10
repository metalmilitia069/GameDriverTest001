using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CanvasUI : MonoBehaviour
{
    [SerializeField]
    private Button _messageButton;
    [SerializeField]
    private TMP_Text _textMeshPro;

    private void Awake()
    {
        _messageButton.onClick.AddListener(ShowMessage);
        //EventsLib.onMessageButtonPressed += ShowMessage;
    }

    public void ShowMessage()
    {
        _textMeshPro.text = "Hello World!";
    }

    private void OnDisable()
    {
        _messageButton.onClick.RemoveAllListeners();
        //EventsLib.onMessageButtonPressed += ShowMessage;
    }
}
