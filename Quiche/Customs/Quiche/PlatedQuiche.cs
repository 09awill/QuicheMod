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
    public class PlatedQuiche : CustomItemGroup<PlatedQuicheItemGroupView>
    {
        public override string UniqueNameID => "Plated Quiche";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PlatedQuiche").AssignMaterialsByNames();
        public override ItemCategory ItemCategory => ItemCategory.Generic;
        public override ItemValue ItemValue => ItemValue.Medium;
        public override Item DisposesTo => Mod.Plate;
        public override Item DirtiesTo => Mod.DirtyPlate;
        public override bool CanContainSide => true;

        public override List<ItemSet> Sets => new List<ItemSet>()
        {
            new ItemSet()
            {
                Max = 1,
                Min = 1,
                IsMandatory= true,
                RequiresUnlock = true,
                Items = new List<Item>()
                {
                    Mod.CheeseQuicheSlice,
                    Mod.CheeseTomatoQuicheSlice,
                    Mod.LorraineQuicheSlice
                }
            },
            new ItemSet()
            {
                Max = 1,
                Min = 1,
                IsMandatory= true,
                Items = new List<Item>()
                {
                    Mod.Plate
                }
            }
        };
        public override List<ItemGroupView.ColourBlindLabel> Labels => new List<ItemGroupView.ColourBlindLabel>()
        {
                new()
                {
                    Text = "C",
                    Item = Mod.CheeseQuicheSlice
                },
                new()
                {
                    Text = "CT",
                    Item = Mod.CheeseTomatoQuicheSlice
                },
                new()
                {
                    Text = "L",
                    Item = Mod.LorraineQuicheSlice
                }
        };

        public override void OnRegister(ItemGroup gameDataObject)
        {
            Prefab.GetComponent<PlatedQuicheItemGroupView>()?.Setup(Prefab);
            VisualEffectAsset asset = Resources.FindObjectsOfTypeAll<VisualEffectAsset>().Where(vfx => vfx.name == Mod.VFX_NAME).FirstOrDefault();
            if (asset != default)
            {
                VisualEffect vfx = Prefab.GetChild("Steam").AddComponent<VisualEffect>();
                vfx.visualEffectAsset = asset;
            }
        }
    }
    public class PlatedQuicheItemGroupView : ItemGroupView
    {
        internal void Setup(GameObject prefab)
        {
            // This tells which sub-object of the prefab corresponds to each component of the ItemGroup
            // All of these sub-objects are hidden unless the item is present
            ComponentGroups = new()
            {
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "CheeseQuicheSlice"),
                    Item = Mod.CheeseQuicheSlice
                },
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "CheeseTomatoQuicheSlice"),
                    Item = Mod.CheeseTomatoQuicheSlice
                },
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(prefab, "LorraineQuicheSlice"),
                    Item = Mod.LorraineQuicheSlice
                }
            };
        }
    }
}
