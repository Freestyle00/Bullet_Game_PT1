    namespace Bullet_Game_PT1.GumRuntimes
    {
        #region State Enums
        public enum PasswordBoxBehaviorPasswordBoxCategory
        {
            Enabled,
            Disabled,
            Highlighted,
            Selected
        }
        #endregion
        public interface IPasswordBoxBehavior
        {
            PasswordBoxBehaviorPasswordBoxCategory CurrentPasswordBoxBehaviorPasswordBoxCategoryState {set;}
        }
    }
