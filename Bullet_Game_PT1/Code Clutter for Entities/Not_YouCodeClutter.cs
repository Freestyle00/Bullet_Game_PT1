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

namespace Bullet_Game_PT1.Entities
{
	public partial class Not_You
	{
		public string BehaviorOfMe;
		public void BehaviorHandler(string Behavior)
		{
			/// <summary>
			/// When the entity is spawned in there will be an Behavior passed in.
			/// This Behavior will welll be the behvaior of the enemies
			/// These behavior will be maybe i will add more in the course of time
			/// 
			/// 1. Dumb the bullet will only be flying in one direction and this will be forward
			/// Will always be uesd
			/// 2. DumbAimed The bullet will the shot at the player current position but it wont change its direction later
			/// Best to use moderately at the start and then havier the longer the game goes on
			/// 3. IR if the bullet is in proximity of the player (this will be determined by another hitbox of the player) the bullet will adjust its course to try to hit the player.
			/// The third one will be a surprise atack used in the last 30seconds of the game
			/// </summary>

			BehaviorOfMe = Behavior;

			if (Behavior == "Dumb-") //Bullet spawned on the lower side
			{
				
			}
			else if (Behavior == "Dumb+") //Bullet spawned on the upper side
			{

			}
			else if (Behavior == "DumbAimed") //Funnily this one is easier than Dumb
			{
				
			}
			else if (Behavior == "IR") //But that one is harder as this one will require more work
			{
				
			}
		}
	}
}
#pragma warning restore IDE0051
#pragma warning restore IDE0052
#pragma warning restore IDE0079