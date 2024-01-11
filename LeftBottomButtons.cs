using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LeftBottomButtons : MonoBehaviour
{
    public VisualTreeAsset uiTreeAsset;
    public VisualElement root;
    #region VisualElements

    public VisualElement LeftButtonsContainer;
    public VisualElement Chat;
    #endregion

    #region Buttons
    public Button MoveJoystick_btn;
    public Button AttackL_btn;
    public Button Chat_btn;
    #endregion

    private bool isChatPanelVisible = false;
    // Start is called before the first frame update
    void Start()
    {
        var uiDocument = GetComponent<UIDocument>();
        root = uiDocument.rootVisualElement;

        Chat_btn = root.Q<Button>("Chat_btn");
        Chat = root.Q<VisualElement>("Chat");


        Chat_btn.clicked += OnChatButtonClick;
    }

    void OnChatButtonClick()
    {
        Debug.Log("Botão de Chat clicado.");

        isChatPanelVisible = !isChatPanelVisible;

        if (isChatPanelVisible)
        {
            ShowChat();
        }
        else
        {
            HideChat();
        }
    }

    void ShowChat()
    {
        Chat.style.display = DisplayStyle.Flex;
    }

    void HideChat()
    {
        Chat.style.display = DisplayStyle.None;
    }
}
