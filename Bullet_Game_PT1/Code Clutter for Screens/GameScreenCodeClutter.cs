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

		float SpawnRate = .1f;

		float TimeLeftTillSpawn = .1f;
		private void Seconds60Timer()
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
			if (TimeManager.TimeFactor != .1f) //If youre in slow mo time doesnt run there is the penalty i wanted for slow mo
			{
				TimeL -= TimeManager.SecondDifference; //this is it the line I created 6 lines of explanations
			}
			PassOnClass.Time = TimeL;
		}
		private void BulletSpawn()
		{
			/// <summary>
			/// This here will take care of spawning the bullets.
			/// My plan is that bullets will be spawned at specific location and specific times.
			/// This one is also the reason why the Seconds60Timer is there so that everything will be synchron.
			/// Also one of the plan is that when the bullet will be spawned that i will pass parameters on what the bullet will do.
			/// Like a bullet will spawn with the "homing" parameter so the bullet will ligtly follow the player.
			/// And other parameters will follow later and will be explained in the NotYou class where it matters more.
			/// Ok change of plan I will do a frequenzy of which they will spawn and this frequnzy will increase towards time.
			/// the frequnzy will also randomly pick form a list which Behavior the bullets will get.
			/// And on which position they will spawn
			/// </summary>
			string[] Behaviors = new string[4] { "Dumb", "Dumb Aimed", "IR", "Blank" };
			int[] Height = new int[2] { 300, -300 };
			/// The following code will adjust the SpawnRate of the bullet according by how much the player survived and therefore making the game harder
			float ForSomeReasonItHasToBeSeperateOrElseItWontWork = (int)Math.Round(TimeL);
			float TimeValue = (60 - ForSomeReasonItHasToBeSeperateOrElseItWontWork) / 600; //Figure or else there will be lots of comments in here
			SpawnRate = .1f - TimeValue;
			/// END
			 TimeLeftTillSpawn -= TimeManager.SecondDifference;
			if (TimeLeftTillSpawn < 0)
			{
				string Behavior = "";
				///This code is for randomly choosing from the behavior list but with chances 35% for dumb 10% for dumb aimed and 5% for IR and 50% for Blank
				int Chance = FlatRedBallServices.Random.Between(0, 100);
				if (Chance >= 0 && Chance <= 35)
				{
					Behavior = Behaviors[0];
				}
				else if (Chance > 35 && Chance <= 45)
				{
					Behavior = Behaviors[1];
				}
				else if (Chance > 45 && Chance < 50)
				{
					Behavior = Behaviors[2];
				}
				else if (Chance >= 50)
				{
					Behavior = Behaviors[3];
				}
				///END
				Not_You Bullet = Factories.Not_YouFactory.CreateNew(FlatRedBallServices.Random.Between(-400, 400), FlatRedBallServices.Random.In(Height));
				Bullet.BehaviorHandler(Behavior);
				TimeLeftTillSpawn = SpawnRate;
			}
		}
		private void SlowMo()
		{
			/// <summary>
			/// This function wil be really straightforward (I HOPE) you hold down a button and time slows down thats it (PLEASE)
			/// </summary>
			if (InputManager.Keyboard.KeyPushed(Keys.LeftShift))
			{
				FD44116Bit.Play(); //
			}
			if (InputManager.Keyboard.KeyDown(Keys.LeftShift)) //Checks if the LEftshift key is being held down and if yes it slows time down
			{
				TimeManager.TimeFactor = .1f;	//interestingly when time is slowed down the spawnrate increases i should keep that in mind
			}
			else //If it isnt then it should be defaultet back to 1
			{
				TimeManager.TimeFactor = 1;
			}
		}
	}
}
#pragma warning restore IDE0051
#pragma warning restore IDE0052
#pragma warning restore IDE0079