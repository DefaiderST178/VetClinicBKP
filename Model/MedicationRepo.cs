namespace VetClinicBKP.Model
{
    public class MedicationRepo
    {
        public static List<Medication> AllMedication => new List<Medication>
        {
            new Medication
            {
                ID_Medication = 1,
                Name = "Антибиотик широкого спектра",
                Description = "Используется для лечения бактериальных инфекций у животных.",
                Type = "Антибиотики",
                Image = "antibiotik.jpg"
            },

            new Medication
            {
                ID_Medication = 2,
                Name = "Противогельминтный препарат",
                Description = "Применяется для профилактики и лечения гельминтов у домашних животных.",
                Type = "Противоинфекционные средства",
                Image = "wormer.jpg"
            },

            new Medication
            {
                ID_Medication = 3,
                Name = "Витамины для собак",
                Description = "Комплекс витаминов и минералов для поддержания здоровья и энергии собак.",
                Type = "Витаминные добавки",
                Image = "dog_vitamins.jpg"
            },

            new Medication
            {
                ID_Medication = 4,
                Name = "Обезболивающее средство",
                Description = "Назначается животным после операций или травм для снятия боли.",
                Type = "Анальгетики",
                Image = "painkiller.jpg"
            },

            new Medication
            {
                ID_Medication = 5,
                Name = "Средство против блох и клещей",
                Description = "Защищает питомцев от паразитов, предотвращает укусы насекомых.",
                Type = "Антисептики и дезинфицирующие средства",
                Image = "flea_treatment.jpg"
            },

            new Medication
            {
                ID_Medication = 6,
                Name = "Успокоительное для кошек",
                Description = "Помогает снизить стресс у кошек перед поездкой или визитом к ветеринару.",
                Type = "Транквилизаторы",
                Image = "cat_calm.jpg"
            },

            new Medication
            {
                ID_Medication = 7,
                Name = "Иммуностимулятор",
                Description = "Укрепляет иммунную систему животного, повышает сопротивляемость инфекциям.",
                Type = "Иммунотропные препараты",
                Image = "immune_booster.jpg"
            },

            new Medication
            {
                ID_Medication = 8,
                Name = "Мазь для заживления ран",
                Description = "Используется для ускорения процесса заживления ран и предотвращения инфекций.",
                Type = "Дерматологические средства",
                Image = "healing_ointment.jpg"
            },

            new Medication
            {
                ID_Medication = 9,
                Name = "Шампунь от блох",
                Description = "Предназначен для ухода за кожей и шерстью животных, устраняет перхоть.",
                Type = "Косметические средства",
                Image = "anti_shampoo.jpg"
            },

            new Medication
            {
                ID_Medication = 10,
                Name = "Корма для животных с особыми потребностями",
                Description = "Специальная диета для животных с проблемами пищеварения или аллергиями.",
                Type = "Диетическое питание",
                Image = "special_food.jpg"
            }
        };
        public List<Medication> GetAllMedications()
        {
            return AllMedication;
        }
    }
}
