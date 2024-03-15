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
    public class CheeseTomatoQuiche : CustomItem
    {
        public override string UniqueNameID => "CheeseTomatoQuiche";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CheeseTomatoQuiche");
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemValue ItemValue => ItemValue.Medium;

        public override void OnRegister(Item gameDataObject)
        {
        }
    }
}
