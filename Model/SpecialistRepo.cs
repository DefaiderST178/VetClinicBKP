namespace VetClinicBKP.Model
{
    public class SpecialistRepo
    {
        public static List<Specialist> AllSpecialist => new List<Specialist>
        {
            new  Specialist
            {
                ID_Specialist = 1,
                Name = "Иванов А.А.",
                Description = "Опытный врач с 15-летним стажем",
                TypeSpecialist = "Терапевт",
                Service = "Консультация",
                Price= "1000 рублей"
            },

            new  Specialist
            {
                ID_Specialist = 2,
                Name = "Петров С.И.",
                Description = "Специалист по хирургии мелких животных",
                TypeSpecialist = "Хирург",
                Service = "Операция",
                Price= "3000 рублей"
            },

            new  Specialist
            {
                ID_Specialist = 3,
                Name = "Сидоров Е.К.",
                Description = "Врач-диагност, УЗИ и рентген",
                TypeSpecialist = "Диагност",
                Service = "Ультразвуковое сканирование",
                Price= "1500 рублей"
            },

            new  Specialist
            {
                ID_Specialist = 4,
                Name = "Васильева О.Н.",
                Description = "Дерматолог, специалист по кожным заболеваниям",
                TypeSpecialist = "Дерматолог",
                Service = "Лечение дерматита",
                Price= "1200 рублей"
            },

            new  Specialist
            {
                ID_Specialist = 5,
                Name = "Смирнов К.В.",
                Description = "Ветеринарный стоматолог",
                TypeSpecialist = "Стоматолог",
                Service = "Чистка зубов",
                Price= "800 рублей"
            },

            new  Specialist
            {
                ID_Specialist = 6,
                Name = "Козлова М.С.", 
                Description = "Ортопед, лечение переломов",
                TypeSpecialist = "Ортопед",
                Service = "Рентген конечностей",
                Price= "2000 рублей"
            },

            new  Specialist
            {
                ID_Specialist = 7,
                Name = "Андреев П.Р.",
                Description = "Невролог, диагностика и лечение неврологических заболеваний",
                TypeSpecialist = "Невролог",
                Service = "Электроэнцефалография",
                Price= "2500 рублей"
            },

            new  Specialist
            {
                ID_Specialist = 8,
                Name = "Михайлова Л.Е.",
                Description = "Офтальмолог, заболевания глаз",
                TypeSpecialist = "Офтальмолог",
                Service = "Осмотр глазного дна",
                Price= "1800 рублей"
            },

            new  Specialist
            {
                ID_Specialist = 9,
                Name = "Кузнецов Н.Д.",
                Description = "Кардиолог, сердечно-сосудистые болезни",
                TypeSpecialist = "Кардиолог",
                Service = "ЭКГ",
                Price= "1400 рублей"
            },

            new  Specialist
            {
                ID_Specialist = 10,
                Name = "Белова Ю.Ю.",
                Description = "Эндокринолог, гормональные нарушения",
                TypeSpecialist = "Эндокринолог",
                Service = "Анализ крови на гормоны",
                Price= "1600 рублей"
            },
        };
        public List<Specialist> GetAllSpecialists()
        {
            return AllSpecialist;
        }
    }
}