using TowerDefense_TheRPG.code;

namespace TowerDefense_TheRPG
{
    public class EnemyPool
    {

        private const int poolSize = 20; // max size of que unless broken then will be larger 
        public Queue<Enemy> pool = new Queue<Enemy>(poolSize); // the queue of enemys 
        private Random rand; // random

        // Default constructor 
           // add weights to select 

        // generates a pool of poolSize and randomly selects ballons (all set to position 0,0)
        // (Do at start of each level) 
        public void Start(int level) // add weights 
        {
            int Weight = 0;
            switch (level)
            { // every 2 levels up dificulty 
                case 0:
                case 1:
                    Weight = 0;
                    break;
                case 2:
                case 3:
                    Weight = 1;
                    break;
                case 4:
                case 5:
                    Weight = 2;
                    break;
                default:
                    Weight = 4;
                    break;
            }


            rand = new Random();
            for (int i = 0; i < poolSize; i++)
            {
                //GenEnemyPos(out int x, out int y);
                int enemyType = rand.Next(Weight);
                Enemy balloon;
                switch (enemyType)
                {
                    case 0:
                        balloon = Enemy.MakeRedBalloon(-50, 0);
                        break;
                    case 1:
                        balloon = Enemy.MakePurpleBalloon(-50, 0);
                        break;
                    case 2:
                        balloon = Enemy.MakeGrayBalloon(-50, 0);
                        break;
                    default:
                        balloon = Enemy.MakeOrangeBalloon(-50, 0);
                        break;
                }
                //enemies.Add(balloon);
                // add to que
                balloon.Hide();// keep invisible 
                pool.Enqueue(balloon);
            }
        }
        // return enemy after death 
        public void ReturnEnemy(Enemy balloon)
        {
            if (balloon.Name == "redballoon") // heal the ball0on 
            {
                balloon.SetMaxHealth(0.1f);
            }
            else if(balloon.Name == "purpleballoon")
            {
                balloon.SetMaxHealth(0.5f);
            }
            else if (balloon.Name == "grayballoon")
            {
                balloon.SetMaxHealth(1.0f);
            }
            else if (balloon.Name == "orangeballoon")
            {
                balloon.SetMaxHealth(0.2f);
            }
            pool.Enqueue(balloon);
        }

        // get enemy if one exist else make new one - making new one extends queue size 
        public Enemy GetEnemy()
        {
            {
                if (pool.Count > 0) // if there are any 
                {
                    return pool.Dequeue(); // get next enemy
                }
                else
                {
                    return null;
                }
            }
        }

        // clear the queue (Do after level compleated)
        public void empty()
        {
            //pool.Clear();
            pool = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
