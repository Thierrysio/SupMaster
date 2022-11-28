using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupMaster.Modeles
{
    public class Etablissement
    {
        #region attributs 
        private string _code;
        private string _adresse;
        private string _prospecteur;
        private List<Regional> _lesRegional;
        public static ObservableCollection<Etablissement> CollClasse = new ObservableCollection<Etablissement>();
        #endregion

        #region constructeurs
        public Etablissement(string code, string adresse, string prospecteur)
        {
            _code = code;
            _adresse = adresse;
            _prospecteur = prospecteur;
            _lesRegional = new List<Regional>();
            CollClasse.Add(this);
        }
        #endregion

        #region Getters-Setters
        public string GetCode()
        {
            return _code;
        }
        public string GetAdresse()
        {
            return _adresse;
        }
        public string GetProspecteur()
        {
            return _prospecteur;
        }
        public List<Regional> GetLesRegional()
        {
            return _lesRegional;
        }
        public void SetAdresse(string param)
        {
            _adresse = param;
        }
        public void SetProspecteur(string param)
        {
            _prospecteur = param;
        }
        public void SetLesRegional(List<Regional> param)
        {
            _lesRegional = param;
        }
        #endregion
        #region Methodes

        public List<Visite> GetLesVisitesDesOrganisationsDesRegions() 
        {
            List<Visite> resultat = new List<Visite>();
                foreach (Regional uneRegion in this.GetLesRegional())
                {
                    foreach (Visite uneVisite in uneRegion.GetListeOrganisationsVisites())
                    {
                        resultat.Add(uneVisite);
                    }
                }
                return resultat;
        }

        public List<Visite> GetLesVisitesDesOrganisationsDesRegionsV2()
        {
           List<Visite> resultat = new List<Visite>();

            foreach (Regional uneRegion in this.GetLesRegional())
            {
                foreach (Organisation uneOrganisation in uneRegion.GetListeOrganisations())
                {
                    foreach (Visite uneVisite in uneOrganisation.GetLesVisite())
                    {
                        resultat.Add(uneVisite);
                    }
                }
            }
            return resultat;
        }
        #endregion
    }
}
