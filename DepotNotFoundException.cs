using System;
namespace FormTyeplovoz
{

 /// <summary>
 /// Класс-ошибка "Если не найден автомобиль по определенному месту"
 /// </summary>
 public class DepotNotFoundException : Exception
    {
        public DepotNotFoundException(int i) : base("Не найден поезд по месту "+ i)
        { }
    }
}