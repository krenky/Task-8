using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    public abstract class Tariff
    {
        protected Tariff(string Input)
        {
            NameTarrif1 = Input;
        }
        string NameTarrif;

        public string NameTarrif1 { get => NameTarrif; set => NameTarrif = value; }
        abstract public string PrintInfo();
    }
    class bezlemith : Tariff
    {
        int SumMonth;

        public bezlemith(string Input, int sum) : base(Input)
        {
            SumMonth1 = sum;
        }

        public int SumMonth1 { get => SumMonth; set => SumMonth = value; }

        public override string PrintInfo()
        {
            string str = "Сумма " + SumMonth1 + "\n" + "Название тарифа: " + NameTarrif1;
            return str;
        }
    }
    class MinuteTariff : Tariff
    {
        int KolMin;

        public MinuteTariff(string Input, int kolmin) : base(Input)
        {
            KolMin1 = kolmin;
        }

        public int KolMin1 { get => KolMin; set => KolMin = value; }

        public override string PrintInfo()
        {
            string str = "Минут/Руб " + KolMin + "\n" + "Название тарифа: " + NameTarrif1;
            return str;
        }
    }
}
