using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    /// <summary>
    /// Representa o Chefão inimigo no jogo
    /// </summary>
    public class Boss : Inimigo
    {
        /// <summary>
        /// O construtor padrão
        /// </summary>
        public Boss() : base("Grande Vilão")
        {
            //Ajusta a vida para ser um valor maior
            health = 150;

            //Designa o poder de ataque maximo do inimigo
            poderDeAtaqueMaxInimigo = 25;
        }
    }
}
