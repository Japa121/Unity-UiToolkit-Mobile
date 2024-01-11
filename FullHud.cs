using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FullHud : MonoBehaviour
{

    public VisualTreeAsset uiTreeAsset;
    public VisualElement root;


    private bool isGameplayPanelVisible = false;
    private bool isSettingsVisible = false;
    private bool isAccountSettingsVisible = false;
    private bool isAudioSettingsVisible = false;
    private bool isControlPanelVisible = false;
    private bool isGraphicsPanelVisible = false;
    private bool isWarningsPanelVisible = false;


    #region Visual Elements
    public VisualElement GameplayPanel;
    public VisualElement BackgroundGameplay;
    public VisualElement Settings;
    public VisualElement AccountSettingsPanel;
    public VisualElement AudioSettingsPanel;
    public VisualElement ControlSettingsPanel;
    public VisualElement GraphicsSettingsPanel;
    public VisualElement WarningsSettingsPanel;

    #endregion
    #region Buttons
    public Button SettingsGame_btn;
    public Button AccountSettings_btn;
    public Button AudioSettings_btn;
    public Button ControlsSettings_btn;
    public Button GraphicsSettings_btn;
    public Button WarningsSettings_btn;
    public Button CloseSettings_btn;
    #endregion

    // Start is called before the first frame update
    public void Awake()
    {
        // Ui Buttons
        var root = GetComponent<UIDocument>().rootVisualElement;
        SettingsGame_btn = root.Q<Button>("SettingsGame_btn");
        CloseSettings_btn = root.Q<Button>("CloseSettings_btn");
        AccountSettings_btn = root.Q<Button>("AccountSettings_btn");
        AudioSettings_btn = root.Q<Button>("AudioSettings_btn");
        ControlsSettings_btn = root.Q<Button>("ControlsSettings_btn");
        GraphicsSettings_btn = root.Q<Button>("GraphicsSettings_btn");
        WarningsSettings_btn = root.Q<Button>("WarningsSettings_btn");


        // Ui VisualElements
        Settings = root.Q<VisualElement>("Settings");
        AccountSettingsPanel = root.Q<VisualElement>("AccountSettingsPanel");
        AudioSettingsPanel = root.Q<VisualElement>("AudioSettingsPanel");
        ControlSettingsPanel = root.Q<VisualElement>("ControlSettingsPanel");
        GraphicsSettingsPanel = root.Q<VisualElement>("GraphicsSettingsPanel");
        WarningsSettingsPanel = root.Q<VisualElement>("WarningsSettingsPanel");


        // Registro
        SettingsGame_btn.clicked += OnSettingsButtonClick;
        CloseSettings_btn.clicked += OnCloseSettingsButtonClick;
        AccountSettings_btn.clicked += OnAccountSettingsButtonClick;
        AudioSettings_btn.clicked += OnAudioSettingsButtonClick;
        ControlsSettings_btn.clicked += OnControlSettingsButtonClick;
        GraphicsSettings_btn.clicked += OnGraphicsSettingsButtonClick;
        WarningsSettings_btn.clicked += OnWarningsSettingsButtonClick;


        void OnSettingsButtonClick()
        {
            Debug.Log("Botão Settings Clicado");

            isSettingsVisible = !isSettingsVisible;

            if (isSettingsVisible)
            {
                ShowSettings();
                ShowAccountPanel();
            }

        }
        void OnCloseSettingsButtonClick()
        {
            isSettingsVisible = false;
            Settings.style.display = DisplayStyle.None;
        }
        void ShowSettings()
        {
            Settings.style.display = DisplayStyle.Flex;
        }

        void OnAccountSettingsButtonClick()
        {
            Debug.Log("Botão Account Clicado");

            isAccountSettingsVisible = !isAccountSettingsVisible;

            if (isAccountSettingsVisible)
            {
                ShowAccountPanel();
            }
        }

        void ShowAccountPanel()
        {
            isAudioSettingsVisible = false;
            isControlPanelVisible = false;
            isGraphicsPanelVisible = false;
            isWarningsPanelVisible = false;

            AccountSettingsPanel.style.display = DisplayStyle.Flex;
            AudioSettingsPanel.style.display = DisplayStyle.None;
            ControlSettingsPanel.style.display = DisplayStyle.None;
            GraphicsSettingsPanel.style.display = DisplayStyle.None;
            WarningsSettingsPanel.style.display = DisplayStyle.None;
        }

        void OnAudioSettingsButtonClick()
        {
            Debug.Log("Botão do audio clicado");
            isAudioSettingsVisible = !isAudioSettingsVisible;

            if (isAudioSettingsVisible)
            {
                ShowAudioPanel();
            }
        }

        void ShowAudioPanel()
        {
            isAccountSettingsVisible = false;
            isControlPanelVisible = false;
            isGraphicsPanelVisible = false;
            isWarningsPanelVisible = false;

            AudioSettingsPanel.style.display = DisplayStyle.Flex;
            AccountSettingsPanel.style.display = DisplayStyle.None;
            ControlSettingsPanel.style.display = DisplayStyle.None;
            GraphicsSettingsPanel.style.display = DisplayStyle.None;
            WarningsSettingsPanel.style.display = DisplayStyle.None;
        }
        void OnControlSettingsButtonClick()
        {
            Debug.Log("Botão de controls clicado");
            isControlPanelVisible = !isControlPanelVisible;

            if (isControlPanelVisible)
            {
                ShowControlPanel();
            }
        }

        void ShowControlPanel()
        {
            isAccountSettingsVisible = false;
            isAudioSettingsVisible = false;
            isGraphicsPanelVisible = false;
            isWarningsPanelVisible = false;

            ControlSettingsPanel.style.display = DisplayStyle.Flex;
            AudioSettingsPanel.style.display = DisplayStyle.None;
            AccountSettingsPanel.style.display = DisplayStyle.None;
            GraphicsSettingsPanel.style.display = DisplayStyle.None;
            WarningsSettingsPanel.style.display = DisplayStyle.None;
        }

        void OnGraphicsSettingsButtonClick()
        {
            Debug.Log("Botao do graphics clicado");
            isGraphicsPanelVisible = !isGraphicsPanelVisible;
            if (isGraphicsPanelVisible)
            {
                ShowGraphicsPanel();
            }
        }

        void ShowGraphicsPanel()
        {
            isAccountSettingsVisible = false;
            isAudioSettingsVisible = false;
            isControlPanelVisible = false;
            isWarningsPanelVisible = false;

            ControlSettingsPanel.style.display = DisplayStyle.None;
            AudioSettingsPanel.style.display = DisplayStyle.None;
            AccountSettingsPanel.style.display = DisplayStyle.None;
            GraphicsSettingsPanel.style.display = DisplayStyle.Flex;
            WarningsSettingsPanel.style.display = DisplayStyle.None;

        }

        void OnWarningsSettingsButtonClick()
        {
            Debug.Log("Botão do warnings clicado");
            isWarningsPanelVisible = !isWarningsPanelVisible;

            if (isWarningsPanelVisible)
            {
                ShowWarning();
            }

        }

        void ShowWarning()
        {
            isAccountSettingsVisible = false;
            isAudioSettingsVisible = false;
            isControlPanelVisible = false;
            isGraphicsPanelVisible = false;

            WarningsSettingsPanel.style.display = DisplayStyle.Flex;
            AccountSettingsPanel.style.display = DisplayStyle.None;
            AudioSettingsPanel.style.display = DisplayStyle.None;
            ControlSettingsPanel.style.display = DisplayStyle.None;
            GraphicsSettingsPanel.style.display = DisplayStyle.None;

        }
    }
}