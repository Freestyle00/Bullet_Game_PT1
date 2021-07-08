    using System.Linq;
    namespace Bullet_Game_PT1.GumRuntimes
    {
        public partial class GameScreenGumRuntime : Gum.Wireframe.GraphicalUiElement
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
                            Health.Parent = this.GetGraphicalUiElementByName("Healtbar second thing");
                            TextInstance1.CurrentVariableState = Bullet_Game_PT1.GumRuntimes.TextRuntime.VariableState.Default;
                            Timer.FontScale = 2f;
                            Timer.Height = 20f;
                            Timer.Text = "60";
                            Timer.Width = 39f;
                            Timer.X = 755f;
                            Timer.Y = -3f;
                            TextInstance1.FontScale = 2f;
                            TextInstance1.MaxLettersToShow = 1000;
                            TextInstance1.Text = "Time left:";
                            TextInstance1.Width = 159f;
                            TextInstance1.X = 603f;
                            TextInstance1.Y = -3f;
                            Healtbar_second_thing.Height = 17f;
                            Healtbar_second_thing.Text = "/20";
                            Healtbar_second_thing.Width = 44f;
                            Healtbar_second_thing.X = 183f;
                            Healtbar_second_thing.Y = 576f;
                            Health.Height = 19f;
                            Health.Text = "20";
                            Health.Width = 19f;
                            Health.X = -21f;
                            Health.Y = 0f;
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
                bool setHealtbar_second_thingHeightFirstValue = false;
                bool setHealtbar_second_thingHeightSecondValue = false;
                float Healtbar_second_thingHeightFirstValue= 0;
                float Healtbar_second_thingHeightSecondValue= 0;
                bool setHealtbar_second_thingWidthFirstValue = false;
                bool setHealtbar_second_thingWidthSecondValue = false;
                float Healtbar_second_thingWidthFirstValue= 0;
                float Healtbar_second_thingWidthSecondValue= 0;
                bool setHealtbar_second_thingXFirstValue = false;
                bool setHealtbar_second_thingXSecondValue = false;
                float Healtbar_second_thingXFirstValue= 0;
                float Healtbar_second_thingXSecondValue= 0;
                bool setHealtbar_second_thingYFirstValue = false;
                bool setHealtbar_second_thingYSecondValue = false;
                float Healtbar_second_thingYFirstValue= 0;
                float Healtbar_second_thingYSecondValue= 0;
                bool setHealthHeightFirstValue = false;
                bool setHealthHeightSecondValue = false;
                float HealthHeightFirstValue= 0;
                float HealthHeightSecondValue= 0;
                bool setHealthWidthFirstValue = false;
                bool setHealthWidthSecondValue = false;
                float HealthWidthFirstValue= 0;
                float HealthWidthSecondValue= 0;
                bool setHealthXFirstValue = false;
                bool setHealthXSecondValue = false;
                float HealthXFirstValue= 0;
                float HealthXSecondValue= 0;
                bool setHealthYFirstValue = false;
                bool setHealthYSecondValue = false;
                float HealthYFirstValue= 0;
                float HealthYSecondValue= 0;
                bool setTextInstance1FontScaleFirstValue = false;
                bool setTextInstance1FontScaleSecondValue = false;
                float TextInstance1FontScaleFirstValue= 0;
                float TextInstance1FontScaleSecondValue= 0;
                bool setTextInstance1CurrentVariableStateFirstValue = false;
                bool setTextInstance1CurrentVariableStateSecondValue = false;
                Bullet_Game_PT1.GumRuntimes.TextRuntime.VariableState TextInstance1CurrentVariableStateFirstValue= Bullet_Game_PT1.GumRuntimes.TextRuntime.VariableState.Default;
                Bullet_Game_PT1.GumRuntimes.TextRuntime.VariableState TextInstance1CurrentVariableStateSecondValue= Bullet_Game_PT1.GumRuntimes.TextRuntime.VariableState.Default;
                bool setTextInstance1WidthFirstValue = false;
                bool setTextInstance1WidthSecondValue = false;
                float TextInstance1WidthFirstValue= 0;
                float TextInstance1WidthSecondValue= 0;
                bool setTextInstance1XFirstValue = false;
                bool setTextInstance1XSecondValue = false;
                float TextInstance1XFirstValue= 0;
                float TextInstance1XSecondValue= 0;
                bool setTextInstance1YFirstValue = false;
                bool setTextInstance1YSecondValue = false;
                float TextInstance1YFirstValue= 0;
                float TextInstance1YSecondValue= 0;
                bool setTimerFontScaleFirstValue = false;
                bool setTimerFontScaleSecondValue = false;
                float TimerFontScaleFirstValue= 0;
                float TimerFontScaleSecondValue= 0;
                bool setTimerHeightFirstValue = false;
                bool setTimerHeightSecondValue = false;
                float TimerHeightFirstValue= 0;
                float TimerHeightSecondValue= 0;
                bool setTimerWidthFirstValue = false;
                bool setTimerWidthSecondValue = false;
                float TimerWidthFirstValue= 0;
                float TimerWidthSecondValue= 0;
                bool setTimerXFirstValue = false;
                bool setTimerXSecondValue = false;
                float TimerXFirstValue= 0;
                float TimerXSecondValue= 0;
                bool setTimerYFirstValue = false;
                bool setTimerYSecondValue = false;
                float TimerYFirstValue= 0;
                float TimerYSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setHealtbar_second_thingHeightFirstValue = true;
                        Healtbar_second_thingHeightFirstValue = 17f;
                        if (interpolationValue < 1)
                        {
                            this.Healtbar_second_thing.Text = "/20";
                        }
                        setHealtbar_second_thingWidthFirstValue = true;
                        Healtbar_second_thingWidthFirstValue = 44f;
                        setHealtbar_second_thingXFirstValue = true;
                        Healtbar_second_thingXFirstValue = 183f;
                        setHealtbar_second_thingYFirstValue = true;
                        Healtbar_second_thingYFirstValue = 576f;
                        setHealthHeightFirstValue = true;
                        HealthHeightFirstValue = 19f;
                        if (interpolationValue < 1)
                        {
                            this.Health.Parent = this.GetGraphicalUiElementByName("Healtbar second thing");
                        }
                        if (interpolationValue < 1)
                        {
                            this.Health.Text = "20";
                        }
                        setHealthWidthFirstValue = true;
                        HealthWidthFirstValue = 19f;
                        setHealthXFirstValue = true;
                        HealthXFirstValue = -21f;
                        setHealthYFirstValue = true;
                        HealthYFirstValue = 0f;
                        setTextInstance1FontScaleFirstValue = true;
                        TextInstance1FontScaleFirstValue = 2f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.MaxLettersToShow = 1000;
                        }
                        setTextInstance1CurrentVariableStateFirstValue = true;
                        TextInstance1CurrentVariableStateFirstValue = Bullet_Game_PT1.GumRuntimes.TextRuntime.VariableState.Default;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.Text = "Time left:";
                        }
                        setTextInstance1WidthFirstValue = true;
                        TextInstance1WidthFirstValue = 159f;
                        setTextInstance1XFirstValue = true;
                        TextInstance1XFirstValue = 603f;
                        setTextInstance1YFirstValue = true;
                        TextInstance1YFirstValue = -3f;
                        setTimerFontScaleFirstValue = true;
                        TimerFontScaleFirstValue = 2f;
                        setTimerHeightFirstValue = true;
                        TimerHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.Timer.Text = "60";
                        }
                        setTimerWidthFirstValue = true;
                        TimerWidthFirstValue = 39f;
                        setTimerXFirstValue = true;
                        TimerXFirstValue = 755f;
                        setTimerYFirstValue = true;
                        TimerYFirstValue = -3f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setHealtbar_second_thingHeightSecondValue = true;
                        Healtbar_second_thingHeightSecondValue = 17f;
                        if (interpolationValue >= 1)
                        {
                            this.Healtbar_second_thing.Text = "/20";
                        }
                        setHealtbar_second_thingWidthSecondValue = true;
                        Healtbar_second_thingWidthSecondValue = 44f;
                        setHealtbar_second_thingXSecondValue = true;
                        Healtbar_second_thingXSecondValue = 183f;
                        setHealtbar_second_thingYSecondValue = true;
                        Healtbar_second_thingYSecondValue = 576f;
                        setHealthHeightSecondValue = true;
                        HealthHeightSecondValue = 19f;
                        if (interpolationValue >= 1)
                        {
                            this.Health.Parent = this.GetGraphicalUiElementByName("Healtbar second thing");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Health.Text = "20";
                        }
                        setHealthWidthSecondValue = true;
                        HealthWidthSecondValue = 19f;
                        setHealthXSecondValue = true;
                        HealthXSecondValue = -21f;
                        setHealthYSecondValue = true;
                        HealthYSecondValue = 0f;
                        setTextInstance1FontScaleSecondValue = true;
                        TextInstance1FontScaleSecondValue = 2f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.MaxLettersToShow = 1000;
                        }
                        setTextInstance1CurrentVariableStateSecondValue = true;
                        TextInstance1CurrentVariableStateSecondValue = Bullet_Game_PT1.GumRuntimes.TextRuntime.VariableState.Default;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.Text = "Time left:";
                        }
                        setTextInstance1WidthSecondValue = true;
                        TextInstance1WidthSecondValue = 159f;
                        setTextInstance1XSecondValue = true;
                        TextInstance1XSecondValue = 603f;
                        setTextInstance1YSecondValue = true;
                        TextInstance1YSecondValue = -3f;
                        setTimerFontScaleSecondValue = true;
                        TimerFontScaleSecondValue = 2f;
                        setTimerHeightSecondValue = true;
                        TimerHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.Timer.Text = "60";
                        }
                        setTimerWidthSecondValue = true;
                        TimerWidthSecondValue = 39f;
                        setTimerXSecondValue = true;
                        TimerXSecondValue = 755f;
                        setTimerYSecondValue = true;
                        TimerYSecondValue = -3f;
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setHealtbar_second_thingHeightFirstValue && setHealtbar_second_thingHeightSecondValue)
                {
                    Healtbar_second_thing.Height = Healtbar_second_thingHeightFirstValue * (1 - interpolationValue) + Healtbar_second_thingHeightSecondValue * interpolationValue;
                }
                if (setHealtbar_second_thingWidthFirstValue && setHealtbar_second_thingWidthSecondValue)
                {
                    Healtbar_second_thing.Width = Healtbar_second_thingWidthFirstValue * (1 - interpolationValue) + Healtbar_second_thingWidthSecondValue * interpolationValue;
                }
                if (setHealtbar_second_thingXFirstValue && setHealtbar_second_thingXSecondValue)
                {
                    Healtbar_second_thing.X = Healtbar_second_thingXFirstValue * (1 - interpolationValue) + Healtbar_second_thingXSecondValue * interpolationValue;
                }
                if (setHealtbar_second_thingYFirstValue && setHealtbar_second_thingYSecondValue)
                {
                    Healtbar_second_thing.Y = Healtbar_second_thingYFirstValue * (1 - interpolationValue) + Healtbar_second_thingYSecondValue * interpolationValue;
                }
                if (setHealthHeightFirstValue && setHealthHeightSecondValue)
                {
                    Health.Height = HealthHeightFirstValue * (1 - interpolationValue) + HealthHeightSecondValue * interpolationValue;
                }
                if (setHealthWidthFirstValue && setHealthWidthSecondValue)
                {
                    Health.Width = HealthWidthFirstValue * (1 - interpolationValue) + HealthWidthSecondValue * interpolationValue;
                }
                if (setHealthXFirstValue && setHealthXSecondValue)
                {
                    Health.X = HealthXFirstValue * (1 - interpolationValue) + HealthXSecondValue * interpolationValue;
                }
                if (setHealthYFirstValue && setHealthYSecondValue)
                {
                    Health.Y = HealthYFirstValue * (1 - interpolationValue) + HealthYSecondValue * interpolationValue;
                }
                if (setTextInstance1FontScaleFirstValue && setTextInstance1FontScaleSecondValue)
                {
                    TextInstance1.FontScale = TextInstance1FontScaleFirstValue * (1 - interpolationValue) + TextInstance1FontScaleSecondValue * interpolationValue;
                }
                if (setTextInstance1CurrentVariableStateFirstValue && setTextInstance1CurrentVariableStateSecondValue)
                {
                    TextInstance1.InterpolateBetween(TextInstance1CurrentVariableStateFirstValue, TextInstance1CurrentVariableStateSecondValue, interpolationValue);
                }
                if (setTextInstance1WidthFirstValue && setTextInstance1WidthSecondValue)
                {
                    TextInstance1.Width = TextInstance1WidthFirstValue * (1 - interpolationValue) + TextInstance1WidthSecondValue * interpolationValue;
                }
                if (setTextInstance1XFirstValue && setTextInstance1XSecondValue)
                {
                    TextInstance1.X = TextInstance1XFirstValue * (1 - interpolationValue) + TextInstance1XSecondValue * interpolationValue;
                }
                if (setTextInstance1YFirstValue && setTextInstance1YSecondValue)
                {
                    TextInstance1.Y = TextInstance1YFirstValue * (1 - interpolationValue) + TextInstance1YSecondValue * interpolationValue;
                }
                if (setTimerFontScaleFirstValue && setTimerFontScaleSecondValue)
                {
                    Timer.FontScale = TimerFontScaleFirstValue * (1 - interpolationValue) + TimerFontScaleSecondValue * interpolationValue;
                }
                if (setTimerHeightFirstValue && setTimerHeightSecondValue)
                {
                    Timer.Height = TimerHeightFirstValue * (1 - interpolationValue) + TimerHeightSecondValue * interpolationValue;
                }
                if (setTimerWidthFirstValue && setTimerWidthSecondValue)
                {
                    Timer.Width = TimerWidthFirstValue * (1 - interpolationValue) + TimerWidthSecondValue * interpolationValue;
                }
                if (setTimerXFirstValue && setTimerXSecondValue)
                {
                    Timer.X = TimerXFirstValue * (1 - interpolationValue) + TimerXSecondValue * interpolationValue;
                }
                if (setTimerYFirstValue && setTimerYSecondValue)
                {
                    Timer.Y = TimerYFirstValue * (1 - interpolationValue) + TimerYSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Bullet_Game_PT1.GumRuntimes.GameScreenGumRuntime.VariableState fromState,Bullet_Game_PT1.GumRuntimes.GameScreenGumRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                HealthBarInstance.StopAnimations();
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
                            Name = "Timer.Font Scale",
                            Type = "float",
                            Value = Timer.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Timer.Height",
                            Type = "float",
                            Value = Timer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Timer.Text",
                            Type = "string",
                            Value = Timer.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Timer.Width",
                            Type = "float",
                            Value = Timer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Timer.X",
                            Type = "float",
                            Value = Timer.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Timer.Y",
                            Type = "float",
                            Value = Timer.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Font Scale",
                            Type = "float",
                            Value = TextInstance1.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.MaxLettersToShow",
                            Type = "int?",
                            Value = TextInstance1.MaxLettersToShow
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.State",
                            Type = "State",
                            Value = TextInstance1.CurrentVariableState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Text",
                            Type = "string",
                            Value = TextInstance1.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Width",
                            Type = "float",
                            Value = TextInstance1.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.X",
                            Type = "float",
                            Value = TextInstance1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Y",
                            Type = "float",
                            Value = TextInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Healtbar second thing.Height",
                            Type = "float",
                            Value = Healtbar_second_thing.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Healtbar second thing.Text",
                            Type = "string",
                            Value = Healtbar_second_thing.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Healtbar second thing.Width",
                            Type = "float",
                            Value = Healtbar_second_thing.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Healtbar second thing.X",
                            Type = "float",
                            Value = Healtbar_second_thing.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Healtbar second thing.Y",
                            Type = "float",
                            Value = Healtbar_second_thing.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Health.Height",
                            Type = "float",
                            Value = Health.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Health.Parent",
                            Type = "string",
                            Value = Health.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Health.Text",
                            Type = "string",
                            Value = Health.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Health.Width",
                            Type = "float",
                            Value = Health.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Health.X",
                            Type = "float",
                            Value = Health.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Health.Y",
                            Type = "float",
                            Value = Health.Y
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
                            Name = "Timer.Font Scale",
                            Type = "float",
                            Value = Timer.FontScale + 2f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Timer.Height",
                            Type = "float",
                            Value = Timer.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Timer.Text",
                            Type = "string",
                            Value = Timer.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Timer.Width",
                            Type = "float",
                            Value = Timer.Width + 39f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Timer.X",
                            Type = "float",
                            Value = Timer.X + 755f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Timer.Y",
                            Type = "float",
                            Value = Timer.Y + -3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Font Scale",
                            Type = "float",
                            Value = TextInstance1.FontScale + 2f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.MaxLettersToShow",
                            Type = "int?",
                            Value = TextInstance1.MaxLettersToShow
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.State",
                            Type = "State",
                            Value = TextInstance1.CurrentVariableState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Text",
                            Type = "string",
                            Value = TextInstance1.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Width",
                            Type = "float",
                            Value = TextInstance1.Width + 159f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.X",
                            Type = "float",
                            Value = TextInstance1.X + 603f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Y",
                            Type = "float",
                            Value = TextInstance1.Y + -3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Healtbar second thing.Height",
                            Type = "float",
                            Value = Healtbar_second_thing.Height + 17f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Healtbar second thing.Text",
                            Type = "string",
                            Value = Healtbar_second_thing.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Healtbar second thing.Width",
                            Type = "float",
                            Value = Healtbar_second_thing.Width + 44f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Healtbar second thing.X",
                            Type = "float",
                            Value = Healtbar_second_thing.X + 183f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Healtbar second thing.Y",
                            Type = "float",
                            Value = Healtbar_second_thing.Y + 576f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Health.Height",
                            Type = "float",
                            Value = Health.Height + 19f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Health.Parent",
                            Type = "string",
                            Value = Health.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Health.Text",
                            Type = "string",
                            Value = Health.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Health.Width",
                            Type = "float",
                            Value = Health.Width + 19f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Health.X",
                            Type = "float",
                            Value = Health.X + -21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Health.Y",
                            Type = "float",
                            Value = Health.Y + 0f
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
            public Bullet_Game_PT1.GumRuntimes.TextRuntime Timer { get; set; }
            public Bullet_Game_PT1.GumRuntimes.TextRuntime TextInstance1 { get; set; }
            public Bullet_Game_PT1.GumRuntimes.TextRuntime Healtbar_second_thing { get; set; }
            public Bullet_Game_PT1.GumRuntimes.TextRuntime Health { get; set; }
            public Bullet_Game_PT1.GumRuntimes.HealthBarRuntime HealthBarInstance { get; set; }
            public GameScreenGumRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "GameScreenGum");
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
                Timer = this.GetGraphicalUiElementByName("Timer") as Bullet_Game_PT1.GumRuntimes.TextRuntime;
                TextInstance1 = this.GetGraphicalUiElementByName("TextInstance1") as Bullet_Game_PT1.GumRuntimes.TextRuntime;
                Healtbar_second_thing = this.GetGraphicalUiElementByName("Healtbar second thing") as Bullet_Game_PT1.GumRuntimes.TextRuntime;
                Health = this.GetGraphicalUiElementByName("Health") as Bullet_Game_PT1.GumRuntimes.TextRuntime;
                HealthBarInstance = this.GetGraphicalUiElementByName("HealthBarInstance") as Bullet_Game_PT1.GumRuntimes.HealthBarRuntime;
                if (tryCreateFormsObject)
                {
                    FormsControlAsObject = new Bullet_Game_PT1.FormsControls.Screens.GameScreenGumForms(this);
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
            public Bullet_Game_PT1.FormsControls.Screens.GameScreenGumForms FormsControl {get => (Bullet_Game_PT1.FormsControls.Screens.GameScreenGumForms) FormsControlAsObject;}
        }
    }
