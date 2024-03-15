using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;
using KitchenQuiche;

namespace Quiche.Customs.Cards
{
    class CheeseTomatoQuicheCard : CustomDish
    {
        public override string UniqueNameID => "Cheese Tomato Quiche Dish";
        public override DishType Type => DishType.Main;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override CardType CardType => CardType.Default;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Medium;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override List<Unlock> HardcodedRequirements => new()
        {
            Mod.CheeseQuicheBaseDish
        };
        public override int Difficulty => 2;

        public override HashSet<Dish.IngredientUnlock> IngredientsUnlocks => new()
        {
            new Dish.IngredientUnlock
            {
                Ingredient = Mod.CheeseTomatoQuicheSlice,
                MenuItem = Mod.PlatedQuiche
            }
        };
        public override HashSet<Item> MinimumIngredients => new HashSet<Item>
        {
            Mod.Egg,
            Mod.Flour,
            Mod.Plate,
            Mod.Cheese,
            Mod.Tomato
        };
        public override HashSet<Process> RequiredProcesses => new HashSet<Process>
        {
            Mod.Cook,
            Mod.Chop,
            Mod.RequireOven
        };
        public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string>
        {
            { Locale.English, "Knead flour (or add water) to create dough, then knead into pie crust. Cook crust, add chopped egg, chopped cheese and chopped tomato and then cook again." },
            { Locale.French, "Pétrir la farine (ou ajouter de l'eau) pour créer une pâte, puis en faire une croûte à tarte. Cuire la croûte, ajouter un œuf haché, du fromage haché et de la tomate hachée puis cuire à nouveau." },
            { Locale.German, "Mehl kneten (oder Wasser hinzufügen), um Teig zu formen, dann zu einem Kuchenboden verarbeiten. Boden backen, gehacktes Ei, gehackten Käse und gehackte Tomate hinzufügen und erneut backen." },
            { Locale.Spanish, "Amasar la harina (o añadir agua) para crear la masa, luego amasar para formar la base de la tarta. Cocinar la base, añadir huevo picado, queso picado y tomate picado y cocinar de nuevo." },
            { Locale.Polish, "Zagnieść mąkę (lub dodać wodę), aby uzyskać ciasto, następnie wyrobić spód do ciasta. Piec spód, dodać posiekane jajko, posiekany ser i posiekanego pomidora, a następnie piec ponownie." },
            { Locale.Russian, "Замесить муку (или добавить воду) для создания теста, затем сформировать корж для пирога. Выпекать корж, добавить нарезанное яйцо, нарезанный сыр и нарезанный помидор, затем снова выпекать." },
            { Locale.PortugueseBrazil, "Amassar a farinha (ou adicionar água) para criar massa, depois amassar para formar a crosta de torta. Cozinhar a crosta, adicionar ovo picado, queijo picado e tomate picado e cozinhar novamente." },
            { Locale.Japanese, "小麦粉をこねて（または水を加えて）生地を作り、それをパイ生地にこねる。生地を焼き、刻んだ卵、刻んだチーズ、刻んだトマトを加えて再び焼く。" },
            { Locale.ChineseSimplified, "揉面粉（或加水）制成面团，然后揉成派皮。烤派皮，加入切碎的鸡蛋、切碎的奶酪和切碎的番茄，然后再次烹饪。" },
            { Locale.ChineseTraditional, "揉麵粉（或加水）製成麵團，然後揉成派皮。烤派皮，加入切碎的雞蛋、切碎的奶酪和切碎的番茄，然後再次烹飪。" },
            { Locale.Korean, "밀가루를 반죽하여(또는 물을 추가하여) 반죽을 만들고, 그것을 파이 크러스트로 만듭니다. 크러스트를 요리하고, 다진 계란, 다진 치즈, 다진 토마토를 추가한 다음 다시 요리하세요." },
            { Locale.Turkish, "Unu yoğurarak (veya su ekleyerek) hamur yapın, sonra bu hamuru pasta tabanına yoğurun. Tabanı pişirin, üzerine doğranmış yumurta, doğranmış peynir ve doğranmış domates ekleyip tekrar pişirin." }
        };

        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
            (Locale.English, LocalisationUtils.CreateUnlockInfo("Cheese and Tomato Quiche", "Adds Cheese and Tomato Quiche as a main", "Adding a pop of tomato freshness to your virtual culinary repertoire.")),
            (Locale.French, LocalisationUtils.CreateUnlockInfo("Quiche au Fromage et Tomate", "Ajoute la Quiche au Fromage et Tomate comme plat principal", "Ajout d'une touche de fraîcheur de tomate à votre répertoire culinaire virtuel.")),
            (Locale.German, LocalisationUtils.CreateUnlockInfo("Käse- und Tomaten-Quiche", "Fügt Käse- und Tomaten-Quiche als Hauptgericht hinzu", "Frische Tomaten verleihen Ihrem virtuellen kulinarischen Repertoire den letzten Schliff.")),
            (Locale.Spanish, LocalisationUtils.CreateUnlockInfo("Quiche de Queso y Tomate", "Agrega Quiche de Queso y Tomate como plato principal", "Agregando un toque de frescura de tomate a tu repertorio culinario virtual.")),
            (Locale.Polish, LocalisationUtils.CreateUnlockInfo("Quiche z Serem i Pomidorami", "Dodaje Quiche z Serem i Pomidorami jako danie główne", "Dodanie odrobiny świeżości pomidorów do twojego wirtualnego repertuaru kulinarnego.")),
            (Locale.Russian, LocalisationUtils.CreateUnlockInfo("Чизкейк с сыром и томатами", "Добавляет Чизкейк с сыром и томатами в качестве основного блюда", "Добавление свежести томатов в ваш виртуальный кулинарный репертуар.")),
            (Locale.PortugueseBrazil, LocalisationUtils.CreateUnlockInfo("Quiche de Queijo e Tomate", "Adiciona Quiche de Queijo e Tomate como prato principal", "Adicionando um toque de frescor de tomate ao seu repertório culinário virtual.")),
            (Locale.Japanese, LocalisationUtils.CreateUnlockInfo("チーズとトマトのキッシュ", "メインとしてチーズとトマトのキッシュを追加", "トマトの新鮮さを仮想の料理レパートリーに加える。")),
            (Locale.ChineseSimplified, LocalisationUtils.CreateUnlockInfo("奶酪和番茄饼", "将奶酪和番茄饼作为主菜添加", "为您的虚拟烹饪技巧增添一丝番茄的清新。")),
            (Locale.ChineseTraditional, LocalisationUtils.CreateUnlockInfo("奶酪和蕃茄餅", "將奶酪和蕃茄餅作為主菜添加", "為您的虛擬烹飪技巧增添一絲蕃茄的清新。")),
            (Locale.Korean, LocalisationUtils.CreateUnlockInfo("치즈와 토마토 퀴시", "주 메뉴로 치즈와 토마토 퀴시 추가", "토마토의 신선함을 가상의 조리 기술에 더합니다.")),
            (Locale.Turkish, LocalisationUtils.CreateUnlockInfo("Peynir ve Domatesli Kiş", "Ana yemek olarak Peynir ve Domatesli Kiş ekler", "Sanal mutfak repertuarınıza domatesin tazeliğini ekleyin."))
        };




    }
}
