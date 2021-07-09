    using System.Linq;
    namespace Bullet_Game_PT1.GumRuntimes
    {
        public partial class GameOverGumRuntime : Gum.Wireframe.GraphicalUiElement
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            #endregion
            #region State Properties
            public VariableState CurrentVariableState
            {
                get
                {
                    return mCurrentVariableState;
                }
                set
                {
                    mCurrentVariableState = value;
                    switch(mCurrentVariableState)
                    {
                        case  VariableState.Default:
                            MessageText.Height = 599f;
                            MessageText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            MessageText.Text = "Hello World";
                            MessageText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            MessageText.Width = 799f;
                            MessageText.X = 0f;
                            MessageText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            MessageText.Y = 0f;
                            break;
                    }
                }
            }
            #endregion
            #region State Interpolation
            public void InterpolateBetween (VariableState firstState, VariableState secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setMessageTextHeightFirstValue = false;
                bool setMessageTextHeightSecondValue = false;
                float MessageTextHeightFirstValue= 0;
                float MessageTextHeightSecondValue= 0;
                bool setMessageTextWidthFirstValue = false;
                bool setMessageTextWidthSecondValue = false;
                float MessageTextWidthFirstValue= 0;
                float MessageTextWidthSecondValue= 0;
                bool setMessageTextXFirstValue = false;
                bool setMessageTextXSecondValue = false;
                float MessageTextXFirstValue= 0;
                float MessageTextXSecondValue= 0;
                bool setMessageTextYFirstValue = false;
                bool setMessageTextYSecondValue = false;
                float MessageTextYFirstValue= 0;
                float MessageTextYSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setMessageTextHeightFirstValue = true;
                        MessageTextHeightFirstValue = 599f;
                        if (interpolationValue < 1)
                        {
                            this.MessageText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MessageText.Text = "Hello World";
                        }
                        if (interpolationValue < 1)
                        {
                            this.MessageText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setMessageTextWidthFirstValue = true;
                        MessageTextWidthFirstValue = 799f;
                        setMessageTextXFirstValue = true;
                        MessageTextXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.MessageText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        setMessageTextYFirstValue = true;
                        MessageTextYFirstValue = 0f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setMessageTextHeightSecondValue = true;
                        MessageTextHeightSecondValue = 599f;
                        if (interpolationValue >= 1)
                        {
                            this.MessageText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MessageText.Text = "Hello World";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MessageText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setMessageTextWidthSecondValue = true;
                        MessageTextWidthSecondValue = 799f;
                        setMessageTextXSecondValue = true;
                        MessageTextXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.MessageText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        setMessageTextYSecondValue = true;
                        MessageTextYSecondValue = 0f;
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setMessageTextHeightFirstValue && setMessageTextHeightSecondValue)
                {
                    MessageText.Height = MessageTextHeightFirstValue * (1 - interpolationValue) + MessageTextHeightSecondValue * interpolationValue;
                }
                if (setMessageTextWidthFirstValue && setMessageTextWidthSecondValue)
                {
                    MessageText.Width = MessageTextWidthFirstValue * (1 - interpolationValue) + MessageTextWidthSecondValue * interpolationValue;
                }
                if (setMessageTextXFirstValue && setMessageTextXSecondValue)
                {
                    MessageText.X = MessageTextXFirstValue * (1 - interpolationValue) + MessageTextXSecondValue * interpolationValue;
                }
                if (setMessageTextYFirstValue && setMessageTextYSecondValue)
                {
                    MessageText.Y = MessageTextYFirstValue * (1 - interpolationValue) + MessageTextYSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentVariableState = firstState;
                }
                else
                {
                    mCurrentVariableState = secondState;
                }
                if (!wasSuppressed)
                {
                    ResumeLayout(true);
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Bullet_Game_PT1.GumRuntimes.GameOverGumRuntime.VariableState fromState,Bullet_Game_PT1.GumRuntimes.GameOverGumRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
            {
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from:0, to:1, duration:(float)secondsToTake, type:interpolationType, easing:easing );
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(fromState, toState, newPosition);
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.States.First(item => item.Name == toState.ToString());
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
                tweener.Ended += ()=> this.CurrentVariableState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = AddToCurrentValuesWithState(toState);
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
                tweener.Ended += ()=> this.CurrentVariableState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            #endregion
            #region State Animations
            #endregion
            public override void StopAnimations () 
            {
                base.StopAnimations();
            }
            public override FlatRedBall.Gum.Animation.GumAnimation GetAnimation (string animationName) 
            {
                return base.GetAnimation(animationName);
            }
            #region Get Current Values on State
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (VariableState state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  VariableState.Default:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.Height",
                            Type = "float",
                            Value = MessageText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = MessageText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.Text",
                            Type = "string",
                            Value = MessageText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = MessageText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.Width",
                            Type = "float",
                            Value = MessageText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.X",
                            Type = "float",
                            Value = MessageText.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.X Origin",
                            Type = "HorizontalAlignment",
                            Value = MessageText.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.Y",
                            Type = "float",
                            Value = MessageText.Y
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (VariableState state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  VariableState.Default:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.Height",
                            Type = "float",
                            Value = MessageText.Height + 599f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = MessageText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.Text",
                            Type = "string",
                            Value = MessageText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = MessageText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.Width",
                            Type = "float",
                            Value = MessageText.Width + 799f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.X",
                            Type = "float",
                            Value = MessageText.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.X Origin",
                            Type = "HorizontalAlignment",
                            Value = MessageText.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageText.Y",
                            Type = "float",
                            Value = MessageText.Y + 0f
                        }
                        );
                        break;
                }
                return newState;
            }
            #endregion
            public override void ApplyState (Gum.DataTypes.Variables.StateSave state) 
            {
                bool matches = this.ElementSave.AllStates.Contains(state);
                if (matches)
                {
                    var category = this.ElementSave.Categories.FirstOrDefault(item => item.States.Contains(state));
                    if (category == null)
                    {
                        if (state.Name == "Default") this.mCurrentVariableState = VariableState.Default;
                    }
                }
                base.ApplyState(state);
            }
            private bool tryCreateFormsObject;
            public Bullet_Game_PT1.GumRuntimes.TextRuntime MessageText { get; set; }
            public GameOverGumRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "GameOverGum");
                    this.ElementSave = elementSave;
                    string oldDirectory = FlatRedBall.IO.FileManager.RelativeDirectory;
                    FlatRedBall.IO.FileManager.RelativeDirectory = FlatRedBall.IO.FileManager.GetDirectory(Gum.Managers.ObjectFinder.Self.GumProjectSave.FullFileName);
                    GumRuntime.ElementSaveExtensions.SetGraphicalUiElement(elementSave, this, RenderingLibrary.SystemManagers.Default);
                    FlatRedBall.IO.FileManager.RelativeDirectory = oldDirectory;
                }
            }
            public override void SetInitialState () 
            {
                base.SetInitialState();
                this.CurrentVariableState = VariableState.Default;
                CallCustomInitialize();
            }
            public override void CreateChildrenRecursively (Gum.DataTypes.ElementSave elementSave, RenderingLibrary.SystemManagers systemManagers) 
            {
                base.CreateChildrenRecursively(elementSave, systemManagers);
                this.AssignReferences();
            }
            private void AssignReferences () 
            {
                MessageText = this.GetGraphicalUiElementByName("MessageText") as Bullet_Game_PT1.GumRuntimes.TextRuntime;
                if (tryCreateFormsObject)
                {
                    FormsControlAsObject = new Bullet_Game_PT1.FormsControls.Screens.GameOverGumForms(this);
                }
            }
            public override void AddToManagers (RenderingLibrary.SystemManagers managers, RenderingLibrary.Graphics.Layer layer) 
            {
                base.AddToManagers(managers, layer);
            }
            private void CallCustomInitialize () 
            {
                CustomInitialize();
            }
            partial void CustomInitialize();
            public Bullet_Game_PT1.FormsControls.Screens.GameOverGumForms FormsControl {get => (Bullet_Game_PT1.FormsControls.Screens.GameOverGumForms) FormsControlAsObject;}
        }
    }
