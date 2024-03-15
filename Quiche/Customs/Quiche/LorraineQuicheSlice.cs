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
    public class LorraineQuicheSlice : CustomItem
    {
        public override string UniqueNameID => "Lorraine Quiche Slice";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("LorraineQuicheSlice").AssignMaterialsByNames();
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemValue ItemValue => ItemValue.Medium;
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override string ColourBlindTag => "L";

    }
}
