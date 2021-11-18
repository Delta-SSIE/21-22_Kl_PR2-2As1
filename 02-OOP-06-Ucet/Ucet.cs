using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_06_Ucet
{
    class Ucet
    {
        private double _zustatek;
        public double Zustatek
        {
            get
            {
                return _zustatek;
            }
        }

        private List<string> _log;
        public Ucet()
        {
            _zustatek = 0;
            _log = new List<string>();
            _log.Add(DateTime.Now.ToString() + "Účet založen");
        }
        public void Uloz(double vklad)
        {
            if (vklad < 0)
                throw new ArgumentOutOfRangeException("Nelze uložit Zápornou částku.");

            _log.Add($"Uloženo {vklad} Kč");
            _zustatek += vklad;
        }
        public bool Vyber(double castka)
        {
            if (castka > _zustatek) {
                _log.Add($"Neúspěšný pokus o výběr {castka} Kč");

                return false;
            }

            _log.Add($"Vybráno {castka} Kč");
            _zustatek -= castka;
            return true;
        }
        public override string ToString()
        {
            return $"Účet se zůstatkem {_zustatek} Kč";
        }
        public void Urokuj(double urokovaMira)
        {
            _zustatek *= 1 + urokovaMira / 100;
        }

        public string GetTransactionLog()
        {
            return string.Join(System.Environment.NewLine, _log);
        }

    }
}
