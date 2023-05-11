using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Nave
{
    
    internal class Nave
    {
        string _nome;
        double _stazza;
        int _velocità;
        bool _varata;
        stato _stato;

        public Nave(string nome, double stazza, int velocità, bool varata, stato stato)
        {
            _nome = nome;
            _stazza = stazza;
            _velocità = velocità;
            _varata = varata;
            _stato = stato;
        }

        public Nave(string nome) : this(nome, 0, 0, false, stato.Affondata)
        {

        }
        public Nave(string nome, int velocità) : this(nome, 0, velocità, false, stato.Navigazione)
        {

        }
        public Nave(string nome, double stazza, int velocità) : this(nome, stazza, velocità, false, stato.Antiere)
        {

        }
        
        public Nave():this("", 0, 0, false, stato.Venduta)
        {

        }
        public void SetNome(string nome)
        {
            _nome = nome;
        }
        public string GetNome()
        {
            return _nome;
        }

        public void SetStazza(double stazza)
        {
            _stazza = stazza;
        }
        public double GetStazza()
        {
            return _stazza;
        }

        public void SetVelocità(int velocità)
        {
            _velocità = velocità;
        }
        public int GetVelocità()
        {
            return _velocità;
        }

        public void SetVarata(bool varata)
        {
            _varata = varata;
        }
        public bool GetVarata()
        {
            return _varata;
        }

        public void SetStato(stato stato)
        {
            _stato = stato;
        }

        public stato GetStato()
        {
            return _stato;
        }

        public void StampaAVideo()
        {
            Console.WriteLine(_nome);
        }
    }

}