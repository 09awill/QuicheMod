using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;
using KitchenQuiche;

namespace Quiche.Customs.Cards
{
    class LorraineQuicheCard : CustomDish
    {
        public override string UniqueNameID => "Lorraine Quiche Dish";
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
                Ingredient = Mod.LorraineQuicheSlice,
                MenuItem = Mod.PlatedQuiche
            }
        };
        public override HashSet<Item> MinimumIngredients => new HashSet<Item>
        {
            Mod.Egg,
            Mod.Flour,
            Mod.Plate,
            Mod.Cheese,
            Mod.Bacon
        };
        public override HashSet<Process> RequiredProcesses => new HashSet<Process>
        {
            Mod.Cook,
            Mod.Chop,
            Mod.RequireOven
        };
        public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string>
        {
            { Locale.English, "Knead flour (or add water) to create dough, then knead into pie crust. Cook crust. Chop pork and then cook to make bacon. Add chopped egg, chopped cheese and bacon to the cooked crust then cook again." },
            { Locale.French, "Pétrissez la farine (ou ajoutez de l'eau) pour créer une pâte, puis formez une croûte de tarte. Cuisez la croûte. Coupez le porc en morceaux puis faites-le cuire pour obtenir du bacon. Ajoutez de l'œuf haché, du fromage haché et du bacon sur la croûte cuite puis faites cuire à nouveau." },
            { Locale.German, "Kneten Sie Mehl (oder fügen Sie Wasser hinzu), um Teig herzustellen, und formen Sie ihn zu einem Tortenboden. Backen Sie den Boden. Schweinefleisch hacken und dann kochen, um Speck zu machen. Fügen Sie gehacktes Ei, gehackten Käse und Speck zum gebackenen Boden hinzu und backen Sie es erneut." },
            { Locale.Spanish, "Amasa la harina (o añade agua) para crear la masa, luego forma una base de tarta. Cocina la base. Pica el cerdo y luego cocínalo para hacer bacon. Añade huevo picado, queso picado y bacon a la base cocida y luego cocina de nuevo." },
            { Locale.Polish, "Wyrabiaj mąkę (lub dodaj wodę), aby uzyskać ciasto, a następnie zagnieść ciasto na spód do tarty. Upiecz spód. Pokrój wieprzowinę i ugotuj, aby zrobić boczek. Dodaj posiekane jajko, posiekany ser i boczek do upieczonego spodu i piecz ponownie." },
            { Locale.Russian, "Замесите муку (или добавьте воду) для теста, затем сформируйте корж для пирога. Выпеките корж. Нарежьте свинину и приготовьте, чтобы получить бекон. Добавьте нарезанное яйцо, нарезанный сыр и бекон на приготовленную корку, затем снова запеките." },
            { Locale.PortugueseBrazil, "Amasse a farinha (ou adicione água) para fazer a massa, depois modele em uma crosta de torta. Cozinhe a crosta. Pique o porco e então cozinhe para fazer bacon. Adicione ovo picado, queijo picado e bacon à crosta cozida e cozinhe novamente." },
            { Locale.Japanese, "小麦粉をこねて（または水を加えて）生地を作り、それをパイ生地にこね上げます。生地を焼きます。豚肉を切って焼いてベーコンを作ります。焼いた生地に刻んだ卵、刻んだチーズ、ベーコンを加えて再び焼きます。" },
            { Locale.ChineseSimplified, "揉面粉（或加水）做成面团，然后揉成饼皮。烤制饼皮。切碎猪肉，然后烹饪制作成培根。在烤好的饼皮上加入切碎的鸡蛋、切碎的奶酪和培根，然后再次烹饪。" },
            { Locale.ChineseTraditional, "揉麵粉（或加水）做成麵團，然後揉成餅皮。烤制餅皮。切碎豬肉，然後烹飪製作成培根。在烤好的餅皮上加入切碎的雞蛋、切碎的奶酪和培根，然後再次烹飪。" },
            { Locale.Korean, "밀가루를 반죽하여(또는 물을 추가하여) 반죽을 만들고, 그것을 파이 크러스트로 만듭니다. 크러스트를 굽습니다. 돼지고기를 썰어서 베이컨을 만듭니다. 익힌 크러스트에 다진 계란, 다진 치즈, 베이컨을 추가하고 다시 굽습니다." },
            { Locale.Turkish, "Unu yoğurun (veya su ekleyin) hamur yapın, sonra hamuru turtanın alt tabanına dönüştürün. Tabanı pişirin. Domuz etini doğrayın ve sonra bacon yapmak için pişirin. Pişmiş tabana doğranmış yumurta, doğranmış peynir ve bacon ekleyip tekrar pişirin." }
        };


        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
            (Locale.English, LocalisationUtils.CreateUnlockInfo("Quiche Lorraine", "Adds Quiche Lorraine as a main", "Dive into the decadence of this classic French creation")),
            (Locale.French, LocalisationUtils.CreateUnlockInfo("Quiche Lorraine", "Ajoute la Quiche Lorraine comme plat principal", "Plongez dans la décadence de cette création française classique")),
            (Locale.German, LocalisationUtils.CreateUnlockInfo("Quiche Lorraine", "Fügt Quiche Lorraine als Hauptgericht hinzu", "Tauchen Sie ein in den Luxus dieses klassischen französischen Gerichts")),
            (Locale.Spanish, LocalisationUtils.CreateUnlockInfo("Quiche Lorraine", "Agrega Quiche Lorraine como plato principal", "Sumérgete en la decadencia de esta creación clásica francesa")),
            (Locale.Polish, LocalisationUtils.CreateUnlockInfo("Quiche Lorraine", "Dodaje Quiche Lorraine jako danie główne", "Zanurz się w przepychu tego klasycznego francuskiego dania")),
            (Locale.Russian, LocalisationUtils.CreateUnlockInfo("Киш Лорен", "Добавляет Киш Лорен в качестве основного блюда", "Окунитесь в роскошь этого классического французского блюда")),
            (Locale.PortugueseBrazil, LocalisationUtils.CreateUnlockInfo("Quiche Lorraine", "Adiciona Quiche Lorraine como prato principal", "Mergulhe na decadência desta criação clássica francesa")),
            (Locale.Japanese, LocalisationUtils.CreateUnlockInfo("キッシュ・ロレーヌ", "メインとしてキッシュ・ロレーヌを追加", "このクラシックなフランス料理の贅沢さに没頭します")),
            (Locale.ChineseSimplified, LocalisationUtils.CreateUnlockInfo("洛林蛋饼", "将洛林蛋饼作为主菜添加", "尽情享受这款经典法式美食的奢华")),
            (Locale.ChineseTraditional, LocalisationUtils.CreateUnlockInfo("洛林蛋餅", "將洛林蛋餅作為主菜添加", "盡情享受這款經典法式美食的奢華")),
            (Locale.Korean, LocalisationUtils.CreateUnlockInfo("키쉬 로렌", "주 메뉴로 키쉬 로렌 추가", "이 클래식한 프랑스 요리의 풍채에 빠져보세요")),
            (Locale.Turkish, LocalisationUtils.CreateUnlockInfo("Quiche Lorraine", "Ana yemek olarak Quiche Lorraine ekler", "Bu klasik Fransız lezzetinin ihtişamına dalın"))
        };



    }
}
