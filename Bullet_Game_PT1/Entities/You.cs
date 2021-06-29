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
        Input.KeyboardAndControllerInput Input = new Input.KeyboardAndControllerInput();

        private void CustomInitialize()
        {
            //InitializeTopDownInput(Input);

        }

        private void CustomActivity()
        {
            InputI();

        }

        private void CustomDestroy()
        {

         
        }

        void InputI()
        {
            /*if (InputManager.Keyboard.KeyDown(Keys.D) || InputManager.Keyboard.KeyDown(Keys.Right))
            {
                Input.HorinzontalValue(1);
            }
            else if (InputManager.Keyboard.KeyDown(Keys.A) || InputManager.Keyboard.KeyDown(Keys.Left))
            {
                Input.HorinzontalValue(-1);
            }
            else if (InputManager.Keyboard.KeyDown(Keys.W) || InputManager.Keyboard.KeyDown(Keys.Up))
            {
                Input.VerticalValue(1);
            }
            else if (InputManager.Keyboard.KeyDown(Keys.S) || InputManager.Keyboard.KeyDown(Keys.Down))
            {
                Input.VerticalValue(-1);
            }
            else
            {
                Input.HorinzontalValue(0);
                Input.VerticalValue(0);
            }
            InitializeTopDownInput(Input);*/
        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }
    }
}
