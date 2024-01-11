using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RightBottomButtons : MonoBehaviour
{
    public VisualTreeAsset uiTreeAsset;
    public VisualElement root;

    #region VisualElements
    public VisualElement RightButtonsContainer;
    #endregion

    #region Buttons
    public Button Item1_btn;
    public Button Assign_btn;
    public Button AttackR_btn;
    public Button Interaction_btn;
    public Button Item2_btn;
    public Button Item3_btn;
    public Button Item4_btn;
    public Button Item5_btn;
    public Button Reload_btn;
    public Button Jump_btn;
    public Button Active_btn;
    #endregion
    void Start()
    {
        var uiDocument = GetComponent<UIDocument>();
        root = uiDocument.rootVisualElement;

    }

 
}
