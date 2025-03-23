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
                Price = "3200 руб.",
                Image = "korm.jpg"
            },

            new Tovar() 
            {
                ID_Tovar = 2,
                Name = "Зубная щетка «Toothbrush»",
                Description = "Зубная щетка, состоящая из двух типов щетинок, которые могут использоваться для собак и кошек любых размеров и пород. Щетинки разработаны специально в соответствии с формой зубов собак и кошек. ",
                TovarType = "Зубная щетка",
                Price = "500 руб.",
                Image = "toothbrush.jpg"
            },
        
            new Tovar() 
            {
                ID_Tovar = 3,
                Name = "Игрушка для собак Kong Classic",
                Description = "Прочная игрушка для жевания, подходит для средних и крупных пород.",
                TovarType = "Игрушки",
                Price = "700 руб.",
                Image = "kong.jpg"
            },
        
            new Tovar()
            {
                ID_Tovar = 4,
                Name = "Ошейник от блох и клещей Bayer Kiltix",
                Description = "Защита от паразитов до 7 месяцев.",
                TovarType = "Средства защиты",
                Price = "1900 руб.",
                Image = "kiltixoheinik.jpg"
            },

            new Tovar() 
            {
                ID_Tovar = 5,
                Name = "Наполнитель для кошачьего туалета Cat's Best",
                Description = "Комкующийся наполнитель из натуральных материалов.",
                TovarType = "Туалеты и наполнители",
                Price = "3000 руб.",
                Image = "bestnapoln.jpg"
            },
    
            new Tovar() 
            {
                ID_Tovar = 6,
                Name = "Витамины для щенков 8 in 1 Excel",
                Description = "Комплекс витаминов и минералов для растущих щенков.",
                TovarType = "Витамины и добавки",
                Price = "1200 руб.",
                Image = "excel.jpg"
            },

            new Tovar() 
            {
                ID_Tovar = 7,
                Name = "Переноска для кошек Trixie",
                Description = "Удобная переноска для транспортировки кошек.",
                TovarType = "Транспортировка",
                Price = "1700 руб.",
                Image = "trixie.jpg"
            },
    
            new Tovar() 
            {
                ID_Tovar = 8,
                Name = "Лакомство для собак Pedigree DentaStix",
                Description = "Лакомство для чистки зубов и свежего дыхания.",
                TovarType = "Лакомства",
                Price = "400 руб.",
                Image = "dentastix.jpg"
            },

            new Tovar() 
            {
                ID_Tovar = 9,
                Name = "Лежанка для собак Ferplast",
                Description = "Мягкая лежанка с водонепроницаемым покрытием.",
                TovarType = "Домики и лежанки",
                Price = "2300 руб.",
                Image = "ferplast.jpg"
            },

            new Tovar() 
            {
                ID_Tovar = 10,
                Name = "Щетка для вычесывания шерсти FURminator",
                Description = "Эффективная щетка для удаления подшерстка у собак и кошек.",
                TovarType = "Уход за шерстью",
                Price = "2000 руб.",
                Image = "minator.jpg"
            },
            // Сбор товаров для БД 
            new Tovar()
            {
                ID_Tovar = 11,
                Name = "Миска для кошек и собак",
                Description = "Миска кормушка имеет полностью разборную конструкцию, что делает ее использование очень удобным, при необходимости помыть целиком или только нужную часть.\r\nВсе элементы миски изготовлены из прочного пластика безопасного для животных. Чаши с полезным объемом 250 мл легко крепятся на подставке.",
                TovarType = "Миска",
                Price = "500",
                Image = "doublemiska.jpg"
            },

            //new Tovar()
            //{
            //    ID_Tovar = 12,
            //    Name = "",
            //    Description = "",
            //    TovarType = "",
            //    Price = "",
            //    Image = "image.jpg"
            //}
        };
        public List<Tovar> GetAllTovars()
        {
            return AllTovars;
        }
    }
}
