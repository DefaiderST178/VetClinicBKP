namespace VetClinicBKP.Model
{
    public class TovarRepo
    {
        List<Tovar> AllTovars = new List<Tovar>() 
        {
            new Tovar
            {
                ID_Tovar = 1,
                Name = "Корм для собак Royal Canin",
                Description = "Высококачественный корм для взрослых собак всех пород.",
                TovarType = "Корма",
                Price = "1500 руб."
            },

            new Tovar() 
            {
                ID_Tovar = 2,
                Name = "Шампунь для кошек Beaphar",
                Description = "Гипоаллергенный шампунь для ухода за шерстью кошек.",
                TovarType = "Уход за животными",
                Price = "500 руб."
            },
        
            new Tovar() 
            {
                ID_Tovar = 3,
                Name = "Игрушка для собак Kong Classic",
                Description = "Прочная игрушка для жевания, подходит для средних и крупных пород.",
                TovarType = "Игрушки",
                Price = "700 руб."
            },
        
            new Tovar()
            {
                ID_Tovar = 4,
                Name = "Ошейник от блох и клещей Bayer Kiltix",
                Description = "Защита от паразитов до 7 месяцев.",
                TovarType = "Средства защиты",
                Price = "900 руб."
            },

            new Tovar() 
            {
                ID_Tovar = 5,
                Name = "Наполнитель для кошачьего туалета Cat's Best",
                Description = "Комкующийся наполнитель из натуральных материалов.",
                TovarType = "Туалеты и наполнители",
                Price = "600 руб."
            },
    
            new Tovar() 
            {
                ID_Tovar = 6,
                Name = "Витамины для щенков 8 in 1 Excel",
                Description = "Комплекс витаминов и минералов для растущих щенков.",
                TovarType = "Витамины и добавки",
                Price = "1200 руб."
            },

            new Tovar() 
            {
                ID_Tovar = 7,
                Name = "Переноска для кошек Trixie",
                Description = "Удобная переноска для транспортировки кошек.",
                TovarType = "Транспортировка",
                Price = "1700 руб."
            },
    
            new Tovar() 
            {
                ID_Tovar = 8,
                Name = "Лакомство для собак Pedigree DentaStix",
                Description = "Лакомство для чистки зубов и свежего дыхания.",
                TovarType = "Лакомства",
                Price = "400 руб."
            },

            new Tovar() 
            {
                ID_Tovar = 9,
                Name = "Лежанка для собак Ferplast",
                Description = "Мягкая лежанка с водонепроницаемым покрытием.",
                TovarType = "Домики и лежанки",
                Price = "2300 руб."
            },

            new Tovar() 
            {
                ID_Tovar = 10,
                Name = "Щетка для вычесывания шерсти FURminator",
                Description = "Эффективная щетка для удаления подшерстка у собак и кошек.",
                TovarType = "Уход за шерстью",
                Price = "2000 руб."
            }
        };
        public List<Tovar> GetAllTovars()
        {
            return AllTovars;
        }
    }
}
