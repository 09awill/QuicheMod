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
    public class QuicheBurnt : CustomItem
    {
        public override string UniqueNameID => "Quiche Burnt";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("QuicheBurnt").AssignMaterialsByNames();
        public override ItemCategory ItemCategory => ItemCategory.Generic;

    }
}
