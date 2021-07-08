    namespace Bullet_Game_PT1.GumRuntimes
    {
        #region State Enums
        public enum ListBoxBehaviorListBoxCategory
        {
            Enabled,
            Disabled,
            Focused
        }
        #endregion
        public interface IListBoxBehavior
        {
            ListBoxBehaviorListBoxCategory CurrentListBoxBehaviorListBoxCategoryState {set;}
        }
    }
