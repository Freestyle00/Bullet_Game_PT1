using System;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Specialized;
using FlatRedBall.Audio;
using FlatRedBall.Screens;
using Bullet_Game_PT1.Entities;
using Bullet_Game_PT1.Screens;
namespace Bullet_Game_PT1.Screens
{
    public partial class GameScreen
    {
        void OnYouInstanceVsNot_YouListCollisionOccurred (Bullet_Game_PT1.Entities.You first, Entities.Not_You second) 
        {
            Console.WriteLine("Hit"); //That is the best I will do for now
            second.Destroy();
        }
    }
}
