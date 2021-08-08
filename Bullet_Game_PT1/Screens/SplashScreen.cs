using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
    public partial class SplashScreen
    {

        void CustomInitialize()
        {


        }

        void CustomActivity(bool firstTimeCalled)
        {
			if (InputManager.Keyboard.AnyKeyPushed())
			{
                MoveToScreen("GameScreen");
			}
        }


        void CustomDestroy()
        {


        }

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

    }
}
