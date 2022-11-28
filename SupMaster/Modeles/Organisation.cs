using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupMaster.Modeles
{
    public class Organisation
    {
        #region attributs 
        private string _nom;
        private string _adresse;
        private List<Visite> _lesVisite;
        private Regional _laRegion;
        public static ObservableCollection<Organisation> CollClasse = new ObservableCollection<Organisation>();
        #endregion

        #region constructeurs
        public Organisation(string nom, string adresse, Regional laRegion)
        {
            _nom = nom;
            _adresse = adresse;
            _lesVisite = new List<Visite>();
            _laRegion = laRegion;
            CollClasse.Add(this);
        }
        #endregion

        #region Getters-Setters
        public string GetNom()
        {
            return _nom;
        }
        public string GetAdresse()
        {
            return _adresse;
        }
        public List<Visite> GetLesVisite()
        {
            return _lesVisite;
        }
        public Regional GetLaRegion()
        {
            return _laRegion;
        }
        public void SetAdresse(string param)
        {
            _adresse = param;
        }
        public void SetLesVisite(List<Visite> param)
        {
            _lesVisite = param;
        }
        public void SetLaRegion(Regional param)
        {
            _laRegion = param;
        }
        #endregion
        #region Methodes

        public Dictionary<string,int> GetNbVisitesParProspecteur()
        {
            Dictionary<string, int> resultat = new Dictionary<string, int>();
            foreach(Visite uneVisite in this.GetLesVisite())
            {
                if(!resultat.ContainsKey(uneVisite.GetProspecteur()))
                {
                    resultat.Add(uneVisite.GetProspecteur(), 1);
                }
                else
                {
                    resultat[uneVisite.GetProspecteur()] += 1;
                }
            }
            return resultat;
        }
        #endregion
    }
}
