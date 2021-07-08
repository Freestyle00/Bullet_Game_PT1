    namespace Bullet_Game_PT1.GumRuntimes
    {
        #region State Enums
        public enum TextBoxBehaviorTextBoxCategory
        {
            Enabled,
            Disabled,
            Highlighted,
            Selected
        }
        public enum TextBoxBehaviorLineModeCategory
        {
            Single,
            Multi
        }
        #endregion
        public interface ITextBoxBehavior
        {
            TextBoxBehaviorTextBoxCategory CurrentTextBoxBehaviorTextBoxCategoryState {set;}
            TextBoxBehaviorLineModeCategory CurrentTextBoxBehaviorLineModeCategoryState {set;}
        }
    }
