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

namespace Bullet_Game_PT1.Screens
{
	public partial class GameScreen
	{
#pragma warning disable IDE0052 // Ungelesene private Member entfernen
		float TimeL = 60;
#pragma warning restore IDE0052 // Ungelesene private Member entfernen
		void Seconds60Timer()
		{
			///<summary>
			/// The game will be 60 seconds long 
			/// so to not have thousands and thousands of timers who will get asynchron,
			/// there will only be one it will count down form 60 to 0.
			/// Then it will do whatever i say it should do when it is 0.
			/// The time of it will be passed on Globally to be used in across the entire game.
			/// This will help me to do timed events like bullet patterns or bullets who are shooted timed.
			/// This time will also be displayed by the GUI.
			///</summary>
			
			TimeL = -TimeManager.SecondDifference; //this is it the line i created 6 lines of explanations
			PassOnClass.Time = TimeL;
		}
	}
}
