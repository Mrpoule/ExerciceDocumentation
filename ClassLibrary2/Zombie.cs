using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    /// <summary>
    /// Classe qui initialise un Zombie.
    /// <code>
    /// 
    /// Zombie monZombie= new Zombie(pv,niveau,vitesse);
    /// 
    /// monZombie.Sprint(vitesse,position);
    /// 
    /// </code>
    /// </summary>
    public class Zombie
    {
        int pv;
        int niveau;
        double vitesse;
        /// <summary>
        /// Constructeur qui initialise un Zombie de base
        /// </summary>
        /// <param name="pv"> la vie du Zombie</param>
        /// <param name="niveau"> le niveau du Zombie</param>
        /// <param name="vitesse"> la vitesse du Zombie</param>
        public Zombie(int pv, int niveau, double vitesse)
        {
            this.pv = pv;
            this.niveau = niveau;
            this.vitesse = vitesse;
        }
        /// <summary>
        /// Evenement qui se declenche quand le Zombie attaque.
        /// </summary>
        public event EventHandler<EventArgs> ZombieAttacked;
        /// <summary>
        /// Boolean qui permet de savoir si le Zombie est mort.
        /// </summary>
        /// <returns>(si vrai, le Zombie est mort)</returns>
        public bool Mort()
        {
            if (pv<=0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Fonction qui permet au Zombie de courrir
        /// </summary>
        /// <param name="vitesse">la vitesse du Zombie</param>
        /// <param name="position">La position à modifier</param>
        public void Sprint(double vitesse,double position)
        {
            position += vitesse;
        }
    }
}
