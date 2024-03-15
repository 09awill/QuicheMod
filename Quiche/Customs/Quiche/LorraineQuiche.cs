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
using System.Reflection;

namespace Quiche.Customs.Quiche
{
    public class LorraineQuiche : CustomItem
    {
        public override string UniqueNameID => "Lorraine Quiche";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("LorraineQuiche").AssignMaterialsByNames();
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemValue ItemValue => ItemValue.Medium;
        public override Item SplitSubItem => Mod.LorraineQuicheSlice;
        public override int SplitCount => 3;
        public override float SplitSpeed => 1f;
        public override List<Item> SplitDepletedItems => new List<Item>() { Mod.LorraineQuicheSlice };
        public override string ColourBlindTag => "L";


        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Duration = 6,
                Process = Mod.Cook,
                IsBad = true,
                Result = Mod.QuicheBurnt
            }
        };
        public override void OnRegister(Item gameDataObject)
        {
            var view = Prefab.AddComponent<ObjectsSplittableView>();
            FieldInfo info = ReflectionUtils.GetField<ObjectsSplittableView>("Objects");

            List<GameObject> list = new List<GameObject>()
            {
                Prefab.GetChild("Slice 2"),
                Prefab.GetChild("Slice 3"),
                Prefab.GetChild("Slice 4"),
            };
            info.SetValue(view, list);
        }

    }
}
