using System;
using System.Collections.Generic;
using System.Text;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Math.Geometry;
using Microsoft.Xna.Framework.Input;

namespace Bullet_Game_PT1.Entities
{
    public partial class You
    {
        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>

        public int CurrentHP { get; set; }
        
        private void CustomInitialize()
        {
            //CustomInitializeTopDownInput();
            CurrentHP = MaxHP; //To make playing around with HP easier it will be like that also cheating will be harder yeah get away with your cheat engine
        }
        private void CustomActivity()
        {
           PassOnClass.YouX = this.X; //Both of these lines are needed
           PassOnClass.YouY = this.Y; //That his location will be shared and for the enemie to be used
           
        }
        private void CustomDestroy()
        {


        }
        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }
        public void Hit() //The reason this is in here is that i dont want to create an entire file just for one function so that will stay her
        {
            CurrentHP -= 1;
			if (CurrentHP <= 0)
			{
                this.Destroy();
			}
        }
    }
}
