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
        
        protected FlatRedBall.TileGraphics.LayeredTileMap Map;
        protected FlatRedBall.TileCollisions.TileShapeCollection SolidCollision;
        private Bullet_Game_PT1.Entities.You YouInstance;
        private FlatRedBall.Math.PositionedObjectList<Bullet_Game_PT1.Entities.Not_You> Not_YouList;
        private FlatRedBall.Math.Collision.PositionedObjectVsListRelationship<Bullet_Game_PT1.Entities.You, Entities.Not_You> YouInstanceVsNot_YouList;
        public event System.Action<Bullet_Game_PT1.Entities.You, Entities.Not_You> YouInstanceVsNot_YouListCollisionOccurred;
        public GameScreen () 
        	: base ("GameScreen")
        {
            // Not instantiating for FlatRedBall.TileGraphics.LayeredTileMap Map in Screens\GameScreen (Screen) because properties on the object prevent it
            // Not instantiating for FlatRedBall.TileCollisions.TileShapeCollection SolidCollision in Screens\GameScreen (Screen) because properties on the object prevent it
            Not_YouList = new FlatRedBall.Math.PositionedObjectList<Bullet_Game_PT1.Entities.Not_You>();
            Not_YouList.Name = "Not_YouList";
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            // Not instantiating for FlatRedBall.TileGraphics.LayeredTileMap Map in Screens\GameScreen (Screen) because properties on the object prevent it
            // Not instantiating for FlatRedBall.TileCollisions.TileShapeCollection SolidCollision in Screens\GameScreen (Screen) because properties on the object prevent it
            YouInstance = new Bullet_Game_PT1.Entities.You(ContentManagerName, false);
            YouInstance.Name = "YouInstance";
            Not_YouList.Clear();
                YouInstanceVsNot_YouList = FlatRedBall.Math.Collision.CollisionManager.Self.CreateRelationship(YouInstance, Not_YouList);
    YouInstanceVsNot_YouList.Name = "YouInstanceVsNot_YouList";

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
            Factories.Not_YouFactory.AddList(Not_YouList);
            YouInstance.AddToManagers(mLayer);
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
            
            Not_YouList.MakeOneWay();
            if (YouInstance != null)
            {
                YouInstance.Destroy();
                YouInstance.Detach();
            }
            for (int i = Not_YouList.Count - 1; i > -1; i--)
            {
                Not_YouList[i].Destroy();
            }
            Not_YouList.MakeTwoWay();
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
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
                YouInstance.AssignCustomVariables(true);
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
            return null;
        }
        public static object GetFile (string memberName) 
        {
            return null;
        }
        object GetMember (string memberName) 
        {
            return null;
        }
    }
}
