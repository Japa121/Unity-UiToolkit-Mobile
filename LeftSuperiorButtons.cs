using Kamgam.UIToolkitVisualScripting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LeftSuperiorButtons : MonoBehaviour
{
    
    public VisualTreeAsset uiTreeAsset;
    public VisualElement root;

    #region Buttons
    public Button Status_btn;
    public Button Vending_btn;
    public Button CloseVending_btn;
    public Button Skills_btn;
    public Button CloseSkills_btn;
    public Button Passive_btn;
    public Button Action_btn;
    public Button CloseStatusPlayer_btn;
    public Button PlusCon_btn;
    public Button MinusCon_btn;
    public Button PlusDes_btn;
    public Button MinusDes_btn;
    public Button PlusFor_btn;
    public Button MinusFor_btn;
    public Button PlusInt_btn;
    public Button MinusInt_btn;
    public Button CancelStatus_btn;
    public Button OkStatus_btn;
    #endregion

    #region VisualElements
    public VisualElement LeftSuperiorPanel;
    public VisualElement PlayerInformationPanel;
    public VisualElement IconProfilePlayerInformation;
    public VisualElement PlayerMoveIcon;
    public VisualElement Vending;
    public VisualElement Vending_Header;
    public VisualElement VendingItens;
    public VisualElement ItemVendingItens;
    public VisualElement ItemVendingView;
    public VisualElement StatusPlayer;
    public VisualElement StatusScreen;
    public VisualElement StatusProfileScreen;
    public VisualElement AttributesScreen;
    public VisualElement AttributesPoints;
    public VisualElement Skills;
    public VisualElement SwitchOptionsSkills;
    public VisualElement SkillBody;
    public VisualElement Skill1;
    public VisualElement Skill2;
    public VisualElement Skill3;
    public VisualElement Skill4;
    public VisualElement Skill5;
    public VisualElement Skill6;
    public VisualElement Skill7;
    public VisualElement Skill8;
    public VisualElement Skill9;
    public VisualElement Skill10;
    public VisualElement PassiveBody;
    public VisualElement Passive1;
    public VisualElement Passive2;
    public VisualElement Passive3;
    public VisualElement Passive4;
    public VisualElement Passive5;
    public VisualElement Passive6;
    public VisualElement Passive7;
    public VisualElement Passive8;
    public VisualElement Passive9;
    public VisualElement Passive10;
    public VisualElement ActionBody;
    public VisualElement Action1;
    public VisualElement Action2;
    public VisualElement Action3;
    public VisualElement Action4;
    public VisualElement Action5;
    public VisualElement Action6;
    public VisualElement Action7;
    public VisualElement Action8;
    public VisualElement Action9;
    public VisualElement Action10;
    #endregion

    //Left Superior Hud Boolean Values
    private bool isStatusVisible = false;
    private bool isVendingVisible = false;
    private bool isSkillsVisible = false;

    // Start is called before the first frame update
    public void Awake()
    {
        // Ui Left Superior Buttons
        var root = GetComponent<UIDocument>().rootVisualElement;
        Status_btn = root.Q<Button>("Status_btn");
        CloseStatusPlayer_btn = root.Q<Button>("CloseStatusPlayer_btn");
        Vending_btn = root.Q<Button>("Vending_btn");
        CloseVending_btn = root.Q<Button>("CloseVending_btn");
        Skills_btn = root.Q<Button>("Skills_btn");
        CloseSkills_btn = root.Q<Button>("CloseSkills_btn");
        PlusCon_btn = root.Q<Button>("PlusCon_btn");
        MinusCon_btn = root.Q<Button>("MinusCon_btn");
        PlusDes_btn = root.Q<Button>("PlusDen_btn");
        MinusDes_btn = root.Q<Button>("MinusDen_btn");
        PlusFor_btn = root.Q<Button>("PlusFor_btn");
        MinusFor_btn = root.Q<Button>("MinusFor_btn");
        PlusInt_btn = root.Q<Button>("PlusInt_btn");
        MinusInt_btn = root.Q<Button>("MinusInt_btn");
        CancelStatus_btn = root.Q<Button>("CancelStatus_btn");
        OkStatus_btn = root.Q<Button>("OkStatus_btn");

        // Ui Left Superior VisualElements
        StatusPlayer = root.Q<VisualElement>("StatusPlayer");
        Vending = root.Q<VisualElement>("Vending");
        Skills = root.Q<VisualElement>("Skills");

        // Ui Buttons Registro
        Status_btn.clicked += OnStatusButtonClick;
        CloseStatusPlayer_btn.clicked += OnCloseStatusButtonClick;
        Skills_btn.clicked += OnSkillsButtonClick;
        CloseSkills_btn.clicked += OnCloseSkillsButtonClick;
        Vending_btn.clicked += OnVendingButtonClick;
        CloseVending_btn.clicked += OnCloseVendingButtonClick;
    }

    void OnSkillsButtonClick()
    {
        Debug.Log("Botão do Skills Clicado");
        isSkillsVisible = !isSkillsVisible;

        if(isSkillsVisible) 
        {
            ShowSkillsPanel();
        }
    }

    void ShowSkillsPanel()
    {
        Skills.style.display = DisplayStyle.Flex;
    }

    void OnCloseSkillsButtonClick()
    {
        isSkillsVisible = false;
        Skills.style.display = DisplayStyle.None;
    }

    void OnStatusButtonClick()
    {
        Debug.Log("Botão do Status Clicado");
        isStatusVisible = !isStatusVisible;

        if(isStatusVisible ) 
        {
            ShowStatusPanel();
        }
    }

    void ShowStatusPanel()
    {
        StatusPlayer.style.display = DisplayStyle.Flex;
    }

    void OnCloseStatusButtonClick()
    {
        isStatusVisible = false;
        StatusPlayer.style.display = DisplayStyle.None;
    }

    void OnVendingButtonClick()
    {
        Debug.Log("Botão do Vending Clicado");
        isVendingVisible = !isVendingVisible;

        if( isVendingVisible )
        {
            ShowVending();
        }
    }

    void ShowVending()
    {
        Vending.style.display = DisplayStyle.Flex;
    }

    void OnCloseVendingButtonClick()
    {
        isVendingVisible = false;
        Vending.style.display = DisplayStyle.None; 
    }
}
