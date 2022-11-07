using TowerDefense_TheRPG.code;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TowerDefense_TheRPG
{
    public class EnemyPool : Enemy
    {
        
        private int poolSize = 20; // max size of que unless broken then will be larger 
        public Queue<Enemy> pool = new Queue<Enemy>(); // the queue of enemys 
        private Random rand; // random

        //
        public EnemyPool(string name, int x, int y, int w, int h) : base(name, x, y, w, h)
        {
        }

        // generates a pool of poolSize and randomly selects ballons (all set to position 0,0)
        // (Do at start of each level) 
        public void Start()
        {
            rand = new Random();
            for (int i = 0; i < poolSize; i++)
            {
                //GenEnemyPos(out int x, out int y);
                int enemyType = rand.Next(4);
                Enemy balloon;
                switch (enemyType)
                {
                    case 0:
                        balloon = Enemy.MakeRedBalloon(0, 0);
                        break;
                    case 1:
                        balloon = Enemy.MakePurpleBalloon(0, 0);
                        break;
                    case 2:
                        balloon = Enemy.MakeGrayBalloon(0, 0);
                        break;
                    default:
                        balloon = Enemy.MakeOrangeBalloon(0, 0);
                        break;
                }
                //enemies.Add(balloon);
                // add to que
                pool.Enqueue(balloon);
            }
        }
        // return enemy after death 
        public void ReturnEnemy(Enemy balloon)
        {
            pool.Enqueue(balloon);
        }

        // get enemy if one exist else make new one - making new one extends queue size 
        public Enemy GetEnemy()
        {
            if (pool.Count > 0) // if there are any 
            {
                return pool.Dequeue(); // get next enemy
            }
            else
            {
                int enemyType = rand.Next(4);
                Enemy balloon;
                switch (enemyType)
                {
                    case 0:
                        balloon = Enemy.MakeRedBalloon(0, 0);
                        break;
                    case 1:
                        balloon = Enemy.MakePurpleBalloon(0, 0);
                        break;
                    case 2:
                        balloon = Enemy.MakeGrayBalloon(0, 0);
                        break;
                    default:
                        balloon = Enemy.MakeOrangeBalloon(0, 0);
                        break;
                }
                return balloon;
            }
        }

        // clear the queue (Do after level compleated)
        public void empty()
        {
            pool.Clear();
        }
    }
}
