    namespace Bullet_Game_PT1.FormsControls.Screens
    {
        public partial class GameOverGumForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
            public GameOverGumForms () 
            {
                CustomInitialize();
            }
            public GameOverGumForms (Gum.Wireframe.GraphicalUiElement visual) 
            {
                Visual = visual;
                ReactToVisualChanged();
                CustomInitialize();
            }
            private void ReactToVisualChanged () 
            {
            }
            partial void CustomInitialize();
        }
    }
