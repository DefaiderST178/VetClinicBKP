namespace VetClinicBKP.Model
{
    public class Medication
    {
        public int ID_Medication {get; set;} // Идентификатор
        public string Name {get; set;} // Название
        public string Description {get; set;} // Описание
        public string Type {get; set;} // Тип препарата
        public int Price { get; set; } // Цена
        public string Image {get; set;} // Картинка
        public string Composition { get; set; } // Cостав
        public string Use {get; set; } // Применение
        public string Dosage { get; set; } // Дозировка
        public string Advantages { get; set; } // Преимущества
    }
}
