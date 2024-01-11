using Kamgam.UIToolkitVisualScripting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RightSuperiorButtons : MonoBehaviour
{

    public VisualTreeAsset uiTreeAsset;
    public VisualElement root;

    #region VisualElements
    [Header("VisualElements")]
    public VisualElement UpRightContainer;
    public VisualElement VoucherPanel;
    public VisualElement VoucherHeader;
    public VisualElement DailyReward;
    public VisualElement DailyRewardHeader;
    public VisualElement Achievement;
    public VisualElement AchievementHeader;
    public VisualElement DailyAchievementList;
    public VisualElement OtherAchievementList;
    public VisualElement Achievement1;
    public VisualElement Bonus1_1;
    public VisualElement Bonus1_2;
    public VisualElement Bonus1_3;
    public VisualElement Achievement2;
    public VisualElement Bonus2_1;
    public VisualElement Bonus2_2;
    public VisualElement Bonus2_3;
    public VisualElement Achievement3;
    public VisualElement Bonus3_1;
    public VisualElement Bonus3_2;
    public VisualElement Bonus3_3;
    public VisualElement Achievement4;
    public VisualElement Bonus4_1;
    public VisualElement Bonus4_2;
    public VisualElement Bonus4_3;
    public VisualElement Achievement5;
    public VisualElement Bonus5_1;
    public VisualElement Bonus5_2;
    public VisualElement Bonus5_3;
    public VisualElement Leaderboard;
    public VisualElement Leaderboard_Header;
    public VisualElement Leaderboard_Options;
    public VisualElement LeaderboardLevelPanel;
    public VisualElement LeaderboardLevel_Rank1;
    public VisualElement LeaderboardLevel_Rank2;
    public VisualElement LeaderboardLevel_Rank3;
    public VisualElement LeaderboardLevel_Rank4;
    public VisualElement LeaderboardLevel_Rank5;
    public VisualElement LeaderboardLevel_Rank6;
    public VisualElement LeaderboardLevel_Rank7;
    public VisualElement LeaderboardLevel_Rank8;
    public VisualElement LeaderboardLevel_Rank9;
    public VisualElement LeaderboardGuildPanel;
    public VisualElement LeaderboarGuild_Rank1;
    public VisualElement LeaderboarGuild_Rank2;
    public VisualElement LeaderboarGuild_Rank3;
    public VisualElement LeaderboarGuild_Rank4;
    public VisualElement LeaderboarGuild_Rank5;
    public VisualElement LeaderboarGuild_Rank6;
    public VisualElement LeaderboarGuild_Rank7;
    public VisualElement LeaderboarGuild_Rank8;
    public VisualElement LeaderboarGuild_Rank9;
    public VisualElement LeaderboardBattleScorePanel;
    public VisualElement LeaderboardBattleScore_Rank1;
    public VisualElement LeaderboardBattleScore_Rank2;
    public VisualElement LeaderboardBattleScore_Rank3;
    public VisualElement LeaderboardBattleScore_Rank4;
    public VisualElement LeaderboardBattleScore_Rank5;
    public VisualElement LeaderboardBattleScore_Rank6;
    public VisualElement LeaderboardBattleScore_Rank7;
    public VisualElement LeaderboardBattleScore_Rank8;
    public VisualElement LeaderboardBattleScore_Rank9;
    public VisualElement BattlePass;
    public VisualElement BattlePass_Body;
    public VisualElement BattlePass_Item;
    public VisualElement SkillsInformation;
    public VisualElement SkillsInformation_Header;
    public VisualElement Icon_Skill;
    public VisualElement Skills_Informations;
    public VisualElement Quest;
    public VisualElement QuestList;
    public VisualElement Quest1;
    public VisualElement Quest2;
    public VisualElement Quest3;
    public VisualElement Quest4;
    public VisualElement Quest5;
    public VisualElement QuestInformation;
    public VisualElement QuestChose;
    public VisualElement Party;
    public VisualElement PartyOptions;
    public VisualElement PartySettings;
    public VisualElement PartyBoard;
    public VisualElement PlayerProfileParty1;
    public VisualElement PlayerProfileParty2;
    public VisualElement PlayerProfileParty3;
    public VisualElement PlayerProfileParty4;
    public VisualElement PlayerProfilePart5;
    public VisualElement Guild;
    public VisualElement CreateGuildBoard;
    public VisualElement GuildBoard;
    public VisualElement GuildBoardHeader;
    public VisualElement GuildIcon;
    public VisualElement GuildBoardBody;
    public VisualElement GuildInformation;
    public VisualElement GuildBoardFooter;
    public VisualElement GuildBoardRoles_Body;
    public VisualElement GuildBoardRolesPlayerInformation1;
    public VisualElement GuildBoardRolesPlayerInformation2;
    public VisualElement GuildBoardRolesPlayerInformation3;
    public VisualElement GuildBoardRolesPlayerInformation4;
    public VisualElement GuildBoardRolesPlayerInformation5;
    public VisualElement GuildBoardSkills_Body;
    public VisualElement GuildSkillsInformation1;
    public VisualElement GuildSkillsInformation2;
    public VisualElement GuildSkillsInformation3;
    public VisualElement GuildSkillsInformation4;
    public VisualElement GuildSkillsInformation5;
    public VisualElement GuildSkillsInformation6;
    public VisualElement GuildSkillsInformation7;
    public VisualElement GuildBoardMessage_Body;
    public VisualElement CashShop;
    public VisualElement CashShopItensOptions;
    public VisualElement WeaponCashShop;
    public VisualElement ClothesCashShop;
    public VisualElement TicketsCashShop;
    public VisualElement MountsCashShop;
    public VisualElement PetsCashShop;
    public VisualElement Weapon1CashShop_List;
    public VisualElement Weapon1IconCashShop_List;
    public VisualElement Weapon2CashShop_List;
    public VisualElement Weapon2IconCashShop_List;
    public VisualElement Clothes1CashShop_List;
    public VisualElement Clothes1IconCashShop_List;
    public VisualElement Clothes2CashShop_List;
    public VisualElement Clothes2IconCashShop_List;
    public VisualElement Tickets1CashShop_List;
    public VisualElement Tickets1IconCashShop_List;
    public VisualElement Tickets2CashShop_List;
    public VisualElement Tickets2IconCashShop_List;
    public VisualElement CashShop_Footer;
    public VisualElement CashPay;
    public VisualElement CashPackage001;
    public VisualElement CashPackage001_Icon;
    public VisualElement CashPackage002;
    public VisualElement CashPackage002_Icon;
    public VisualElement DropBox;
    public VisualElement ArmorDropBox;
    public VisualElement ArmorDropBox_Icon;
    public VisualElement WeaponDropBox;
    public VisualElement WeaponDropBox_Icon;
    public VisualElement DropBoxPurchaseInformation;
    public VisualElement DropBoxItemInformation;
    public VisualElement DropBoxItemInformation_Header;
    public VisualElement DropBoxItemInformation_Icon;
    public VisualElement DropBoxItem_Informations;
    public VisualElement ChatItemInformation;
    public VisualElement ChatItemInformation_Header;
    public VisualElement ChatItem_Icon;
    public VisualElement ChatItem_Informations;
    public VisualElement ItemInfo;
    public VisualElement ItemInfo_Header;
    public VisualElement ItemInfo_Icon;
    public VisualElement ItemInfo_Body;
    public VisualElement ItemInfo_Footer;
    public VisualElement OptionsInGameplayPanel;
    
    public VisualElement WarningPopUp;
    public VisualElement NpcDialogue;
    public VisualElement NpcMessagePanel;
    public VisualElement PlayerAnswerPanel;
    public VisualElement NpcShop;
    public VisualElement WheelPanel;
    public VisualElement SpinWheel;
    public VisualElement ArrowSpinWheel;
    #endregion

    #region Buttons
    public Button Craft_btn;
    public Button Shop_btn;
    public Button Guild_btn;
    public Button Voucher_btn;
    public Button CloseVoucher_btn;
    public Button ConfirmVoucher_btn;
    public Button CloseCashShop_btn;
    public Button CashShopWeapon_btn;
    public Button CashShopClothes_btn;
    public Button CashShopTickets_btn;
    public Button CashShopMounts_btn;
    public Button CashShopPets_btn;
    public Button CashShopDropBox_btn;
    public Button CloseDropBox_btn;
    public Button CashPayMoney_btn;
    public Button CashPackage001Price_btn;
    public Button CloseCashPay_btn;
    public Button OptionsInGameplay_btn;
    public Button ItemDay1;
    public Button ItemDay2;
    public Button ItemDay3;
    public Button ItemDay4;
    public Button ItemDay5;
    public Button ItemDay6;
    public Button ItemDay7;
    public Button ItemDay8;
    public Button ItemDay9;
    public Button ItemDay10;
    public Button ItemDay11;
    public Button ItemDay12;
    public Button ItemDay13;
    public Button ItemDay14;
    public Button ItemDay15;
    public Button ItemDay16;
    public Button ItemDay17;
    public Button ItemDay18;
    public Button ItemDay19;
    public Button ItemDay20;
    public Button ItemDay21;
    public Button ItemDay22;
    public Button ItemDay23;
    public Button ItemDay24;
    public Button ItemDay25;
    public Button ItemDay26;
    public Button ItemDay27;
    public Button ItemDay28;
    public Button ItemDay29;
    public Button ItemDay30;
    public Button ItemDay31;
    public Button AchievementClose_btn;
    public Button AchievementDaily_btn;
    public Button AchievementOther_btn;
    public Button EarnAchievement1;
    public Button EarnAchievement2;
    public Button EarnAchievement3;
    public Button EarnAchievement4;
    public Button EarnAchievement5;
    public Button LevelLeaderboard_btn;
    public Button GuildLeaderboard_btn;
    public Button BattleScoreLeaderboard_btn;
    public Button CloseSkillsInformation_btn;
    public Button LevelUpSkill_btn;
    public Button CloseSkills_btn;
    public Button Skill_btn;
    public Button Passive_btn;
    public Button Action_btn;
    public Button CreateParty_btn;
    public Button CreatePartyOptions_btn;
    public Button CancelCreateParty_btn;
    public Button OkPartySettings_btn;
    public Button CancelPartySettings_btn;
    public Button SettingsPartyBoard_btn;
    public Button ChangeLeaderPartyBoard_btn;
    public Button KickPartyBoard_btn;
    public Button LeavePartyBoard_btn;
    public Button CloseGuild_btn;
    public Button CreateGuild_btn;
    public Button CloseCreateGuildBoard_btn;
    public Button CreateGuildBoard_btn;
    public Button CancelCreateGuildBoard_btn;
    public Button CloseGuildBoard_btn;
    public Button GuildBoardInfo_btn;
    public Button GuildBoardRoles_btn;
    public Button GuildBoardSkills_btn;
    public Button GuildBoardMessage_btn;
    public Button GuildBoardChangeLeader_btn;
    public Button GuildBoardChangeRole_btn;
    public Button GuildBoardKick_btn;
    public Button GuildBoardLeave_btn;
    public Button YesWarningPopUp_btn;
    public Button CancelWarningPopUp_btn;
    public Button Wheel_btn;
    public Button CloseWheel_btn;
    public Button LeaderBoard_btn;
    public Button CloseLeaderboard_btn;
    public Button DailyReward_btn;
    public Button CloseDailyReward_btn;
    public Button BattlePass_btn;
    public Button CloseBattlePass_btn;
    public Button Achievement_btn;
    public Button CloseAchievement_btn;
    public Button Party_btn;
    public Button CloseParty_btn;

    #endregion


    // Ui Builder Boolean Value
    private bool isCashShopVisible = false;
    private bool isGuildVisible = false;
    private bool isVoucherPanelVisible = false;
    private bool isWeaponShopPanelVisible = false;
    private bool isClothesShopPanelVisible = false;
    private bool isTicketsShopPanelVisible = false;
    private bool isMountsShopPanelVisible = false;
    private bool isPetsShopPanelVisible = false;
    private bool isCashPayPanelVisible = false;
    private bool isDropBoxPanelVisible = false;
    private bool isCreateGuildBoardPanelVisible = false;
    private bool isOptionsInGameplayVisible = false;
    private bool isWheelPanelvisible = false;
    private bool isLeaderboardPanelVisible = false;
    private bool isDailyRewardPanelVisible = false;
    private bool isBattlePassPanelVisible = false;
    private bool isAchievementPanelVisible = false;
    private bool isDailyAchievementPanelVisible = false;
    private bool isOtherAchievementPanelVisible = false;
    private bool isPartyPanelVisible = false;
    private bool isLevelLeaderboardvisible = false;
    private bool isGuildLeaderboardvisible = false;
    private bool isBattlescoreLeaderboardVisible = false;
    public void Awake()
    {
        //Ui Buttons
        var root = GetComponent<UIDocument>().rootVisualElement;
        Voucher_btn = root.Q<Button>("Voucher_btn");
        Guild_btn = root.Q<Button>("Guild_btn");
        Shop_btn = root.Q<Button>("Shop_btn");
        CashShopWeapon_btn = root.Q<Button>("CashShopWeapon_btn");
        CashShopClothes_btn = root.Q<Button>("CashShopClothes_btn");
        CashShopTickets_btn = root.Q<Button>("CashShopTickets_btn");
        CashShopMounts_btn = root.Q<Button>("CashShopMounts_btn");
        CashShopPets_btn = root.Q<Button>("CashShopPets_btn");
        CashShopDropBox_btn = root.Q<Button>("CashShopDropBox_btn");
        CashPayMoney_btn = root.Q<Button>("CashShopMoney_btn");
        CloseCashPay_btn = root.Q<Button>("CloseCashPay_btn");
        CloseVoucher_btn = root.Q<Button>("CloseVoucher_btn");
        CloseCashShop_btn = root.Q<Button>("CloseCashShop_btn");
        CloseDropBox_btn = root.Q<Button>("CloseDropBox_btn");
        OptionsInGameplay_btn = root.Q<Button>("OptionsInGameplay_btn");
        
       
        CloseGuild_btn = root.Q<Button>("CloseGuild_btn");
        CreateGuild_btn = root.Q<Button>("CreateGuild_btn");
        CloseCreateGuildBoard_btn = root.Q<Button>("CloseCreateGuildBoard_btn");
        Wheel_btn = root.Q<Button>("Wheel_btn");
        CloseWheel_btn = root.Q<Button>("CloseWheel_btn");
        LeaderBoard_btn = root.Q<Button>("LeaderBoard_btn");
        CloseLeaderboard_btn = root.Q<Button>("CloseLeaderboard_btn");
        DailyReward_btn = root.Q<Button>("DailyReward_btn");
        CloseDailyReward_btn = root.Q<Button>("CloseDailyReward_btn");
        BattlePass_btn = root.Q<Button>("BattlePass_btn");
        CloseBattlePass_btn = root.Q<Button>("CloseBattlePass_btn");
        Achievement_btn = root.Q<Button>("Achievement_btn");
        AchievementDaily_btn = root.Q<Button>("AchievementDaily_btn");
        AchievementOther_btn = root.Q<Button>("AchievementOther_btn");
        CloseAchievement_btn = root.Q<Button>("CloseAchievement_btn");
        Party_btn = root.Q<Button>("Party_btn");
        CloseParty_btn = root.Q<Button>("CloseParty_btn");
        LevelLeaderboard_btn = root.Q<Button>("LevelLeaderboard_btn");
        GuildLeaderboard_btn = root.Q<Button>("GuildLeaderboard_btn");
        BattleScoreLeaderboard_btn = root.Q<Button>("BattleScoreLeaderboard_btn");


        // Ui Visual Elements
        VoucherPanel = root.Q<VisualElement>("VoucherPanel");
        Guild = root.Q<VisualElement>("Guild");
        CashShop = root.Q<VisualElement>("CashShop");
        DropBox = root.Q<VisualElement>("DropBox");
        CashPay = root.Q<VisualElement>("CashPay");
        CreateGuildBoard = root.Q<VisualElement>("CreateGuildBoard");
        OptionsInGameplayPanel = root.Q<VisualElement>("OptionsInGameplayPanel");
        WeaponCashShop = root.Q<VisualElement>("WeaponCashShop");
        ClothesCashShop = root.Q<VisualElement>("ClothesCashShop");
        TicketsCashShop = root.Q<VisualElement>("TicketsCashShop");
        MountsCashShop = root.Q<VisualElement>("MountsCashShop");
        PetsCashShop = root.Q<VisualElement>("PetsCashShop");
        WheelPanel = root.Q<VisualElement>("WheelPanel");
        Leaderboard = root.Q<VisualElement>("Leaderboard");
        DailyReward = root.Q<VisualElement>("DailyReward");
        BattlePass = root.Q<VisualElement>("BattlePass");
        Achievement = root.Q<VisualElement>("Achievement");
        Party = root.Q<VisualElement>("Party");
        LeaderboardLevelPanel = root.Q<VisualElement>("LeaderboardLevelPanel");
        LeaderboardGuildPanel = root.Q<VisualElement>("LeaderboardGuildPanel");
        LeaderboardBattleScorePanel = root.Q<VisualElement>("LeaderboardBattleScorePanel");
        DailyAchievementList = root.Q<VisualElement>("DailyAchievementList");
        OtherAchievementList = root.Q<VisualElement>("OtherAchievementList");



        // Ui Buttons Registro
        Shop_btn.clicked += OnShopButtonClick;
        CashShopDropBox_btn.clicked += OnDropBoxButtonClick;
        CashPayMoney_btn.clicked += OnCashShopMoneyButtonClick;
        Guild_btn.clicked += OnGuildButtonClick;
        CreateGuild_btn.clicked += OnCreateGuildClick;
        Voucher_btn.clicked += OnVoucherButtonClick;
        CloseVoucher_btn.clicked += OnCloseVoucher;
        //CloseStatus_btn.clicked += OnCloseStatus;
        CloseCashShop_btn.clicked += OnCloseCashShop;
        CloseGuild_btn.clicked += OnCloseGuild;
        CloseCreateGuildBoard_btn.clicked += OnCloseCreateGuildBoard;
        CloseDropBox_btn.clicked += OnCloseDropBox;
        CloseCashPay_btn.clicked += OnCloseCashPay;
        OptionsInGameplay_btn.clicked += OnOptionsInGameplayButtonClick;
        Wheel_btn.clicked += OnWheelButtonClick;
        CloseWheel_btn.clicked += OnWheelCloseButtonClick;
        LeaderBoard_btn.clicked += OnLeaderBoardButtonClick;
        CloseLeaderboard_btn.clicked += OnCloseLeaderBoardButtonClick;
        DailyReward_btn.clicked += OnDailyRewardButtonClick;
        CloseDailyReward_btn.clicked += OnCloseDailyRewardButtonClick;
        BattlePass_btn.clicked += OnBattlePassButtonClick;
        CloseBattlePass_btn.clicked += OnCloseBattlePassButtonClick;
        Achievement_btn.clicked += OnAchievementButtonClick;
        AchievementDaily_btn.clicked += OnDailyAchievementButtonClick;
        AchievementOther_btn.clicked += OnOtherAchievementButtonClick;
        CloseAchievement_btn.clicked += OnCloseAchievementButtonClick;
        Party_btn.clicked += OnPartyButtonClick;
        CloseParty_btn.clicked += OnClosePartyButtonClick;
        CashShopWeapon_btn.clicked += OnWeaponCashShopButtonClick;
        CashShopClothes_btn.clicked += OnClothesCashShopButtonClick;
        CashShopTickets_btn.clicked += OnTicketsCashShopButtonClick;
        CashShopMounts_btn.clicked += OnMountsCashShopButtonClick;
        CashShopPets_btn.clicked += OnPetsCashShopButtonClick;
        LevelLeaderboard_btn.clicked += OnLevelLeaderboardButtonClick;
        GuildLeaderboard_btn.clicked += OnGuildLeaderboardButtonClick;
        BattleScoreLeaderboard_btn.clicked += OnBattleScoreLeaderboardButtonClick;

    }

    void OnPartyButtonClick()
    {
        Debug.Log("Botão da Party clicado");
        isPartyPanelVisible = !isPartyPanelVisible;

        if (isPartyPanelVisible)
        {
            ShowParty();
        }
    }

    void ShowParty()
    {
        Party.style.display = DisplayStyle.Flex;
    }

    void OnClosePartyButtonClick()
    {
        isPartyPanelVisible = false;
        Party.style.display = DisplayStyle.None;
    }
    void OnAchievementButtonClick()
    {
        Debug.Log("Botao do achivement clicado");
        isAchievementPanelVisible = !isAchievementPanelVisible;

        if (isAchievementPanelVisible)
        {
            ShowAchievement();
        }
    }

    void ShowAchievement()
    {
        Achievement.style.display = DisplayStyle.Flex;
    }

    void OnCloseAchievementButtonClick()
    {
        isAchievementPanelVisible = false;
        Achievement.style.display = DisplayStyle.None;
    }

    void OnDailyAchievementButtonClick()
    {
        Debug.Log("Botão Daily do Achievement Clicado");
        isDailyAchievementPanelVisible = !isDailyAchievementPanelVisible;

        if (isDailyAchievementPanelVisible) 
        {
            ShowDailyAchievement();
        }
    }

    void ShowDailyAchievement()
    {
        isOtherAchievementPanelVisible = false;

        DailyAchievementList.style.display = DisplayStyle.Flex;
        OtherAchievementList.style.display = DisplayStyle.None;
    }

    void OnOtherAchievementButtonClick()
    {
        Debug.Log("Botão Other do Achievement clicado");
        isOtherAchievementPanelVisible = !isOtherAchievementPanelVisible;

        if(isOtherAchievementPanelVisible)
        {
            ShowOtherAchievement();
        }
    }

    void ShowOtherAchievement()
    {
        isDailyAchievementPanelVisible = false;

        DailyAchievementList.style.display = DisplayStyle.None;
        OtherAchievementList.style.display = DisplayStyle.Flex;
    }

    void OnBattlePassButtonClick()
    {
        Debug.Log("Botão do battlepass clicado");

        isBattlePassPanelVisible = !isBattlePassPanelVisible;

        if (isBattlePassPanelVisible)
        {
            ShowBattlePass();
        }
    }

    void ShowBattlePass()
    {
        BattlePass.style.display = DisplayStyle.Flex;
    }

    void OnCloseBattlePassButtonClick()
    {
        isBattlePassPanelVisible = false;
        BattlePass.style.display = DisplayStyle.None;
    }
    void OnDailyRewardButtonClick()
    {
        Debug.Log("Botao do dailyreward clicado");
        isDailyRewardPanelVisible = !isDailyRewardPanelVisible;

        if (isDailyRewardPanelVisible)
        {
            ShowDailyReward();
        }
    }

    void ShowDailyReward()
    {
        DailyReward.style.display = DisplayStyle.Flex;
    }

    void OnCloseDailyRewardButtonClick()
    {
        isDailyRewardPanelVisible = false;
        DailyReward.style.display = DisplayStyle.None;
    }


    void OnLeaderBoardButtonClick()

    {
        Debug.Log("Botão do LeaderBoard Clicado");
        isLeaderboardPanelVisible = !isLeaderboardPanelVisible;

        if (isLeaderboardPanelVisible)
        {
            ShowLeaderBoard();
        }
    }

    void ShowLeaderBoard()

    {
        Leaderboard.style.display = DisplayStyle.Flex;
    }
    void OnCloseLeaderBoardButtonClick()
    {
        isLeaderboardPanelVisible = false;
        Leaderboard.style.display = DisplayStyle.None;
    }

    void OnLevelLeaderboardButtonClick()
    {
        Debug.Log("Botão do Level no Leaderboard clicado");
        isLevelLeaderboardvisible = !isLevelLeaderboardvisible;

        if(isLevelLeaderboardvisible)
        {
            ShowLevelLeaderboardPanel();
        }
    }

    void ShowLevelLeaderboardPanel()
    {
        isGuildLeaderboardvisible = false;
        isBattlescoreLeaderboardVisible = false;

        LeaderboardBattleScorePanel.style.display = DisplayStyle.None;
        LeaderboardGuildPanel.style.display = DisplayStyle.None;
        LeaderboardLevelPanel.style.display = DisplayStyle.Flex;
    }

    void OnGuildLeaderboardButtonClick()
    {
        Debug.Log("Botão do Guild no Leaderboard clicado");
        isGuildLeaderboardvisible = !isGuildLeaderboardvisible;

        if(isGuildLeaderboardvisible) 
        {
            ShowGuildLeaderboardPanel();
        }
    }

    void ShowGuildLeaderboardPanel()
    {
        isLevelLeaderboardvisible = false;
        isBattlescoreLeaderboardVisible = false;

        LeaderboardBattleScorePanel.style.display = DisplayStyle.None;
        LeaderboardGuildPanel.style.display = DisplayStyle.Flex;
        LeaderboardLevelPanel.style.display = DisplayStyle.None;

    }

    void OnBattleScoreLeaderboardButtonClick()
    {
        Debug.Log("Botão do BattleScore no Leaderboard clicado");
        isBattlescoreLeaderboardVisible = !isBattlescoreLeaderboardVisible;

        if(isBattlescoreLeaderboardVisible)
        {
            ShowBSLeaderboardPanel();
        }
    }

    void ShowBSLeaderboardPanel()
    {
        isLevelLeaderboardvisible = false;
        isGuildLeaderboardvisible = false;

        LeaderboardBattleScorePanel.style.display = DisplayStyle.Flex;
        LeaderboardGuildPanel.style.display = DisplayStyle.None;
        LeaderboardLevelPanel.style.display = DisplayStyle.None;
    }
    void OnWheelButtonClick()
    {
        Debug.Log("Botão da wheel clicado");

        isWheelPanelvisible = !isWheelPanelvisible;

        if (isWheelPanelvisible)
        {
            ShowWheelPanel();
        }
    }

    void OnWheelCloseButtonClick()
    {
        Debug.Log("Ocultando Wheel");
        isWheelPanelvisible = false;
        WheelPanel.style.display = DisplayStyle.None;
    }

    void ShowWheelPanel()
    {
        WheelPanel.style.display = DisplayStyle.Flex;
    }


    void OnOptionsInGameplayButtonClick()
    {
        Debug.Log("Botão de opções clicado");

        isOptionsInGameplayVisible = !isOptionsInGameplayVisible;

        if (isOptionsInGameplayVisible)
        {
            ShowOptionsInGameplay();
        }
        else
        {
            CloseOptionsInGameplay();
        }

    }

    void ShowOptionsInGameplay()
    {
        OptionsInGameplayPanel.style.display = DisplayStyle.Flex;
    }

    void CloseOptionsInGameplay()
    {
        OptionsInGameplayPanel.style.display = DisplayStyle.None;
    }



    void OnShopButtonClick()
    {
        Debug.Log("Botão de Shop clicado.");

        isCashShopVisible = !isCashShopVisible;

        if (isCashShopVisible)
        {
            ShowCashShop();
        }

    }

    void ShowCashShop()
    {
        CashShop.style.display = DisplayStyle.Flex;
    }

    void OnCloseCashShop()
    {
        isCashShopVisible = false;
        CashShop.style.display = DisplayStyle.None;
    }

    void OnWeaponCashShopButtonClick()
    {
        Debug.Log("Botão do Weapon no Cash Shop Clicado");

        isWeaponShopPanelVisible = !isWeaponShopPanelVisible; 
        if (isWeaponShopPanelVisible)
        {
            ShowWeaponPanel();
        }
    }


    void ShowWeaponPanel()
    {
        isClothesShopPanelVisible = false;
        isTicketsShopPanelVisible = false;
        isMountsShopPanelVisible = false;
        isPetsShopPanelVisible = false;

        WeaponCashShop.style.display = DisplayStyle.Flex;
        ClothesCashShop.style.display = DisplayStyle.None;
        TicketsCashShop.style.display = DisplayStyle.None;
        MountsCashShop.style.display = DisplayStyle.None;
        PetsCashShop.style.display = DisplayStyle.None;
    }


    void OnClothesCashShopButtonClick()
    {
        Debug.Log("Botão do Clothes do Cash Shop Clicado");

        isClothesShopPanelVisible = !isClothesShopPanelVisible;

        if(isClothesShopPanelVisible) 
        {
            ShowClothesPanel();
        }
    }

    void ShowClothesPanel()
    {
        isWeaponShopPanelVisible = false;
        isTicketsShopPanelVisible = false;
        isMountsShopPanelVisible = false;
        isPetsShopPanelVisible = false;

        WeaponCashShop.style.display = DisplayStyle.None;
        ClothesCashShop.style.display = DisplayStyle.Flex;
        TicketsCashShop.style.display = DisplayStyle.None;
        MountsCashShop.style.display = DisplayStyle.None;
        PetsCashShop.style.display = DisplayStyle.None;
    }

    void OnTicketsCashShopButtonClick()
    {
        Debug.Log("Botão do Tickets do Cash Shop Clicado");

        isTicketsShopPanelVisible = !isTicketsShopPanelVisible;

        if( isTicketsShopPanelVisible)
        {
            ShowTicketsPanel();
        }
    }

    void ShowTicketsPanel()
    {
        isWeaponShopPanelVisible = false;
        isClothesShopPanelVisible = false;
        isMountsShopPanelVisible = false;
        isPetsShopPanelVisible = false;

        WeaponCashShop.style.display = DisplayStyle.None;
        ClothesCashShop.style.display = DisplayStyle.None;
        TicketsCashShop.style.display = DisplayStyle.Flex;
        MountsCashShop.style.display = DisplayStyle.None;
        PetsCashShop.style.display = DisplayStyle.None;
    }

    void OnMountsCashShopButtonClick()
    {
        Debug.Log("Botão do Mounts do Cash Shop Clicado");

        isMountsShopPanelVisible = !isMountsShopPanelVisible;

        if(isMountsShopPanelVisible)
        {
            ShowMountsPanel();
        }
    }

    void ShowMountsPanel()
    {
        isWeaponShopPanelVisible = false;
        isClothesShopPanelVisible = false;
        isTicketsShopPanelVisible = false;
        isPetsShopPanelVisible = false;

        WeaponCashShop.style.display = DisplayStyle.None;
        ClothesCashShop.style.display = DisplayStyle.None;
        TicketsCashShop.style.display = DisplayStyle.None;
        MountsCashShop.style.display = DisplayStyle.Flex;
        PetsCashShop.style.display = DisplayStyle.None;
    }

    void OnPetsCashShopButtonClick()
    {
        Debug.Log("Botão do Pets no Cash Shop Clicado");

        isPetsShopPanelVisible = !isPetsShopPanelVisible;

        if(isPetsShopPanelVisible) 
        {
            ShowPetsPanel();
        }
    }

    void ShowPetsPanel()
    {

        isWeaponShopPanelVisible = false;
        isClothesShopPanelVisible = false;
        isTicketsShopPanelVisible = false;
        isMountsShopPanelVisible = false;

        WeaponCashShop.style.display = DisplayStyle.None;
        ClothesCashShop.style.display = DisplayStyle.None;
        TicketsCashShop.style.display = DisplayStyle.None;
        MountsCashShop.style.display = DisplayStyle.None;
        PetsCashShop.style.display = DisplayStyle.Flex;
    }
    

    void OnVoucherButtonClick()
    {
        Debug.Log("Botão de Voucher clicado.");

        isVoucherPanelVisible = !isVoucherPanelVisible;

        if (isVoucherPanelVisible)
        {
            ShowVoucherPanel();
        }

    }

    void ShowVoucherPanel()
    {
        Debug.Log("Exibindo a tela de vouchers.");
        VoucherPanel.style.display = DisplayStyle.Flex;
    }

    void OnCloseVoucher()
    {
        isVoucherPanelVisible = false;
        Debug.Log("Ocultando a tela de vouchers.");
        VoucherPanel.style.display = DisplayStyle.None;
    }

    void OnGuildButtonClick()
    {
        Debug.Log("Botão de Guild clicado.");

        isGuildVisible = !isGuildVisible;

        if (isGuildVisible)
        {
            ShowGuild();
        }


    }

    void ShowGuild()
    {
        Guild.style.display = DisplayStyle.Flex;
    }

    void OnCloseGuild()
    {
        isGuildVisible = false;
        Guild.style.display = DisplayStyle.None;
    }

    void OnCreateGuildClick()
    {
        Debug.Log("Botão para criar Guild Clicado");
        isCreateGuildBoardPanelVisible = !isCreateGuildBoardPanelVisible;

        if (isCreateGuildBoardPanelVisible)
        {
            ShowCreateGuild();
        }
    }

    void ShowCreateGuild()
    {
        CreateGuildBoard.style.display = DisplayStyle.Flex;
        Guild.style.display = DisplayStyle.None;
    }

    void OnCloseCreateGuildBoard()
    {
        isGuildVisible = false;
        isCreateGuildBoardPanelVisible = false;
        CreateGuildBoard.style.display = DisplayStyle.None;
    }

    void OnDropBoxButtonClick()
    {
        Debug.Log("Botão do DropBox clicado.");

        isDropBoxPanelVisible = !isDropBoxPanelVisible;

        if (isDropBoxPanelVisible)
        {
            ShowDropBox();
        }

    }

    void ShowDropBox()
    {
        DropBox.style.display = DisplayStyle.Flex;
    }

    void OnCloseDropBox()
    {
        isDropBoxPanelVisible = false;
        DropBox.style.display = DisplayStyle.None;
    }

    void OnCashShopMoneyButtonClick()
    {
        Debug.Log("Botão do MoneyShop clicado.");

        isCashPayPanelVisible = !isCashPayPanelVisible;

        if (isCashPayPanelVisible)
        {
            ShowCashPay();
        }

    }

    void ShowCashPay()
    {
        CashPay.style.display = DisplayStyle.Flex;
    }

    void OnCloseCashPay()
    {
        isCashPayPanelVisible = false;
        CashPay.style.display = DisplayStyle.None;
    }

      
}
