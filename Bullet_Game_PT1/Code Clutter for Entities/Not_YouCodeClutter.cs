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

using Microsoft.Xna.Framework;

namespace Bullet_Game_PT1.Entities
{
	public partial class Not_You
	{
		public string BehaviorOfMe; //This one is that we can always know what behavior has that bullet this will be usefull for the IR function and also if i will add distinctive bullets because i think that bullets who look the same but have different evil functions should be distinctive

		private float TimeTillSelfDestruct = 10; //
		public void BehaviorHandler(string Behavior)
		{
			/// <summary>
			/// When the entity is spawned in there will be an Behavior passed in.
			/// This Behavior will welll be the behvaior of the enemies
			/// These behavior will be maybe i will add more in the course of time
			/// 1. Dumb the bullet will only be flying in one direction and this will be forward
			/// Will always be uesd
			/// 2. DumbAimed The bullet will the shot at the player current position but it wont change its direction later
			/// Best to use moderately at the start and then havier the longer the game goes on
			/// 3. IR if the bullet is in proximity of the player (this will be determined by another hitbox of the player) the bullet will adjust its course to try to hit the player.
			/// The third one will be a surprise atack
			/// 4. Blank The bullet will spawn and will be immediately dispawned this is to limit the frequnezy of which the bullet spawns and to spice the game a bit up.
			/// </summary>

			BehaviorOfMe = Behavior;

			if (Behavior == "Dumb") //Bullet spawned and just flying stupidly
			{
				if (this.Y < 0)
				{
					this.YVelocity = PassOnClass.EnemySpeed;
				}
				else
				{
					this.YVelocity = -PassOnClass.EnemySpeed;
				}
			}
			else if (Behavior == "Dumb Aimed" || Behavior == "IR") //Dumb but with some more lines atached to it to aim and also IR so that it aims at the start but with more accuracy later
			{
				double DifferenceToShootX = PassOnClass.YouX - this.X; //In here we do some prep work for the math that we can figure out the angle to shoot the bullet.
				double DifferenceToShootY = PassOnClass.YouY - this.Y; //This is still prep
				float  ShootAngle         = (float)Math.Atan2(DifferenceToShootY, DifferenceToShootX); //uh i got these from an older project on what to do (during the writing of that i had this math subject but now I'm pulling blanks) so please dont ask what does it do
				this.Velocity = Vector3ExtensionMethods.FromAngle(ShootAngle).AtLength(PassOnClass.EnemySpeed); //in here were inputting the angle we got thru magic and giving it the speed it needs
			}
			else if (Behavior == "Blank")
			{
				this.Destroy();
			}
			else if (Behavior == "")
			{
				throw new Exception("Behavior should not be an empty string");
			}
		}
		private void IR()
		{
			///<summary>
			/// /vchelaru proposed that is should test the the bullet is in range of the player and then that i throws it self into the player
			/// this is what that function will do
			///</summary>

			//PassOnClass.YouX Well i just need these two that i have it on screen  
			//PassOnClass.YouY so dont worry about them they have no significance to you

			float Distance = Vector3.Distance(new Vector3(this.X, this.Y, 0), new Vector3(PassOnClass.YouX, PassOnClass.YouY, 0)); //dont ask it was hard to come up with this
			
			if (Math.Round(Distance) == 50)
			{
				this.Velocity = new Vector3(0, 0, 0);
				double DifferenceToShootX = PassOnClass.YouX - this.X; //In here we do some prep work for the math that we can figure out the angle to shoot the bullet.
				double DifferenceToShootY = PassOnClass.YouY - this.Y; //This is still prep
				float ShootAngle = (float)Math.Atan2(DifferenceToShootY, DifferenceToShootX); //uh i got these from an older project on what to do (during the writing of that i had this math subject but now I'm pulling blanks) so please dont ask what does it do
				this.Velocity = Vector3ExtensionMethods.FromAngle(ShootAngle).AtLength(PassOnClass.EnemySpeed * 2); //in here were inputting the angle we got thru magic and giving it ROCKET THRUSTED BOOST ok 450 is to surprise the player but also that it stays a bit fair
			}
		}
		private void BulletSelfDestruct()
		{
			///<summary>
			///As the bullets cannot stay on screen forever or else perfomance will look really bad trust me
			///The bullet should destroy themselves after 10 seconds
			///this is what this function does it checks if the 10 seconds are over and destroys the entity
			///</summary>
			TimeTillSelfDestruct -= TimeManager.SecondDifference;
			if (TimeTillSelfDestruct <= 0)
			{
				this.Destroy();
			}
		}
	}
}
#pragma warning restore IDE0051
#pragma warning restore IDE0052
#pragma warning restore IDE0079