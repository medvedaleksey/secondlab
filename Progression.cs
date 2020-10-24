using System;

namespace ProgressionLibrary
{
    public class Progression
    {
        private double a1;
        private double d;

       public double FirstElem
            {
            get
                {
                    return a1;
                }
                set
                {
                    a1 = value;
                }
            }
    public double Diff
    {
        get
        {
            return d;
        }
        set
        {
            d = value;
        }
    }
        public void Input()
        {
            double first = Convert.ToDouble(Console.ReadLine());
            double diff = Convert.ToDouble(Console.ReadLine());

            Diff = diff; 
            FirstElem = first;
        }
        public Progression(double first, double diff)
        {
            FirstElem = first;
            Diff = diff;
        }

        public Progression(Progression progr)
        {
            FirstElem = progr.FirstElem;
            Diff = progr.Diff;
        }
        public Progression() : this(0, 0)
        {
        }
        public static Progression operator *(Progression progr1, double d)
        {
            Progression progr = new Progression();
            progr.FirstElem = progr1.FirstElem * d;
            progr.Diff = progr1.Diff * d;
            return progr;
        }
        public static Progression operator +(Progression progr1, Progression progr2)
        {
            Progression progr = new Progression();
            progr.FirstElem = progr1.FirstElem + progr2.FirstElem;
            progr.Diff = progr1.Diff + progr2.Diff;
            return progr;
        }
        public static Progression operator -(Progression progr1, Progression progr2)
        {
            Progression progr = new Progression();
            progr.FirstElem = progr1.FirstElem - progr2.FirstElem;
            progr.Diff = progr1.Diff - progr2.Diff;
            return progr;
        }
        public override string ToString()
        {
            return "Начальный элемент " + FirstElem + " Коэффициент " + Diff;
        }
        public static bool operator ==(Progression progr1, Progression progr2)
        {
            if ((progr1.Diff == progr2.Diff) && (progr1.FirstElem == progr2.FirstElem))
                return true;
            return false;
        }

        public static bool operator !=(Progression progr1, Progression progr2)
        {
            if ((progr1.Diff != progr2.Diff) || (progr1.FirstElem != progr2.FirstElem))
                return true;
            return false;
        }
        public static bool operator true(Progression progr)//определение является ли прогрессия возрастающей
        {
            return progr.Diff > 0;
        }
        public static bool operator false(Progression progr)//определение является ли прогрессия убывающей
        {
            return progr.Diff < 0;
        }
        public double this[int n]
        {
            get { return FirstElem + (n-1)*Diff; }
        }
        public static explicit operator double(Progression progr)//явное приведение типов
        {
            return progr.FirstElem;
        }

        public static implicit operator Progression(double first)//неявное приведение типов
        {
            Progression progr = new Progression();
            progr.FirstElem = first;
            progr.Diff = 1;
            return progr;
        }
    }
}
