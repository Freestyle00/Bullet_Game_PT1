#pragma warning disable IDE0079 //SHUT THE FUCK UP
#pragma warning disable IDE0051 //SHUT THE FUCK UP
#pragma warning disable IDE0052 //SHUT THE FUCK UP
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Math.Geometry;
using FlatRedBall.Localization;
using Microsoft.Xna.Framework.Input;
using Bullet_Game_PT1.Entities;


namespace Bullet_Game_PT1.Screens
{
	public partial class GameScreen
	{

		float TimeL = 60;

		void Seconds60Timer()
		{
			/// <summary>
			/// The game will be 60 seconds long 
			/// so to not have thousands and thousands of timers who will get asynchron,
			/// there will only be one it will count down form 60 to 0.
			/// Then it will do whatever i say it should do when it is 0.
			/// The time of it will be passed on Globally to be used in across the entire game.
			/// This will help me to do timed events like bullet patterns or bullets who are shooted timed.
			/// This time will also be displayed by the GUI.
			/// </summary>
			
			TimeL = -TimeManager.SecondDifference; //this is it the line I created 6 lines of explanations
			PassOnClass.Time = TimeL;
		}
		void BulletSpawn()
		{
			/// <summary>
			/// This here will take care of spawning the bullets.
			/// My plan is that bullets will be spawned at specific location and specific times.
			/// This one is also the reason why the Seconds60Timer is there so that everything will be synchron.
			/// Also one of the plan is that when the bullet will be spawned that i will pass parameters on what the bullet will do.
			/// Like a bullet will spawn with the "homing" parameter so the bullet will ligtly follow the player.
			/// And other parameters will follow later and will be explained in the NotYou class where it matters more.
			/// </summary>

			var Bullet = Factories.Not_YouFactory.CreateNew();
			Bullet.BehaviorHandler("Dumb");
			

		}
	}
}
#pragma warning restore IDE0051
#pragma warning restore IDE0052
#pragma warning restore IDE0079