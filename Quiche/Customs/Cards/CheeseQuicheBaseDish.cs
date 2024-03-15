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
        public override GameObject DisplayPrefab => Mod.Bundle.LoadAsset<GameObject>("CheeseQuicheIcon").AssignMaterialsByNames();
        public override GameObject IconPrefab => DisplayPrefab;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.None;
        public override CardType CardType => CardType.Default;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Medium;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override bool IsAvailableAsLobbyOption => true;
        public override bool IsUnlockable => true;

        public override int Difficulty => 2;

        public override List<string> StartingNameSet => new()
        {
            "Quiche Me If You Can",
            "Quiche Dreams",
            "The Quiche Queen",
            "Quiche & Tell",
            "Quiche It Up",
            "Quiche-y Business",
            "Quiche Cuisine",
            "Quiche My Appetite",
            "The Quiche Stop",
            "Quiche 'n' Chill",
            "Quiche and Quirks",
            "Quiche Craze Cafe",
            "The Quiche Corner",
            "Quiche-licious",
            "Quiche's Delight",
            "Quiche Connection",
            "Quichey Keen Diner",
            "Quiche Lorraine's Hideout",
            "Quiche Cottage",
            "Quiche Kingdom",
            "You want a Quiche of me?",
            "It's not deep dish",

        };


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
                Ingredient = Mod.CheeseQuicheSlice,
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
            { Locale.English, "Knead flour (or add water) to create dough, then knead into pie crust. Cook crust, add chopped egg and chopped cheese and cook again." },
            { Locale.French, "Pétrir la farine (ou ajouter de l'eau) pour créer une pâte, puis pétrir pour en faire une croûte à tarte. Cuire la croûte, ajouter de l'œuf haché et du fromage haché puis cuire à nouveau." },
            { Locale.German, "Mehl kneten (oder Wasser hinzufügen), um einen Teig zu erstellen, dann zu einem Kuchenboden kneten. Boden backen, gehacktes Ei und gehackten Käse hinzufügen und nochmals backen." },
            { Locale.Spanish, "Amasar la harina (o añadir agua) para crear la masa, luego amasar para formar la base del pastel. Cocinar la base, añadir huevo picado y queso picado y cocinar de nuevo." },
            { Locale.Polish, "Zagnieść mąkę (lub dodać wodę), aby uzyskać ciasto, następnie zagnieść ciasto na spód do tarty. Piec spód, dodać posiekane jajko i posiekany ser i piec ponownie." },
            { Locale.Russian, "Замесить муку (или добавить воду) для создания теста, затем вымесить его в корж для пирога. Выпекать корж, добавить нарезанное яйцо и нарезанный сыр и снова выпекать." },
            { Locale.PortugueseBrazil, "Amassar a farinha (ou adicionar água) para criar a massa, depois amassar para formar a crosta da torta. Cozinhar a crosta, adicionar ovo picado e queijo picado e cozinhar novamente." },
            { Locale.Japanese, "小麦粉をこねて（または水を加えて）生地を作り、それをパイ生地にこねる。生地を焼き、刻んだ卵と刻んだチーズを加えて再び焼く。" },
            { Locale.ChineseSimplified, "揉面粉（或加水）制成面团，然后揉成派皮。烤制派皮，加入切碎的鸡蛋和切碎的奶酪再次烹饪。" },
            { Locale.ChineseTraditional, "揉麵粉（或加水）製成麵團，然後揉成派皮。烤製派皮，加入切碎的雞蛋和切碎的奶酪再次烹飪。" },
            { Locale.Korean, "밀가루를 반죽하여(또는 물을 추가하여) 반죽을 만들고, 파이 크러스트로 다시 반죽하세요. 크러스트를 요리하고, 다진 계란과 다진 치즈를 추가한 후 다시 요리하세요." },
            { Locale.Turkish, "Hamur oluşturmak için unu yoğurun (veya su ekleyin), sonra pasta tabanını yoğurun. Kabuğu pişirin, doğranmış yumurta ve doğranmış peynir ekleyip tekrar pişirin." },
        };


        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
            (Locale.English, LocalisationUtils.CreateUnlockInfo("Cheese Quiche", "Adds Cheese Quiche as a main", "The real slice of life. Or breakfast. Or dinner. Who's counting?")),
            (Locale.French, LocalisationUtils.CreateUnlockInfo("Quiche au Fromage", "Ajoute la Quiche au Fromage comme plat principal", "La vraie tranche de vie. Ou petit-déjeuner. Ou dîner. Qui compte ?")),
            (Locale.German, LocalisationUtils.CreateUnlockInfo("Käse-Quiche", "Fügt Käse-Quiche als Hauptgericht hinzu", "Das echte Stück Leben. Oder Frühstück. Oder Abendessen. Wer zählt schon?")),
            (Locale.Spanish, LocalisationUtils.CreateUnlockInfo("Quiche de Queso", "Agrega Quiche de Queso como plato principal", "La verdadera rebanada de la vida. O desayuno. O cena. ¿Quién está contando?")),
            (Locale.Polish, LocalisationUtils.CreateUnlockInfo("Quiche z Serem", "Dodaje Quiche z Serem jako danie główne", "Prawdziwy kawał życia. Albo śniadanie. Albo kolacja. Kto to zlicza?")),
            (Locale.Russian, LocalisationUtils.CreateUnlockInfo("Чизкейк с сыром", "Добавляет Чизкейк с сыром в качестве основного блюда", "Настоящий кусок жизни. Или завтрак. Или ужин. Кто считает?")),
            (Locale.PortugueseBrazil, LocalisationUtils.CreateUnlockInfo("Quiche de Queijo", "Adiciona Quiche de Queijo como prato principal", "A verdadeira fatia da vida. Ou café da manhã. Ou jantar. Quem está contando?")),
            (Locale.Japanese, LocalisationUtils.CreateUnlockInfo("チーズキッシュ", "メインとしてチーズキッシュを追加", "本物の人生の一片。または朝食。または夕食。誰が数えてる？")),
            (Locale.ChineseSimplified, LocalisationUtils.CreateUnlockInfo("奶酪蛋饼", "将奶酪蛋饼作为主菜添加", "真实生活的一角。或早餐。或晚餐。谁在计数？")),
            (Locale.ChineseTraditional, LocalisationUtils.CreateUnlockInfo("奶酪蛋餅", "將奶酪蛋餅作為主菜添加", "真實生活的一角。或早餐。或晚餐。誰在計數？")),
            (Locale.Korean, LocalisationUtils.CreateUnlockInfo("치즈 퀴시", "주 메뉴로 치즈 퀴시 추가", "진정한 삶의 한 조각. 아침이나 저녁, 누가 세나?")),
            (Locale.Turkish, LocalisationUtils.CreateUnlockInfo("Peynirli Kiş", "Ana yemek olarak Peynirli Kiş ekler", "Gerçek yaşam dilimi. Ya da kahvaltı. Ya da akşam yemeği. Kim sayıyor?"))
        };


        public override void OnRegister(Dish gameDataObject)
        {
            VisualEffectAsset asset = Resources.FindObjectsOfTypeAll<VisualEffectAsset>().Where(vfx => vfx.name == Mod.VFX_NAME).FirstOrDefault();
            if (asset != default)
            {
                VisualEffect vfx = IconPrefab.GetChild("Steam").AddComponent<VisualEffect>();
                vfx.visualEffectAsset = asset;
            }
        }
    }
}
