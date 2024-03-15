using KitchenQuiche;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Unity.Entities;
using UnityEngine.VFX;

namespace Quiche.Customs.Cards
{
    class CheeseQuicheBaseDish : CustomDish
    {
        public override string UniqueNameID => "Cheese Quiche Dish";
        public override DishType Type => DishType.Base;
        public override GameObject DisplayPrefab => Mod.Bundle.LoadAsset<GameObject>("CheeseQuicheIcon");
        public override GameObject IconPrefab => DisplayPrefab;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override CardType CardType => CardType.Default;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Medium;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override int Difficulty => 2;


        public override List<Dish.MenuItem> ResultingMenuItems => new List<Dish.MenuItem>
        {
            new Dish.MenuItem
            {
                Item = Mod.PlatedQuiche,
                Phase = MenuPhase.Main,
                Weight = 1
            }
        };
        public override HashSet<Dish.IngredientUnlock> IngredientsUnlocks => new()
        {
            new Dish.IngredientUnlock
            {
                Ingredient = Mod.CheeseQuiche,
                MenuItem = Mod.PlatedQuiche
            }
        };
        public override HashSet<Item> MinimumIngredients => new HashSet<Item>
        {
            Mod.Egg,
            Mod.Flour,
            Mod.Plate,
            Mod.Cheese,
        };
        public override HashSet<Process> RequiredProcesses => new HashSet<Process>
        {
            Mod.Cook,
            Mod.Chop,
            Mod.RequireOven
        };
        public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string>
        {
            { Locale.English, "Bake potato in oven and put on a plate, mix egg and combine with oil to make mayo, combine with tuna then with Jacket potato and serve!" },
            { Locale.French, "Cuisez la pomme de terre au four et mettez-la sur une assiette, mélangez l'œuf et combinez avec de l'huile pour faire de la mayonnaise, combinez avec le thon puis avec la pomme de terre en robe des champs et servez !" },
            { Locale.German, "Kartoffel im Ofen backen und auf einen Teller legen, Ei mischen und mit Öl zu Mayonnaise vermengen, mit Thunfisch vermengen und dann mit Jackenkartoffeln servieren!" },
            { Locale.Spanish, "Hornee la patata en el horno y colóquela en un plato, mezcle el huevo y combine con aceite para hacer mayonesa, combine con atún y luego con la patata asada y sirva!" },
            { Locale.Polish, "Upiecz ziemniaka w piekarniku i połóż na talerzu, wymieszaj jajko i połącz z olejem, aby zrobić majonez, połącz z tuńczykiem, a następnie z ziemniakami w mundurkach i podawaj!" },
            { Locale.Russian, "Запеките картофель в духовке и положите на тарелку, смешайте яйцо и соедините с маслом, чтобы сделать майонез, соедините с тунцом, затем с картофелем в мундире и подавайте!" },
            { Locale.PortugueseBrazil, "Asse a batata no forno e coloque em um prato, misture o ovo e combine com o óleo para fazer maionese, combine com o atum e, em seguida, com a batata assada e sirva!" },
            { Locale.Japanese, "オーブンでジャガイモを焼き、お皿に置き、卵を混ぜてオイルと組み合わせてマヨネーズを作り、ツナと組み合わせ、それからジャケットポテトと一緒に提供します！" },
            { Locale.ChineseSimplified, "在烤箱中烤土豆并放在盘子上，搅拌鸡蛋并与油混合制成蛋黄酱，与金枪鱼混合，然后与夹克土豆一起上菜！" },
            { Locale.ChineseTraditional, "在烤箱中烤土豆并放在盘子上，搅拌鸡蛋并与油混合制成蛋黄酱，与金枪鱼混合，然后与夹克土豆一起上菜！" },
            { Locale.Korean, "오븐에서 감자를 굽고 접시에 올려놓고, 계란을 섞어 오일과 섞어 마요네즈를 만들고 참치와 함께 섞은 후 자켓 감자와 함께 내세요!" },
            { Locale.Turkish, "Fırında patatesi pişirin ve tabağa koyun, yumurtayı karıştırın ve yağla birleştirerek mayonez yapın, ton balığı ile karıştırın, ardından ceket patatesle servis yapın!" },

        };

        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
            ( Locale.English, LocalisationUtils.CreateUnlockInfo("Jacket Potato with Tuna Mayo", "Adds Tuna Mayo as a filling for jacket potato", "One for the pescatarians") ),
            ( Locale.French, LocalisationUtils.CreateUnlockInfo("Pomme de Terre en Robe des Champs avec Mayonnaise au Thon", "Ajoute de la mayonnaise au thon comme garniture pour la pomme de terre en robe des champs", "Pour les pescatariens") ),
            ( Locale.German, LocalisationUtils.CreateUnlockInfo("Kartoffel in der Schale mit Thunfisch-Mayo", "Fügt Thunfisch-Mayo als Füllung für Kartoffel in der Schale hinzu", "Etwas für die Pescetarier") ),
            ( Locale.Spanish, LocalisationUtils.CreateUnlockInfo("Patata en Chaqueta con Mayonesa de Atún", "Agrega mayonesa de atún como relleno para la patata en chaqueta", "Para los pescetarianos") ),
            ( Locale.Polish, LocalisationUtils.CreateUnlockInfo("Ziemniak w Mundurku z Majonezem Tuńczykowym", "Dodaje majonez tuńczykowy jako nadzienie do ziemniaka w mundurku", "Dla pescetarian") ),
            ( Locale.Russian, LocalisationUtils.CreateUnlockInfo("Картофель в мундире с тунцом и майонезом", "Добавляет тунец и майонез в качестве начинки для картофеля в мундире", "Для пескетарианцев") ),
            ( Locale.PortugueseBrazil, LocalisationUtils.CreateUnlockInfo("Batata em Casca com Maionese de Atum", "Adiciona maionese de atum como recheio para a batata em casca", "Para os pescetarianos") ),
            ( Locale.Japanese, LocalisationUtils.CreateUnlockInfo("ツナマヨネーズ入りジャケットポテト", "ツナマヨネーズをジャケットポテトの具として追加", "ペスケタリアンのための一品") ),
            ( Locale.ChineseSimplified, LocalisationUtils.CreateUnlockInfo("金枪鱼玛琪朵夹克马铃薯", "将金枪鱼玛琪朵作为夹克马铃薯的馅料", "适合素食主义者") ),
            ( Locale.ChineseTraditional, LocalisationUtils.CreateUnlockInfo("金槍魚瑪琪朵夾克馬鈴薯", "將金槍魚瑪琪朵作為夾克馬鈴薯的餡料", "適合素食主義者") ),
            ( Locale.Korean, LocalisationUtils.CreateUnlockInfo("참치 마요네즈 속 자켓 감자", "참치 마요네즈를 자켓 감자의 속으로 추가", "페스케타리언을 위한 메뉴") ),
            ( Locale.Turkish, LocalisationUtils.CreateUnlockInfo("Ton Balıklı Mayonezli Ceket Patates", "Ton balığı mayonezi ile ceket patates için doldurma ekler", "Pesketaryenler için bir seçenek") ),

        };

        public override void OnRegister(Dish gameDataObject)
        {
            IconPrefab.GetChild("JacketPotato/Potato/SubMesh_0").ApplyMaterial("Cooked Potato - Roast");
            IconPrefab.GetChild("JacketPotato/Potato/SubMesh_1").ApplyMaterial("Cooked Potato");
            IconPrefab.GetChild("Tuna/Cube/Beans").ApplyMaterial("Tuna");
            IconPrefab.GetChild("Tuna/Cylinder.001/BeansLiquid").ApplyMaterial("Tuna");
            IconPrefab.GetChild("JacketPotato/Potato.001/SubMesh_0.001").ApplyMaterial("Cooked Potato - Roast");
            IconPrefab.GetChild("JacketPotato/Potato.001/SubMesh_1.001").ApplyMaterial("Cooked Potato");
            IconPrefab.GetChild("Plate/Plate/Cylinder").ApplyMaterial("Plate", "Plate - Ring");
            VisualEffectAsset asset = Resources.FindObjectsOfTypeAll<VisualEffectAsset>().Where(vfx => vfx.name == Mod.VFX_NAME).FirstOrDefault();
            if (asset != default)
            {
                VisualEffect vfx = IconPrefab.GetChild("Steam").AddComponent<VisualEffect>();
                vfx.visualEffectAsset = asset;
            }
        }
    }
}
