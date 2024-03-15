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
    public class UncookedCheeseQuiche : CustomItemGroup<UncookedCheeseQuicheItemGroupView>
    {
        public override string UniqueNameID => "Uncooked Cheese Quiche";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("UncookedCheeseQuiche").AssignMaterialsByNames();
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemValue ItemValue => ItemValue.Medium;
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Duration = 7,
                Process = Mod.Cook,
                IsBad = false,
                Result = Mod.CheeseQuiche
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
                Min = 2,
                Items = new List<Item>()
                {
                    Mod.ChoppedCheese,
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
                    Text = "E",
                    Item = Mod.ChoppedEgg
                },
        };

        public override void OnRegister(ItemGroup gameDataObject)
        {
            Prefab.GetComponent<UncookedCheeseQuicheItemGroupView>()?.Setup(Prefab);
        }
    }
    public class UncookedCheeseQuicheItemGroupView : ItemGroupView
    {
        internal void Setup(GameObject prefab)
        {
            // This tells which sub-object of the prefab corresponds to each component of the ItemGroup
            // All of these sub-objects are hidden unless the item is present
            ComponentGroups = new()
            {
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
