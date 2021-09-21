using System;
using System.Collections.Generic;
namespace PA2
{
    public class Battle
    {
        public static void StartFight(Fighter userCharacter, Fighter computerCharacter)
        {
            //loops attack and defend sequence
            while(userCharacter.Health >=0 && computerCharacter.Health >=0)
            {
                if(GetAttackResult(userCharacter,computerCharacter)== "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if(GetAttackResult(computerCharacter,userCharacter)=="Game Over")
                {
                    if(computerCharacter.Health <=0)
                    {
                        Console.WriteLine("{0} has lost the fight\n",computerCharacter.Name);
                    }
                    Console.WriteLine("GameOver");
                    break;
                }
            }  
        }

        //accepts the two characters into the game so the fight sequence can begin 
        public static string GetAttackResult(Fighter fighter1, Fighter fighter2)
        {
            
            //calculate one fighters attack and the others block
            double fighter1Attk = fighter1.Attack();
            double fighter2Blk = fighter2.Block();
            double dmg2Fighter2 = 0;

            //subtract damage from block 
            if(fighter1.ToString()=="PA2.Ronald"&&fighter2.ToString()=="PA2.Hamburgler" )
            {
                dmg2Fighter2 = (fighter1Attk - fighter2Blk)*1.2;
            }
            else if(fighter1.ToString()=="PA2.Hamburgler"&&fighter2.ToString()=="PA2.FryKids")
            {
                 dmg2Fighter2 = (fighter1Attk - fighter2Blk)*1.2;
            }
            else if(fighter1.ToString()=="PA2.FryKids"&&fighter2.ToString()=="PA2.Ronald")
            {
                 dmg2Fighter2 = (fighter1Attk - fighter2Blk)*1.2;
            }
            else
            {
                 dmg2Fighter2 = fighter1Attk-fighter2Blk;
            }




            //subtract damage from fighters health if attack is over block amount 
            if(dmg2Fighter2 > 0)
            {
                fighter2.Health = fighter2.Health - dmg2Fighter2;
            }
            else
            {
                dmg2Fighter2 =0;
            }
            //print results 
            Console.WriteLine("{0} Attacked {1} for {2} Damage", fighter1.Name,fighter2.Name, dmg2Fighter2);
            Console.WriteLine("{0} has {1} Health \n",fighter2.Name,fighter2.Health);
            //checks for loss if health is below 0 
            if(fighter2.Health <=0)
            {
                
                Console.WriteLine("{0} has lost the fight\n",fighter2.Name);
                return "Game over";
                
            }
            else return "Fight On";
        } 
        //hello 


    }
}