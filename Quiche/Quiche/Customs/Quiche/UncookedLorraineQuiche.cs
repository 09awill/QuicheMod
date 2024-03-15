﻿using Kitchen;
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
    public class UncookedLorraineQuiche : CustomItemGroup<UncookedLorraineQuicheItemGroupView>
    {
        public override string UniqueNameID => "Uncooked Lorraine Quiche";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("UncookedLorraineQuiche");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemValue ItemValue => ItemValue.Medium;
        public override List<ItemSet> Sets => new List<ItemSet>()
        {
            new ItemSet()
            {
                Max = 3,
                Min = 3,
                Items = new List<Item>()
                {
                    Mod.Bacon,
                    Mod.ChoppedCheese,
                    Mod.ChoppedEgg,
                    Mod.PieCrustCooked
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
                    Text = "B",
                    Item = Mod.Bacon
                },
                new()
                {
                    Text = "E",
                    Item = Mod.ChoppedEgg
                },
        };

        public override void OnRegister(ItemGroup gameDataObject)
        {
            Prefab.GetComponent<UncookedLorraineQuicheItemGroupView>()?.Setup(Prefab);
        }
    }
    public class UncookedLorraineQuicheItemGroupView : ItemGroupView
    {
        private GameObject jacketPotato = null;
        internal void Setup(GameObject prefab)
        {
            // This tells which sub-object of the prefab corresponds to each component of the ItemGroup
            // All of these sub-objects are hidden unless the item is present
            ComponentGroups = new()
            {
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "ChoppedEgg"),
                    Item = Mod.ChoppedEgg
                },
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "ChoppedCheese"),
                    Item = Mod.ChoppedCheese
                },
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "Bacon"),
                    Item = Mod.Bacon
                },
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "PieCrustCooked"),
                    Item = Mod.PieCrustCooked
                },
            };

    }
}
