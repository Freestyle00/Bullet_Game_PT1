    namespace Bullet_Game_PT1.FormsControls.Screens
    {
        public partial class SplashScreenGumForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
            public SplashScreenGumForms () 
            {
                CustomInitialize();
            }
            public SplashScreenGumForms (Gum.Wireframe.GraphicalUiElement visual) 
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
