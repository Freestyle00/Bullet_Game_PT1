    namespace Bullet_Game_PT1.GumRuntimes
    {
        #region State Enums
        public enum ListBoxItemBehaviorListBoxItemCategory
        {
            Enabled,
            Highlighted,
            Selected
        }
        #endregion
        public interface IListBoxItemBehavior
        {
            ListBoxItemBehaviorListBoxItemCategory CurrentListBoxItemBehaviorListBoxItemCategoryState {set;}
        }
    }
