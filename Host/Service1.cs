using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Host
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Service1 : IService1
    {
        DataBaseFORKREntities data = new DataBaseFORKREntities();

        public List<RequestSet> GetData() =>
            data.RequestSet.ToList();

        public void SetData(string autor, string description)
        {
            data.RequestSet.Add(new RequestSet() { Date = DateTime.Now, Autor = autor, Description = description });
            data.SaveChanges();
            Program.WriteServiceWorkInfo($"Была добавлена новая запись. Всего записей: {data.RequestSet.Count()}");
        }
    }
}
