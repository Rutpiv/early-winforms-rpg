using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Inimigo
    {
        /// <summary>
        /// A vida do inimigo
        /// </summary>

        public int health { get; set; }

        /// <summary>
        /// O nome do inimigo
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Verificar se o inimigo está morto
        /// </summary>
        public bool isDead { get; set; }
        /// <summary>
        /// Deermina o poder de ataque maximo que um inimigo pode ter
        /// </summary>
        public int poderDeAtaqueMaxInimigo { get; set; }
        public Inimigo(string name)
        {
            //Designa a vida do inimigo
            health = 100;

            //Designa o nome do inimigo
            Name = name;

            //Designa o poder de ataque maximo do inimigo
            poderDeAtaqueMaxInimigo = 10;
        }

        /// <summary>
        /// É chamado quando o inimigo sofre um ataque
        /// </summary>
        /// <param name> O nome que queremos dar a esse inimigo.</param>

        public void Acertado(int valorAcerto)
        {
            //subtrair o valor de acerto da vida do inimigo
            health = health - valorAcerto;

            //Escrever que o inimigo foi acertado
            Console.WriteLine(Name + " foi acertado e recebeu " + valorAcerto + " de dano! Agora ele possui " + health + " de vida restante.");

            //checa se o inimigo foi morto
            if (health < 1)
            {
                //Mata o inimigo
                Die();
            }
        }

        /// <summary>
        /// É chamado quando o inimigo supostamente morreu
        /// </summary>
        private void Die()
        {
            //Ajusta o booleano para identificar que o inimigo morreu
            isDead = true;
        }





    }
}
