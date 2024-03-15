using Kitchen;
using KitchenLib.Customs;
using UnityEngine;
using KitchenLib.Utils;
using KitchenData;
using static KitchenData.ItemGroup;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.VFX;
using KitchenLib.References;
using KitchenQuiche;

namespace Quiche.Customs.Quiche
{
    public class UncookedCheeseTomatoQuiche : CustomItemGroup<UncookedCheeseTomatoQuicheItemGroupView>
    {
        public override string UniqueNameID => "Uncooked Cheese Tomato Quiche";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("UncookedCheeseTomatoQuiche").AssignMaterialsByNames();
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemValue ItemValue => ItemValue.Medium;
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Duration = 7,
                Process = Mod.Cook,
                IsBad = false,
                Result = Mod.CheeseTomatoQuiche
            }
        };
        public override List<ItemSet> Sets => new List<ItemSet>()
        {
            new ItemSet ()
            {
                Max = 1,
                Min = 1,
                IsMandatory = true,
                Items = new List<Item>()
                {
                    Mod.PieCrustCooked
                }
            },
            new ItemSet()
            {
                Max = 3,
                Min = 3,
                Items = new List<Item>()
                {
                    Mod.ChoppedCheese,
                    Mod.ChoppedTomato,
                    Mod.ChoppedEgg,
                }
            }
        };
        public override List<ItemGroupView.ColourBlindLabel> Labels => new List<ItemGroupView.ColourBlindLabel>()
        {
                new()
                {
                    Text = "C",
                    Item = Mod.ChoppedCheese
                },
                new()
                {
                    Text = "T",
                    Item = Mod.ChoppedTomato
                },
                new()
                {
                    Text = "E",
                    Item = Mod.ChoppedEgg
                },
        };

        public override void OnRegister(ItemGroup gameDataObject)
        {
            Prefab.GetComponent<UncookedCheeseTomatoQuicheItemGroupView>()?.Setup(Prefab);
        }
    }
    public class UncookedCheeseTomatoQuicheItemGroupView : ItemGroupView
    {
        internal void Setup(GameObject prefab)
        {
            // This tells which sub-object of the prefab corresponds to each component of the ItemGroup
            // All of these sub-objects are hidden unless the item is present
            ComponentGroups = new()
            {
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "Tomato"),
                    Item = Mod.ChoppedTomato
                },
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "Cheese"),
                    Item = Mod.ChoppedCheese
                },
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "Egg"),
                    Item = Mod.ChoppedEgg
                },
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "Pie Cooked"),
                    Item = Mod.PieCrustCooked
                }
            };
        }
    }
}
