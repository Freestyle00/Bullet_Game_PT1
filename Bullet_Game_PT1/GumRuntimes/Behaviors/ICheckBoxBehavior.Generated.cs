    namespace Bullet_Game_PT1.GumRuntimes
    {
        #region State Enums
        public enum CheckBoxBehaviorCheckBoxCategory
        {
            EnabledOn,
            EnabledOff,
            DisabledOn,
            DisabledOff,
            HighlightedOn,
            HighlightedOff,
            PushedOn,
            PushedOff
        }
        #endregion
        public interface ICheckBoxBehavior
        {
            CheckBoxBehaviorCheckBoxCategory CurrentCheckBoxBehaviorCheckBoxCategoryState {set;}
        }
    }
