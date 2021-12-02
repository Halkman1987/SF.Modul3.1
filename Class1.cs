
using System;
namespace МатьОтецРебенок
{
    // Инкапсуляция в классе MFC
    public class MFC
    {
        protected string mother;
        protected string father;
        protected string child;
        public MFC(string m, string f, string c)
        {
            mother = m;
            father = f;
            child = c;
        }
        // возврат имени ребенка
        public virtual string GetChild()
        {
            return child;
        }
        // вывод имен членов семьи
        public virtual void Output()
        {
            Console.WriteLine("Mать: " + mother + " отец: " + father);
            Console.WriteLine("Ребенок: " + child);
        }
        // Рисование разграничительной линии (пригодится)
        public virtual void Tir()
        {
            Console.WriteLine("_____________________________");
        }
    }
}