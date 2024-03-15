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
                Ingredient = Mod.CheeseTomatoQuiche,
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

        };
        public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string>
        {
            { Locale.English, "Chop pork then cook to get bacon, then combine with plated jacket potato with filling!" },
            { Locale.French, "Coupez le porc, puis faites cuire pour obtenir du bacon, puis combinez avec une pomme de terre en robe avec garniture !" },
            { Locale.German, "Schneiden Sie Schweinefleisch, um Speck zu erhalten, und kombinieren Sie es dann mit einer gefüllten Jackenkartoffel!" },
            { Locale.Spanish, "Corte el cerdo, luego cocine para obtener tocino, luego combine con una chaqueta de patata rellena!" },
            { Locale.Polish, "Pokrój wieprzowinę, aby uzyskać boczek, a następnie połącz z upieczonym ziemniakiem z nadzieniem!" },
            { Locale.Russian, "Нарежьте свинину, затем обжарьте, чтобы получить бекон, затем соедините с картофельной курткой с начинкой!" },
            { Locale.PortugueseBrazil, "Corte o porco, depois cozinhe para obter bacon e depois combine com uma batata assada com recheio!" },
            { Locale.Japanese, "豚肉を切って、ベーコンを作り、ジャケットポテトと具材と組み合わせます！" },
            { Locale.ChineseSimplified, "切猪肉，然后煮成培根，然后与带馅土豆一起搭配！" },
            { Locale.ChineseTraditional, "切豬肉，然後煮成培根，然後與帶餡土豆一起搭配！" },
            { Locale.Korean, "돼지고기를 썰어 베이컨을 만든 다음, 피망이 들어간 감자 자켓과 함께 섞어주세요!" },
            { Locale.Turkish, "Domuz etini doğrayın, sonra pastırmayı elde etmek için pişirin, ardından doldurulmuş patates ceketiyle birleştirin!" }
        };

        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
            ( Locale.English, LocalisationUtils.CreateUnlockInfo("Jacket Potato Bacon Topping", "Adds Bacon as a topping for jacket potato", "Delicious bacon") ),
            ( Locale.French, LocalisationUtils.CreateUnlockInfo("Garniture de Pomme de Terre au Bacon", "Ajoute du bacon comme garniture pour la pomme de terre en robe des champs", "Délicieux bacon") ),
            ( Locale.German, LocalisationUtils.CreateUnlockInfo("Jacketkartoffel mit Specktopping", "Fügt Speck als Topping für die Jackenkartoffel hinzu", "Köstlicher Speck") ),
            ( Locale.Spanish, LocalisationUtils.CreateUnlockInfo("Topping de Tocino para Patata en Chaqueta", "Agrega tocino como topping para la patata en chaqueta", "Delicioso tocino") ),
            ( Locale.Polish, LocalisationUtils.CreateUnlockInfo("Boczek na Ziemniaku w Pelerynie", "Dodaje boczek jako dodatek do ziemniaka w mundurku", "Pyszny boczek") ),
            ( Locale.Russian, LocalisationUtils.CreateUnlockInfo("Топпинг картофель с беконом", "Добавьте бекон как топпинг для картофеля в мундире", "Вкусный бекон") ),
            ( Locale.PortugueseBrazil, LocalisationUtils.CreateUnlockInfo("Cobertura de Bacon para Batata Assada", "Adiciona bacon como cobertura para a batata assada", "Bacon delicioso") ),
            ( Locale.Japanese, LocalisationUtils.CreateUnlockInfo("ジャケットポテトベーコントッピング", "ジャケットポテト用のベーコンを追加", "美味しいベーコン") ),
            ( Locale.ChineseSimplified, LocalisationUtils.CreateUnlockInfo("夹克土豆培根餐盖", "将培根添加为夹克土豆的餐盖", "美味的培根") ),
            ( Locale.ChineseTraditional, LocalisationUtils.CreateUnlockInfo("夾克馬鈴薯培根餐蓋", "將培根添加為夾克馬鈴薯的餐蓋", "美味的培根") ),
            ( Locale.Korean, LocalisationUtils.CreateUnlockInfo("자켓 감자 베이컨 토핑", "자켓 감자 토핑으로 베이컨 추가", "맛있는 베이컨") ),
            ( Locale.Turkish, LocalisationUtils.CreateUnlockInfo("Ceket Patates Bacon Kaplama", "Ceket patates için kaplama olarak bacon ekler", "Lezzetli bacon") ),

        };



    }
}
