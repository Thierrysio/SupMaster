using SupMaster.Modeles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupMaster.Modeles
{
    public class Regional
    {
        #region attributs 
        private int _numero;
        private string _nom;
        private List<Organisation> _lesOrganisations;
        private Etablissement _leEtablissement;
        public static ObservableCollection<Regional> CollClasse = new ObservableCollection<Regional>();
        #endregion

        #region constructeurs
        public Regional(int numero, string nom, Etablissement leEtablissement)
        {
            _numero = numero;
            _nom = nom;
            _lesOrganisations = new List<Organisation>();
            _leEtablissement = leEtablissement;
            CollClasse.Add(this);
        }
        #endregion

        #region Getters-Setters
        public int GetNumero()
        {
            return _numero;
        }
        public string GetNom()
        {
            return _nom;
        }
        public List<Organisation> GetLesOrganisations()
        {
            return _lesOrganisations;
        }
        public Etablissement GetLeEtablissement()
        {
            return _leEtablissement;
        }
        public void SetNom(string param)
        {
            _nom = param;
        }
        public void SetLesOrganisations(List<Organisation> param)
        {
            _lesOrganisations = param;
        }
        public void SetLeEtablissement(Etablissement param)
        {
            _leEtablissement = param;
        }
        #endregion
        #region Methodes
        public int GetNbOrganisations()
        {
            // Qui est le proprietaire de la methode ?
            // Quelle doit etre la signature ?
            // Avons nous un attribut nous permettant de communiquer avec Organisation ?
            return this.GetLesOrganisations().Count;
        }

        public List<Organisation> GetListeOrganisations()
        {
            List<Organisation> resultat = new List<Organisation>();
            foreach (Organisation uneOrganisation in this.GetListeOrganisations())
            {
                resultat.Add(uneOrganisation);
            }
            return resultat;
        }
        public List<Visite> GetListeOrganisationsVisites()
        {
            if(this.GetNbOrganisations()==0) return new List<Visite>();
            List<Visite> resultat = new List<Visite>();
            foreach( Organisation uneOrganisation in this.GetListeOrganisations())
            {
                foreach(Visite uneVisite in uneOrganisation.GetLesVisite())
                {
                    resultat.Add(uneVisite);
                }
            }
            return resultat;
        }
        #endregion
    }
}
