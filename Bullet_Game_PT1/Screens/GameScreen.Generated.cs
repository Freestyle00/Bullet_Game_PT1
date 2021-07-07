#if ANDROID || IOS || DESKTOP_GL
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
using Color = Microsoft.Xna.Framework.Color;
using System.Linq;
using FlatRedBall;
using System;
using System.Collections.Generic;
using System.Text;
namespace Bullet_Game_PT1.Screens
{
    public partial class GameScreen : FlatRedBall.Screens.Screen
    {
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        protected static Microsoft.Xna.Framework.Audio.SoundEffect FD44116Bit;
        
        protected FlatRedBall.TileGraphics.LayeredTileMap Map;
        protected FlatRedBall.TileCollisions.TileShapeCollection SolidCollision;
        private Bullet_Game_PT1.Entities.You YouInstance;
        private FlatRedBall.Math.PositionedObjectList<Bullet_Game_PT1.Entities.Not_You> Not_YouList;
        private FlatRedBall.Math.Collision.PositionedObjectVsListRelationship<Bullet_Game_PT1.Entities.You, Entities.Not_You> YouInstanceVsNot_YouList;
        private FlatRedBall.Math.PositionedObjectList<Bullet_Game_PT1.Entities.UpperLowerBorder> UpperLowerBorderList;
        private Bullet_Game_PT1.Entities.UpperLowerBorder UpperLowerBorder1;
        private Bullet_Game_PT1.Entities.UpperLowerBorder UpperLowerBorder2;
        private FlatRedBall.Math.PositionedObjectList<Bullet_Game_PT1.Entities.LeftRightBorder> LeftRightBorderList;
        private Bullet_Game_PT1.Entities.LeftRightBorder LeftRightBorder1;
        private Bullet_Game_PT1.Entities.LeftRightBorder LeftRightBorder2;
        private FlatRedBall.Math.Collision.PositionedObjectVsListRelationship<Bullet_Game_PT1.Entities.You, Entities.UpperLowerBorder> YouInstanceVsUpperLowerBorderList;
        private FlatRedBall.Math.Collision.PositionedObjectVsListRelationship<Bullet_Game_PT1.Entities.You, Entities.LeftRightBorder> YouInstanceVsLeftRightBorderList;
        public event System.Action<Bullet_Game_PT1.Entities.You, Entities.Not_You> YouInstanceVsNot_YouListCollisionOccurred;
        public GameScreen () 
        	: base ("GameScreen")
        {
            // Not instantiating for FlatRedBall.TileGraphics.LayeredTileMap Map in Screens\GameScreen (Screen) because properties on the object prevent it
            // Not instantiating for FlatRedBall.TileCollisions.TileShapeCollection SolidCollision in Screens\GameScreen (Screen) because properties on the object prevent it
            Not_YouList = new FlatRedBall.Math.PositionedObjectList<Bullet_Game_PT1.Entities.Not_You>();
            Not_YouList.Name = "Not_YouList";
            UpperLowerBorderList = new FlatRedBall.Math.PositionedObjectList<Bullet_Game_PT1.Entities.UpperLowerBorder>();
            UpperLowerBorderList.Name = "UpperLowerBorderList";
            LeftRightBorderList = new FlatRedBall.Math.PositionedObjectList<Bullet_Game_PT1.Entities.LeftRightBorder>();
            LeftRightBorderList.Name = "LeftRightBorderList";
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            // Not instantiating for FlatRedBall.TileGraphics.LayeredTileMap Map in Screens\GameScreen (Screen) because properties on the object prevent it
            // Not instantiating for FlatRedBall.TileCollisions.TileShapeCollection SolidCollision in Screens\GameScreen (Screen) because properties on the object prevent it
            YouInstance = new Bullet_Game_PT1.Entities.You(ContentManagerName, false);
            YouInstance.Name = "YouInstance";
            Not_YouList.Clear();
            UpperLowerBorderList.Clear();
            UpperLowerBorder1 = new Bullet_Game_PT1.Entities.UpperLowerBorder(ContentManagerName, false);
            UpperLowerBorder1.Name = "UpperLowerBorder1";
            UpperLowerBorder2 = new Bullet_Game_PT1.Entities.UpperLowerBorder(ContentManagerName, false);
            UpperLowerBorder2.Name = "UpperLowerBorder2";
            LeftRightBorderList.Clear();
            LeftRightBorder1 = new Bullet_Game_PT1.Entities.LeftRightBorder(ContentManagerName, false);
            LeftRightBorder1.Name = "LeftRightBorder1";
            LeftRightBorder2 = new Bullet_Game_PT1.Entities.LeftRightBorder(ContentManagerName, false);
            LeftRightBorder2.Name = "LeftRightBorder2";
                YouInstanceVsNot_YouList = FlatRedBall.Math.Collision.CollisionManager.Self.CreateRelationship(YouInstance, Not_YouList);
    YouInstanceVsNot_YouList.Name = "YouInstanceVsNot_YouList";

                YouInstanceVsUpperLowerBorderList = FlatRedBall.Math.Collision.CollisionManager.Self.CreateRelationship(YouInstance, UpperLowerBorderList);
    YouInstanceVsUpperLowerBorderList.Name = "YouInstanceVsUpperLowerBorderList";
    YouInstanceVsUpperLowerBorderList.SetMoveCollision(0f, 1f);

                YouInstanceVsLeftRightBorderList = FlatRedBall.Math.Collision.CollisionManager.Self.CreateRelationship(YouInstance, LeftRightBorderList);
    YouInstanceVsLeftRightBorderList.Name = "YouInstanceVsLeftRightBorderList";
    YouInstanceVsLeftRightBorderList.SetMoveCollision(0f, 1f);

            // normally we wait to set variables until after the object is created, but in this case if the
            // TileShapeCollection doesn't have its Visible set before creating the tiles, it can result in
            // really bad performance issues, as shapes will be made visible, then invisible. Really bad perf!
            if (SolidCollision != null)
            {
                SolidCollision.Visible = false;
            }
            FlatRedBall.TileCollisions.TileShapeCollectionLayeredTileMapExtensions.AddCollisionFromTilesWithType(SolidCollision, Map, "SolidCollision", false);
            
            
            PostInitialize();
            base.Initialize(addToManagers);
            if (addToManagers)
            {
                AddToManagers();
            }
        }
        public override void AddToManagers () 
        {
            Factories.Not_YouFactory.Initialize(ContentManagerName);
            Factories.UpperLowerBorderFactory.Initialize(ContentManagerName);
            Factories.LeftRightBorderFactory.Initialize(ContentManagerName);
            Factories.Not_YouFactory.AddList(Not_YouList);
            Factories.UpperLowerBorderFactory.AddList(UpperLowerBorderList);
            Factories.LeftRightBorderFactory.AddList(LeftRightBorderList);
            YouInstance.AddToManagers(mLayer);
            UpperLowerBorder1.AddToManagers(mLayer);
            UpperLowerBorder2.AddToManagers(mLayer);
            LeftRightBorder1.AddToManagers(mLayer);
            LeftRightBorder2.AddToManagers(mLayer);
            FlatRedBall.TileEntities.TileEntityInstantiator.CreateEntitiesFrom(Map);
            base.AddToManagers();
            AddToManagersBottomUp();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
                YouInstance.Activity();
                for (int i = Not_YouList.Count - 1; i > -1; i--)
                {
                    if (i < Not_YouList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        Not_YouList[i].Activity();
                    }
                }
                for (int i = UpperLowerBorderList.Count - 1; i > -1; i--)
                {
                    if (i < UpperLowerBorderList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        UpperLowerBorderList[i].Activity();
                    }
                }
                for (int i = LeftRightBorderList.Count - 1; i > -1; i--)
                {
                    if (i < LeftRightBorderList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        LeftRightBorderList[i].Activity();
                    }
                }
            }
            else
            {
            }
            base.Activity(firstTimeCalled);
            if (!IsActivityFinished)
            {
                CustomActivity(firstTimeCalled);
            }
        }
        public override void Destroy () 
        {
            base.Destroy();
            Factories.Not_YouFactory.Destroy();
            Factories.UpperLowerBorderFactory.Destroy();
            Factories.LeftRightBorderFactory.Destroy();
            FD44116Bit = null;
            
            Not_YouList.MakeOneWay();
            UpperLowerBorderList.MakeOneWay();
            LeftRightBorderList.MakeOneWay();
            if (YouInstance != null)
            {
                YouInstance.Destroy();
                YouInstance.Detach();
            }
            for (int i = Not_YouList.Count - 1; i > -1; i--)
            {
                Not_YouList[i].Destroy();
            }
            for (int i = UpperLowerBorderList.Count - 1; i > -1; i--)
            {
                UpperLowerBorderList[i].Destroy();
            }
            for (int i = LeftRightBorderList.Count - 1; i > -1; i--)
            {
                LeftRightBorderList[i].Destroy();
            }
            Not_YouList.MakeTwoWay();
            UpperLowerBorderList.MakeTwoWay();
            LeftRightBorderList.MakeTwoWay();
            FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Clear();
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            YouInstanceVsNot_YouList.CollisionOccurred += OnYouInstanceVsNot_YouListCollisionOccurred;
            YouInstanceVsNot_YouList.CollisionOccurred += OnYouInstanceVsNot_YouListCollisionOccurredTunnel;
            if (Map!= null)
            {
            }
            if (SolidCollision!= null)
            {
            }
            if (YouInstance.Parent == null)
            {
                YouInstance.X = 0f;
            }
            else
            {
                YouInstance.RelativeX = 0f;
            }
            if (YouInstance.Parent == null)
            {
                YouInstance.Y = 0f;
            }
            else
            {
                YouInstance.RelativeY = 0f;
            }
            UpperLowerBorderList.Add(UpperLowerBorder1);
            if (UpperLowerBorder1.Parent == null)
            {
                UpperLowerBorder1.Y = 305f;
            }
            else
            {
                UpperLowerBorder1.RelativeY = 305f;
            }
            UpperLowerBorderList.Add(UpperLowerBorder2);
            if (UpperLowerBorder2.Parent == null)
            {
                UpperLowerBorder2.Y = -305f;
            }
            else
            {
                UpperLowerBorder2.RelativeY = -305f;
            }
            LeftRightBorderList.Add(LeftRightBorder1);
            if (LeftRightBorder1.Parent == null)
            {
                LeftRightBorder1.X = 405f;
            }
            else
            {
                LeftRightBorder1.RelativeX = 405f;
            }
            LeftRightBorderList.Add(LeftRightBorder2);
            if (LeftRightBorder2.Parent == null)
            {
                LeftRightBorder2.X = -405f;
            }
            else
            {
                LeftRightBorder2.RelativeX = -405f;
            }
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp () 
        {
            CameraSetup.ResetCamera(SpriteManager.Camera);
            AssignCustomVariables(false);
        }
        public virtual void RemoveFromManagers () 
        {
            YouInstance.RemoveFromManagers();
            for (int i = Not_YouList.Count - 1; i > -1; i--)
            {
                Not_YouList[i].Destroy();
            }
            for (int i = UpperLowerBorderList.Count - 1; i > -1; i--)
            {
                UpperLowerBorderList[i].Destroy();
            }
            for (int i = LeftRightBorderList.Count - 1; i > -1; i--)
            {
                LeftRightBorderList[i].Destroy();
            }
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
                YouInstance.AssignCustomVariables(true);
                UpperLowerBorder1.AssignCustomVariables(true);
                UpperLowerBorder2.AssignCustomVariables(true);
                LeftRightBorder1.AssignCustomVariables(true);
                LeftRightBorder2.AssignCustomVariables(true);
            }
            if (Map != null)
            {
            }
            if (SolidCollision != null)
            {
            }
            if (YouInstance.Parent == null)
            {
                YouInstance.X = 0f;
            }
            else
            {
                YouInstance.RelativeX = 0f;
            }
            if (YouInstance.Parent == null)
            {
                YouInstance.Y = 0f;
            }
            else
            {
                YouInstance.RelativeY = 0f;
            }
            if (UpperLowerBorder1.Parent == null)
            {
                UpperLowerBorder1.Y = 305f;
            }
            else
            {
                UpperLowerBorder1.RelativeY = 305f;
            }
            if (UpperLowerBorder2.Parent == null)
            {
                UpperLowerBorder2.Y = -305f;
            }
            else
            {
                UpperLowerBorder2.RelativeY = -305f;
            }
            if (LeftRightBorder1.Parent == null)
            {
                LeftRightBorder1.X = 405f;
            }
            else
            {
                LeftRightBorder1.RelativeX = 405f;
            }
            if (LeftRightBorder2.Parent == null)
            {
                LeftRightBorder2.X = -405f;
            }
            else
            {
                LeftRightBorder2.RelativeX = -405f;
            }
        }
        public virtual void ConvertToManuallyUpdated () 
        {
            if (Map != null)
            {
            }
            if (SolidCollision != null)
            {
            }
            YouInstance.ConvertToManuallyUpdated();
            for (int i = 0; i < Not_YouList.Count; i++)
            {
                Not_YouList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < UpperLowerBorderList.Count; i++)
            {
                UpperLowerBorderList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < LeftRightBorderList.Count; i++)
            {
                LeftRightBorderList[i].ConvertToManuallyUpdated();
            }
        }
        public static void LoadStaticContent (string contentManagerName) 
        {
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
            #if DEBUG
            if (contentManagerName == FlatRedBall.FlatRedBallServices.GlobalContentManager)
            {
                HasBeenLoadedWithGlobalContentManager = true;
            }
            else if (HasBeenLoadedWithGlobalContentManager)
            {
                throw new System.Exception("This type has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
            }
            #endif
            FD44116Bit = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/gamescreen/fd44116bit", contentManagerName);
            Bullet_Game_PT1.Entities.You.LoadStaticContent(contentManagerName);
            CustomLoadStaticContent(contentManagerName);
        }
        public override void PauseThisScreen () 
        {
            StateInterpolationPlugin.TweenerManager.Self.Pause();
            base.PauseThisScreen();
        }
        public override void UnpauseThisScreen () 
        {
            StateInterpolationPlugin.TweenerManager.Self.Unpause();
            base.UnpauseThisScreen();
        }
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "FD44116Bit":
                    return FD44116Bit;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "FD44116Bit":
                    return FD44116Bit;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "FD44116Bit":
                    return FD44116Bit;
            }
            return null;
        }
    }
}
