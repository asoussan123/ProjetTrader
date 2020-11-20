using MySql.Data.MySqlClient;
using System;
using MetierTrader;
using System.Collections.Generic;

namespace GestionnaireBDD
{
    public class GstBdd
    {
        private MySqlConnection cnx;
        private MySqlCommand cmd;
        private MySqlDataReader dr;

        // Constructeur
        public GstBdd()
        {
            string chaine = "Server=localhost;Database=bourse;Uid=root;Pwd=";
            cnx = new MySqlConnection(chaine);
            cnx.Open();
        }

        public List<Trader> getAllTraders()
        {
            List<Trader> mesTraders = new List<Trader>();
            cmd = new MySqlCommand("select idTrader, nomTrader from trader", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Trader unSecteur = new Trader(Convert.ToInt16(dr[0].ToString()), dr[1].ToString());
                mesTraders.Add(unSecteur);
            }
            dr.Close();
            return mesTraders;
            
        }
        public List<ActionPerso> getAllActionsByTrader(int numTrader)
        {
            List<ActionPerso> mesActions = new List<ActionPerso>();
            cmd = new MySqlCommand("select numAction, prixAchat, quantite from acheter where numTrader = " + numTrader, cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ActionPerso monAction = new ActionPerso(Convert.ToInt16(dr[0].ToString()), dr[1].ToString());
                mesActions.Add(monAction);
            }
            dr.Close();
            return mesActions;
        }

        public List<MetierTrader.Action> getAllActionsNonPossedees(int numTrader)
        {
            List<MetierTrader.Action> lesActions = new List<MetierTrader.Action>();
            cmd = new MySqlCommand("select idAction, nomAction, coursReel from action", cnx);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                MetierTrader.Action uneAction = new MetierTrader.Action(Convert.ToInt16(dr[0].ToString()), dr[1].ToString());
                lesActions.Add(uneAction);
            }
            dr.Close();
            return lesActions;
        }

        //DELETE FROM `acheter` WHERE `acheter`.`numAction` = 6 AND `acheter`.`numTrader` = 5 »
        public void SupprimerActionAcheter(int numAction, int numTrader)
        {
            cmd = new MySqlCommand("delete from 'acheter' where 'acheter'.'numAction' = "+ numAction +" and 'acheter'.'numTrader' = "+ numTrader, cnx);
    

        }

        public void UpdateQuantite(int numAction, int numTrader, int quantite)
        {

            
        }

        public double getCoursReel(int numAction)
        {

            cmd = new MySqlCommand("select coursReel from action", cnx);
            return 0;
        }
        public void AcheterAction(int numAction, int numTrader, double prix, int quantite)
        {

        }
        public double getTotalPortefeuille(int numTrader)
        {
            return 0;
        }
    }
}
