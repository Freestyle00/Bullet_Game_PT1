    namespace Bullet_Game_PT1.GumRuntimes
    {
        #region State Enums
        public enum ComboBoxBehaviorComboBoxCategory
        {
            Enabled,
            Disabled,
            Highlighted,
            Pushed
        }
        #endregion
        public interface IComboBoxBehavior
        {
            ComboBoxBehaviorComboBoxCategory CurrentComboBoxBehaviorComboBoxCategoryState {set;}
        }
    }
