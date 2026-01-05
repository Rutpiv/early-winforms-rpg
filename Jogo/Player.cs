using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    /// <summary>
    /// Essa Classe representa o personagem jogável
    /// </summary>
    public class Jogador
    {
        /// <summary>
        /// Determina os valores de vida do jogador
        /// </summary>
        public int Health { get; set; }
        /// <summary>
        /// Determina o nome do jogador
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Determina se o jogador está morto ou não
        /// </summary>
        public bool isDead { get; set; }
        /// <summary>
        /// Determina se o Jogador está defendendo ou não
        /// </summary>
        public bool Defendendo { get; set; }

        public Jogador()
        {
            //Determina o valor de vida
            Health = 100;
        }

        public int Atingido(int valor_acerto)
        {
            //checa se o jogador estava se defendendo
            if (Defendendo)
            {
                //Escreve que o jogador defendeu-se do ataque
                Console.WriteLine(Name + " se defendeu do ataque e evitou o dano!");

                //remove a defesa do jogador
                Defendendo = false;
            }
            else
            {
                //Subtrai o dano recebido da vida do jogador
                Health = Health - valor_acerto;

                //escreve que o jogador foi atingido
                Console.WriteLine(Name + " foi atingido e recebeu " + valor_acerto + " de dano! Agora você possui " + Health + " de vida restante.");
            }
            //checa para ver se o jogador está morto
            if (Health <= 0)
            {
                //O jogador está morto
                Die();
            }
            return Health;
        }

        public void Cura(int qntCura)
        {
            //Cura o jogador somando a quantidade a se curar na vida do jogador
            Health = (Health + qntCura > 100) ? 100 : (Health + qntCura);
        }


        private void Die()
        {
            //Escreve na textbox que o jogador está morto
            Console.WriteLine(Name + " morreu.");

            //Ajusta o boolean do isDead
            isDead = true;
        }

    }
}
