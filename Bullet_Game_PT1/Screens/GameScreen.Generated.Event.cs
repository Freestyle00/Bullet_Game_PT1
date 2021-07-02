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
        void OnYouInstanceVsNot_YouListCollisionOccurredTunnel (Bullet_Game_PT1.Entities.You first, Entities.Not_You second) 
        {
            if (this.YouInstanceVsNot_YouListCollisionOccurred != null)
            {
                YouInstanceVsNot_YouListCollisionOccurred(first, second);
            }
        }
    }
}
