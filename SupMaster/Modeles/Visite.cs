using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupMaster.Modeles
{
    public class Visite
    {
        #region attributs 
        private string _dateVisite;
        private string _prospecteur;
        public static ObservableCollection<Visite> CollClasse = new ObservableCollection<Visite>();
        #endregion

        #region constructeurs
        public Visite(string dateVisite, string prospecteur)
        {
            _dateVisite = dateVisite;
            _prospecteur = prospecteur;
            CollClasse.Add(this);
        }
        #endregion

        #region Getters-Setters
        public string GetDateVisite()
        {
            return _dateVisite;
        }
        public string GetProspecteur()
        {
            return _prospecteur;
        }
        public void SetProspecteur(string param)
        {
            _prospecteur = param;
        }
        #endregion
        #region Methodes
        #endregion
    }
}
