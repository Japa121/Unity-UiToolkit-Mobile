using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System;


namespace MultiplayerARPG

{
  
    

    public class HudManager : BaseUISceneGameplay
    {
       

        public UIStorageItems uiBuildingStorageItems;
        [Tooltip("If this UI was not set, it will find component in children to set when `Awake`")]
        public UICampfireItems uiBuildingCampfireItems;
        [Tooltip("If this UI was not set, it will find component in children to set when `Awake`")]
        // Abstract properties
        public override ItemsContainerEntity ItemsContainerEntity { get; }


        public UICraftingQueueItems uiCraftingQueueItems;


        public UIStorageItems uiPlayerStorageItems;
        [Tooltip("If this UI was not set, it will use the same object with `uiPlayerStorageItems`")]

        public UIStorageItems uiGuildStorageItems;

        [Tooltip("If this UI was not set, it will use the same object with `uiPlayerStorageItems`")]
        public UIRefineItem uiRefineItem;
        [Tooltip("If this UI was not set, it will find component in children to set when `Awake`")]
        public UIEnhanceSocketItem uiEnhanceSocketItem;
        [Tooltip("If this UI was not set, it will find component in children to set when `Awake`")]
        public UIItemCrafts uiBuildingCraftItems;
        [Tooltip("If this UI was not set, it will find component in children to set when `Awake`")]
        bool containsTag = false;
        protected void AddNpcDialog(UIBase npcDialog)
        {
            if (!_openedNpcDialogs.Contains(npcDialog))
                _openedNpcDialogs.Add(npcDialog);
        }

        public override void ShowEnhanceSocketItemDialog(InventoryType inventoryType, int indexOfData)
        {
            if (uiEnhanceSocketItem == null)
                return;
            uiEnhanceSocketItem.Data = new UIOwningCharacterItemData(inventoryType, indexOfData);
            uiEnhanceSocketItem.Show();
        }

        public override void ShowStorageDialog(StorageType storageType, string storageOwnerId, uint objectId, int weightLimit, int slotLimit)
        {
            // Hide all of storage UIs
            if (uiPlayerStorageItems != null)
                uiPlayerStorageItems.Hide(true);
            if (uiGuildStorageItems != null)
                uiGuildStorageItems.Hide(true);
            if (uiBuildingStorageItems != null)
                uiBuildingStorageItems.Hide(true);
            if (uiBuildingCampfireItems != null)
                uiBuildingCampfireItems.Hide(true);
            // Show only selected storage type
            switch (storageType)
            {
                case StorageType.Player:
                    if (uiPlayerStorageItems != null)
                    {
                        uiPlayerStorageItems.Show(storageType, storageOwnerId, null, weightLimit, slotLimit);
                        AddNpcDialog(uiPlayerStorageItems);
                    }
                    break;
                case StorageType.Guild:
                    if (uiGuildStorageItems != null)
                    {
                        uiGuildStorageItems.Show(storageType, storageOwnerId, null, weightLimit, slotLimit);
                        AddNpcDialog(uiGuildStorageItems);
                    }
                    break;
                case StorageType.Building:
                    BuildingEntity buildingEntity;
                    if (!BaseGameNetworkManager.Singleton.Assets.TryGetSpawnedObject(objectId, out buildingEntity))
                        return;

                    if (buildingEntity is CampFireEntity)
                    {
                        if (uiBuildingCampfireItems != null)
                        {
                            uiBuildingCampfireItems.Show(storageType, storageOwnerId, buildingEntity, weightLimit, slotLimit);
                            AddNpcDialog(uiBuildingCampfireItems);
                        }
                    }
                    else if (buildingEntity is StorageEntity)
                    {
                        if (uiBuildingStorageItems != null)
                        {
                            uiBuildingStorageItems.Show(storageType, storageOwnerId, buildingEntity, weightLimit, slotLimit);
                            AddNpcDialog(uiBuildingStorageItems);
                        }
                    }
                    break;
            }
        }

        [Header("Selected Target UIs")]
        public UICharacterEntity uiTargetCharacter;
        public UIBaseGameEntity uiTargetNpc;
        public UIBaseGameEntity uiTargetItemDrop;
        public UIBaseGameEntity uiTargetItemsContainer;
        public UIDamageableEntity uiTargetBuilding;
        public UIDamageableEntity uiTargetHarvestable;
        public UIBaseGameEntity uiTargetVehicle;



        private readonly List<UIBase> _openedNpcDialogs = new List<UIBase>();

        public List<UIBase> blockControllerUis = new List<UIBase>();

        public UIBase ui;

        public UIBase uiIsWarping;









        public void SetUIComponentsFromChildrenIfEmpty()
        {
            if (uiNpcDialog == null)
                uiNpcDialog = gameObject.GetComponentInChildren<UINpcDialog>(true);

        }



        // private readonly List<UIBase> _openedNpcDialogs = new List<UIBase>();


        public System.Action onHideCurrentBuildingDialog;

        





        private UINpcDialog uiNpcDialog;


        public override void ShowWorkbenchDialog(WorkbenchEntity workbenchEntity)
        {
            if (uiBuildingCraftItems == null)
                return;
            uiBuildingCraftItems.Show(CrafterType.Workbench, workbenchEntity);
            AddNpcDialog(uiBuildingCraftItems);
        }

        public override void SetTargetEntity(BaseGameEntity entity)
        {
            if (entity == null)
            {
                SetTargetCharacter(null);
                SetTargetNpc(null);
                SetTargetItemDrop(null);
                SetTargetItemsContainer(null);
                SetTargetBuilding(null);
                SetTargetHarvestable(null);
                SetTargetVehicle(null);
                return;
            }

            if (entity is BaseCharacterEntity)
                SetTargetCharacter(entity as BaseCharacterEntity);
            if (entity is NpcEntity)
                SetTargetNpc(entity as NpcEntity);
            if (entity is ItemDropEntity)
                SetTargetItemDrop(entity as ItemDropEntity);
            if (entity is ItemsContainerEntity)
                SetTargetItemsContainer(entity as ItemsContainerEntity);
            if (entity is BuildingEntity)
                SetTargetBuilding(entity as BuildingEntity);
            if (entity is HarvestableEntity)
                SetTargetHarvestable(entity as HarvestableEntity);
            if (entity is VehicleEntity)
                SetTargetVehicle(entity as VehicleEntity);
        }
        protected void SetTargetCharacter(BaseCharacterEntity character)
        {
            if (uiTargetCharacter == null)
                return;

            if (character == null)
            {
                uiTargetCharacter.Hide();
                return;
            }

            uiTargetCharacter.hideWhileDead = false;
            uiTargetCharacter.Data = character;
            uiTargetCharacter.Show();
        }

        protected void SetTargetNpc(NpcEntity npc)
        {
            if (uiTargetNpc == null)
                return;

            if (npc == null)
            {
                uiTargetNpc.Hide();
                return;
            }

            uiTargetNpc.Data = npc;
            uiTargetNpc.Show();
        }

        protected void SetTargetItemDrop(ItemDropEntity itemDrop)
        {
            if (uiTargetItemDrop == null)
                return;

            if (itemDrop == null)
            {
                uiTargetItemDrop.Hide();
                return;
            }

            uiTargetItemDrop.Data = itemDrop;
            uiTargetItemDrop.Show();
        }

        protected void SetTargetItemsContainer(ItemsContainerEntity itemsContainer)
        {
            if (uiTargetItemsContainer == null)
                return;

            if (itemsContainer == null)
            {
                uiTargetItemsContainer.Hide();
                return;
            }

            uiTargetItemsContainer.Data = itemsContainer;
            uiTargetItemsContainer.Show();
        }

        protected void SetTargetBuilding(BuildingEntity building)
        {
            if (uiTargetBuilding == null)
                return;

            if (building == null)
            {
                uiTargetBuilding.Hide();
                return;
            }

            uiTargetBuilding.Data = building;
            uiTargetBuilding.Show();
        }

        protected void SetTargetHarvestable(HarvestableEntity harvestable)
        {
            if (uiTargetHarvestable == null)
                return;

            if (harvestable == null)
            {
                uiTargetHarvestable.Hide();
                return;
            }

            uiTargetHarvestable.Data = harvestable;
            uiTargetHarvestable.Show();
        }

        protected void SetTargetVehicle(VehicleEntity vehicle)
        {
            if (uiTargetVehicle == null)
                return;

            if (vehicle == null)
            {
                uiTargetVehicle.Hide();
                return;
            }

            uiTargetVehicle.Data = vehicle;
            uiTargetVehicle.Show();
        }




       


        public override void ShowRefineItemDialog(InventoryType inventoryType, int indexOfData)
        {
            if (uiRefineItem == null)
                return;
            uiRefineItem.Data = new UIOwningCharacterItemData(inventoryType, indexOfData);
            uiRefineItem.Show();
        }

        public override void ShowDominationCapturingDialog(DominationZone dominationZone, int dataId)
        {
            throw new System.NotImplementedException();
        }

        public override void CloseDominationCapturingDialog()
        {
            throw new System.NotImplementedException();
        }

        public override void SetActivePlayerCharacter(BasePlayerCharacterEntity playerCharacter)
        {
            throw new System.NotImplementedException();
        }

        public override void HideQuestRewardItemSelection()
        {
            throw new System.NotImplementedException();
        }

        public override void HideNpcDialog()
        {
            throw new System.NotImplementedException();
        }

        public override void ShowConstructBuildingDialog(BuildingEntity buildingEntity)
        {
            throw new System.NotImplementedException();
        }

        public override void HideConstructBuildingDialog()
        {
            throw new System.NotImplementedException();
        }

        public override void ShowCurrentBuildingDialog(BuildingEntity buildingEntity)
        {
            throw new System.NotImplementedException();
        }

        public override void HideCurrentBuildingDialog()
        {
            throw new System.NotImplementedException();
        }

        public override bool IsShopDialogVisible()
        {
            throw new System.NotImplementedException();
        }

        public override bool IsRefineItemDialogVisible()
        {
            throw new System.NotImplementedException();
        }

        public override bool IsDismantleItemDialogVisible()
        {
            throw new System.NotImplementedException();
        }

        public override bool IsRepairItemDialogVisible()
        {
            throw new System.NotImplementedException();
        }

        public override bool IsEnhanceSocketItemDialogVisible()
        {
            throw new System.NotImplementedException();
        }

        public override bool IsItemsContainerDialogVisible()
        {
            throw new System.NotImplementedException();
        }

        public override bool IsDealingDialogVisibleWithDealingState()
        {
            throw new System.NotImplementedException();
        }

        public override bool IsStartVendingDialogVisible()
        {
            throw new System.NotImplementedException();
        }

        public override void ShowDismantleItemDialog(InventoryType inventoryType, int indexOfData)
        {
            throw new System.NotImplementedException();
        }

        public override void ShowRepairItemDialog(InventoryType inventoryType, int indexOfData)
        {
            throw new System.NotImplementedException();
        }

        public override void HideStorageDialog()
        {
            throw new System.NotImplementedException();
        }

        public override void ShowItemsContainerDialog(ItemsContainerEntity itemsContainerEntity)
        {
            throw new System.NotImplementedException();
        }

        public override void HideItemsContainerDialog()
        {
            throw new System.NotImplementedException();
        }

        public override void ShowCraftingQueueItemsDialog(ICraftingQueueSource source)
        {
            throw new System.NotImplementedException();
        }

        public override void OnControllerSetup(BasePlayerCharacterEntity playerCharacter)
        {
            throw new System.NotImplementedException();
        }

        public override void OnControllerDesetup(BasePlayerCharacterEntity playerCharacter)
        {
            throw new System.NotImplementedException();
        }

        public override void ShowVending(BasePlayerCharacterEntity playerCharacter)
        {
            throw new System.NotImplementedException();
        }

        public override bool IsStorageDialogVisible()
        {
            throw new NotImplementedException();
        }
    }

}

