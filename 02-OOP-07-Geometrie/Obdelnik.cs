using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_07_Geometrie
{
    class Obdelnik
    {

        private double _stranaA;
        public double StranaA
        {
            get
            {
                return _stranaA;
            }
            private set
            {
                if (value >= 0)
                    _stranaA = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
        private double _stranaB;
        public double StranaB
        {
            get
            {
                return _stranaB;
            }
            set
            {
                if (value >= 0)
                    _stranaB = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
        public Obdelnik()
        { }//bez tohoto prázdného konstruktoru by nebylo možné vytvořit obdélník s ještě nedefinovanými stranami
        public Obdelnik(double stranaA, double stranaB)
        {
            StranaA = stranaA; //používáme vlastnost i zevnitř konstruktoru - zajistí kontrolu přípustnosti hodnoty
            StranaB = stranaB;
        }

        public double Obsah()
        {
            return _stranaA * _stranaB;
        }
        public double Obvod()
        {
            return 2 * (_stranaA + _stranaB);
        }
       
        public override string ToString()
        {
            return $"Obdélník [{_stranaA}, {_stranaB}]";
        }
    }
}
