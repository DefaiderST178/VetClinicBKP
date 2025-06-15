namespace VetClinicBKP.Model
{
    public class TovarRepo
    {
        // Кластер 2 - Корма
        List<Tovar> AllFeeds = new List<Tovar>()
        {                    
            new Tovar()
            {
                ID_Tovar = 1,
                Name = "Витамины для щенков 8 in 1 Excel",
                Description = "Комплекс витаминов и минералов для растущих щенков.",
                TovarType = "Корма",
                Price = "1200 рублей",
                Image = "excel.jpg"
            },    
            new Tovar()
            {
                ID_Tovar = 2,
                Name = "Лакомство для собак Pedigree DentaStix",
                Description = "Лакомство для чистки зубов и свежего дыхания.",
                TovarType = "Корма",
                Price = "400 рублей",
                Image = "dentastix.jpg"
            },
            new Tovar
            {
                ID_Tovar = 3,
                Name = "Корм для собак Royal Canin",
                Description = "Высококачественный корм для взрослых собак всех пород.",
                TovarType = "Корма",
                Price = "3200 рублей",
                Image = "korm.jpg"
            },        
        };
        public List<Tovar> GetAllFeeds()
        {
            return AllFeeds;
        }

        // Кластер 2 - Средства ухода
        List<Tovar> AllCare = new List<Tovar>()
        {
            new Tovar()
            {
                ID_Tovar = 4,
                Name = "Зубная щетка «Toothbrush»",
                Description = "Зубная щетка, состоящая из двух типов щетинок, которые могут использоваться для собак и кошек любых размеров и пород. Щетинки разработаны специально в соответствии с формой зубов собак и кошек. ",
                TovarType = "Уход и содержание",
                Price = "500 рублей",
                Image = "toothbrush.jpg"
            },
            new Tovar()
            {
                ID_Tovar = 5,
                Name = "Лежанка для собак Ferplast",
                Description = "Мягкая лежанка с водонепроницаемым покрытием.",
                TovarType = "Уход и содержание",
                Price = "2300 рублей",
                Image = "ferplast.jpg"
            },
            new Tovar()
            {
                ID_Tovar = 6,
                Name = "Миска для кошек и собак",
                Description = "Миска кормушка имеет полностью разборную конструкцию, что делает ее использование очень удобным, при необходимости помыть целиком или только нужную часть.\r\nВсе элементы миски изготовлены из прочного пластика безопасного для животных. Чаши с полезным объемом 250 мл легко крепятся на подставке.",
                TovarType = "Уход и содержание",
                Price = "500 рублей",
                Image = "doublemiska.jpg"
            },
            new Tovar()
            {
                ID_Tovar = 7,
                Name = "Наполнитель для кошачьего туалета Cat's Best",
                Description = "Комкующийся наполнитель из натуральных материалов.",
                TovarType = "Уход и содержание",
                Price = "3000 рублей",
                Image = "bestnapoln.jpg"
            },
            new Tovar()
            {
                ID_Tovar = 8,
                Name = "Ошейник от блох и клещей Bayer Kiltix",
                Description = "Защита от паразитов до 7 месяцев.",
                TovarType = "Уход и содержание",
                Price = "1900 рублей",
                Image = "kiltixoheinik.jpg"
            },
            new Tovar()
            {
                ID_Tovar = 9,
                Name = "Переноска для кошек Trixie",
                Description = "Удобная переноска для транспортировки кошек.",
                TovarType = "Уход и содержание",
                Price = "1700 рублей",
                Image = "trixie.jpg"
            },
            new Tovar()
            {
                ID_Tovar = 10,
                Name = "Щетка для вычесывания шерсти FURminator",
                Description = "Эффективная щетка для удаления подшерстка у собак и кошек.",
                TovarType = "Уход и содержание",
                Price = "2000 рублей",
                Image = "minator.jpg"
            },
        };
        public List<Tovar> GetAllCare()
        {
            return AllCare;
        }

        // Кластер 3 - Игрушки
        List<Tovar> AllToys = new List<Tovar>()
        {
            new Tovar()
            {
                ID_Tovar = 11,
                Name = "Игрушка для собак Kong Classic",
                Description = "Прочная игрушка для жевания, подходит для средних и крупных пород собак.",
                TovarType = "Игрушки",
                Price = "700 рублей",
                Image = "kong.jpg"
            },
            new Tovar()
            {
                ID_Tovar = 12,
                Name = "Мышка для кошек",
                Description = "Игрушка мышка из натурального меха, серого цвета. Размер: 45 мм",
                TovarType = "Игрушки",
                Price = "120 рублей",
                Image = "mouse.jpg"
            },
            new Tovar()
            {
                ID_Tovar = 13,
                Name = "Игрушка нитяная для собак",
                Description = "Игрушка Косточка нитяная с 3 узлами и мячиком. Вес: 0,2 кг.",
                TovarType = "Игрушки",
                Price = "270 рублей",
                Image = "floss.jpg"
            },
            new Tovar()
            {
                ID_Tovar = 14,
                Name = "Звонкий шарик для попугаев",
                Description = "Игрушка для птиц в виде звонкого шарика на кольцах. Цвет: в ассортименте. Размер: 20х4 см.",
                TovarType = "Игрушки",
                Price = "190 рублей",
                Image = "balls.jpg"
            }

        };
        public List<Tovar> GetAllToys()
        {
            return AllToys;
        }
    }
}
