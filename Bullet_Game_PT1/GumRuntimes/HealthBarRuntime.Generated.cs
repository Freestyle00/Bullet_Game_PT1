    using System.Linq;
    namespace Bullet_Game_PT1.GumRuntimes
    {
        public partial class HealthBarRuntime : Bullet_Game_PT1.GumRuntimes.ContainerRuntime
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
                            Height = 15f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            Width = 150f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            X = -317f;
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Y = 287f;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Background.Blue = 0;
                            Background.Green = 0;
                            Background.Height = 15f;
                            Background.Red = 255;
                            Background.Width = 150f;
                            Background.X = 0f;
                            Background.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            Background.Y = 0f;
                            Background.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            Foreground.Blue = 19;
                            Foreground.Green = 102;
                            Foreground.Height = 15f;
                            Foreground.Red = 74;
                            Foreground.Width = 100f;
                            Foreground.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Foreground.X = 0f;
                            Foreground.Y = 7.5f;
                            Foreground.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
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
                bool setBackgroundBlueFirstValue = false;
                bool setBackgroundBlueSecondValue = false;
                int BackgroundBlueFirstValue= 0;
                int BackgroundBlueSecondValue= 0;
                bool setBackgroundGreenFirstValue = false;
                bool setBackgroundGreenSecondValue = false;
                int BackgroundGreenFirstValue= 0;
                int BackgroundGreenSecondValue= 0;
                bool setBackgroundHeightFirstValue = false;
                bool setBackgroundHeightSecondValue = false;
                float BackgroundHeightFirstValue= 0;
                float BackgroundHeightSecondValue= 0;
                bool setBackgroundRedFirstValue = false;
                bool setBackgroundRedSecondValue = false;
                int BackgroundRedFirstValue= 0;
                int BackgroundRedSecondValue= 0;
                bool setBackgroundWidthFirstValue = false;
                bool setBackgroundWidthSecondValue = false;
                float BackgroundWidthFirstValue= 0;
                float BackgroundWidthSecondValue= 0;
                bool setBackgroundXFirstValue = false;
                bool setBackgroundXSecondValue = false;
                float BackgroundXFirstValue= 0;
                float BackgroundXSecondValue= 0;
                bool setBackgroundYFirstValue = false;
                bool setBackgroundYSecondValue = false;
                float BackgroundYFirstValue= 0;
                float BackgroundYSecondValue= 0;
                bool setForegroundBlueFirstValue = false;
                bool setForegroundBlueSecondValue = false;
                int ForegroundBlueFirstValue= 0;
                int ForegroundBlueSecondValue= 0;
                bool setForegroundGreenFirstValue = false;
                bool setForegroundGreenSecondValue = false;
                int ForegroundGreenFirstValue= 0;
                int ForegroundGreenSecondValue= 0;
                bool setForegroundHeightFirstValue = false;
                bool setForegroundHeightSecondValue = false;
                float ForegroundHeightFirstValue= 0;
                float ForegroundHeightSecondValue= 0;
                bool setForegroundRedFirstValue = false;
                bool setForegroundRedSecondValue = false;
                int ForegroundRedFirstValue= 0;
                int ForegroundRedSecondValue= 0;
                bool setForegroundWidthFirstValue = false;
                bool setForegroundWidthSecondValue = false;
                float ForegroundWidthFirstValue= 0;
                float ForegroundWidthSecondValue= 0;
                bool setForegroundXFirstValue = false;
                bool setForegroundXSecondValue = false;
                float ForegroundXFirstValue= 0;
                float ForegroundXSecondValue= 0;
                bool setForegroundYFirstValue = false;
                bool setForegroundYSecondValue = false;
                float ForegroundYFirstValue= 0;
                float ForegroundYSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                bool setXFirstValue = false;
                bool setXSecondValue = false;
                float XFirstValue= 0;
                float XSecondValue= 0;
                bool setYFirstValue = false;
                bool setYSecondValue = false;
                float YFirstValue= 0;
                float YSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setBackgroundBlueFirstValue = true;
                        BackgroundBlueFirstValue = 0;
                        setBackgroundGreenFirstValue = true;
                        BackgroundGreenFirstValue = 0;
                        setBackgroundHeightFirstValue = true;
                        BackgroundHeightFirstValue = 15f;
                        setBackgroundRedFirstValue = true;
                        BackgroundRedFirstValue = 255;
                        setBackgroundWidthFirstValue = true;
                        BackgroundWidthFirstValue = 150f;
                        setBackgroundXFirstValue = true;
                        BackgroundXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Background.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        setBackgroundYFirstValue = true;
                        BackgroundYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Background.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        setForegroundBlueFirstValue = true;
                        ForegroundBlueFirstValue = 19;
                        setForegroundGreenFirstValue = true;
                        ForegroundGreenFirstValue = 102;
                        setForegroundHeightFirstValue = true;
                        ForegroundHeightFirstValue = 15f;
                        setForegroundRedFirstValue = true;
                        ForegroundRedFirstValue = 74;
                        setForegroundWidthFirstValue = true;
                        ForegroundWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.Foreground.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setForegroundXFirstValue = true;
                        ForegroundXFirstValue = 0f;
                        setForegroundYFirstValue = true;
                        ForegroundYFirstValue = 7.5f;
                        if (interpolationValue < 1)
                        {
                            this.Foreground.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 15f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 150f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setXFirstValue = true;
                        XFirstValue = -317f;
                        if (interpolationValue < 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setYFirstValue = true;
                        YFirstValue = 287f;
                        if (interpolationValue < 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setBackgroundBlueSecondValue = true;
                        BackgroundBlueSecondValue = 0;
                        setBackgroundGreenSecondValue = true;
                        BackgroundGreenSecondValue = 0;
                        setBackgroundHeightSecondValue = true;
                        BackgroundHeightSecondValue = 15f;
                        setBackgroundRedSecondValue = true;
                        BackgroundRedSecondValue = 255;
                        setBackgroundWidthSecondValue = true;
                        BackgroundWidthSecondValue = 150f;
                        setBackgroundXSecondValue = true;
                        BackgroundXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Background.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        setBackgroundYSecondValue = true;
                        BackgroundYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Background.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        setForegroundBlueSecondValue = true;
                        ForegroundBlueSecondValue = 19;
                        setForegroundGreenSecondValue = true;
                        ForegroundGreenSecondValue = 102;
                        setForegroundHeightSecondValue = true;
                        ForegroundHeightSecondValue = 15f;
                        setForegroundRedSecondValue = true;
                        ForegroundRedSecondValue = 74;
                        setForegroundWidthSecondValue = true;
                        ForegroundWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.Foreground.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setForegroundXSecondValue = true;
                        ForegroundXSecondValue = 0f;
                        setForegroundYSecondValue = true;
                        ForegroundYSecondValue = 7.5f;
                        if (interpolationValue >= 1)
                        {
                            this.Foreground.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 15f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 150f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setXSecondValue = true;
                        XSecondValue = -317f;
                        if (interpolationValue >= 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setYSecondValue = true;
                        YSecondValue = 287f;
                        if (interpolationValue >= 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setBackgroundBlueFirstValue && setBackgroundBlueSecondValue)
                {
                    Background.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundBlueFirstValue* (1 - interpolationValue) + BackgroundBlueSecondValue * interpolationValue);
                }
                if (setBackgroundGreenFirstValue && setBackgroundGreenSecondValue)
                {
                    Background.Green = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundGreenFirstValue* (1 - interpolationValue) + BackgroundGreenSecondValue * interpolationValue);
                }
                if (setBackgroundHeightFirstValue && setBackgroundHeightSecondValue)
                {
                    Background.Height = BackgroundHeightFirstValue * (1 - interpolationValue) + BackgroundHeightSecondValue * interpolationValue;
                }
                if (setBackgroundRedFirstValue && setBackgroundRedSecondValue)
                {
                    Background.Red = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundRedFirstValue* (1 - interpolationValue) + BackgroundRedSecondValue * interpolationValue);
                }
                if (setBackgroundWidthFirstValue && setBackgroundWidthSecondValue)
                {
                    Background.Width = BackgroundWidthFirstValue * (1 - interpolationValue) + BackgroundWidthSecondValue * interpolationValue;
                }
                if (setBackgroundXFirstValue && setBackgroundXSecondValue)
                {
                    Background.X = BackgroundXFirstValue * (1 - interpolationValue) + BackgroundXSecondValue * interpolationValue;
                }
                if (setBackgroundYFirstValue && setBackgroundYSecondValue)
                {
                    Background.Y = BackgroundYFirstValue * (1 - interpolationValue) + BackgroundYSecondValue * interpolationValue;
                }
                if (setForegroundBlueFirstValue && setForegroundBlueSecondValue)
                {
                    Foreground.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ForegroundBlueFirstValue* (1 - interpolationValue) + ForegroundBlueSecondValue * interpolationValue);
                }
                if (setForegroundGreenFirstValue && setForegroundGreenSecondValue)
                {
                    Foreground.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ForegroundGreenFirstValue* (1 - interpolationValue) + ForegroundGreenSecondValue * interpolationValue);
                }
                if (setForegroundHeightFirstValue && setForegroundHeightSecondValue)
                {
                    Foreground.Height = ForegroundHeightFirstValue * (1 - interpolationValue) + ForegroundHeightSecondValue * interpolationValue;
                }
                if (setForegroundRedFirstValue && setForegroundRedSecondValue)
                {
                    Foreground.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ForegroundRedFirstValue* (1 - interpolationValue) + ForegroundRedSecondValue * interpolationValue);
                }
                if (setForegroundWidthFirstValue && setForegroundWidthSecondValue)
                {
                    Foreground.Width = ForegroundWidthFirstValue * (1 - interpolationValue) + ForegroundWidthSecondValue * interpolationValue;
                }
                if (setForegroundXFirstValue && setForegroundXSecondValue)
                {
                    Foreground.X = ForegroundXFirstValue * (1 - interpolationValue) + ForegroundXSecondValue * interpolationValue;
                }
                if (setForegroundYFirstValue && setForegroundYSecondValue)
                {
                    Foreground.Y = ForegroundYFirstValue * (1 - interpolationValue) + ForegroundYSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setWidthFirstValue && setWidthSecondValue)
                {
                    Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
                }
                if (setXFirstValue && setXSecondValue)
                {
                    X = XFirstValue * (1 - interpolationValue) + XSecondValue * interpolationValue;
                }
                if (setYFirstValue && setYSecondValue)
                {
                    Y = YFirstValue * (1 - interpolationValue) + YSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Bullet_Game_PT1.GumRuntimes.HealthBarRuntime.VariableState fromState,Bullet_Game_PT1.GumRuntimes.HealthBarRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                            Name = "Height",
                            Type = "float",
                            Value = Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height Units",
                            Type = "DimensionUnitType",
                            Value = HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width Units",
                            Type = "DimensionUnitType",
                            Value = WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X",
                            Type = "float",
                            Value = X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Origin",
                            Type = "HorizontalAlignment",
                            Value = XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Units",
                            Type = "PositionUnitType",
                            Value = XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y",
                            Type = "float",
                            Value = Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Units",
                            Type = "PositionUnitType",
                            Value = YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Background.Blue",
                            Type = "int",
                            Value = Background.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Background.Green",
                            Type = "int",
                            Value = Background.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Background.Height",
                            Type = "float",
                            Value = Background.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Background.Red",
                            Type = "int",
                            Value = Background.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Background.Width",
                            Type = "float",
                            Value = Background.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Background.X",
                            Type = "float",
                            Value = Background.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Background.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Background.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Background.Y",
                            Type = "float",
                            Value = Background.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Background.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Background.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Foreground.Blue",
                            Type = "int",
                            Value = Foreground.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Foreground.Green",
                            Type = "int",
                            Value = Foreground.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Foreground.Height",
                            Type = "float",
                            Value = Foreground.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Foreground.Red",
                            Type = "int",
                            Value = Foreground.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Foreground.Width",
                            Type = "float",
                            Value = Foreground.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Foreground.Width Units",
                            Type = "DimensionUnitType",
                            Value = Foreground.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Foreground.X",
                            Type = "float",
                            Value = Foreground.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Foreground.Y",
                            Type = "float",
                            Value = Foreground.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Foreground.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Foreground.YOrigin
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
                            Name = "Height",
                            Type = "float",
                            Value = Height + 15f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height Units",
                            Type = "DimensionUnitType",
                            Value = HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width + 150f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width Units",
                            Type = "DimensionUnitType",
                            Value = WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X",
                            Type = "float",
                            Value = X + -317f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Origin",
                            Type = "HorizontalAlignment",
                            Value = XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Units",
                            Type = "PositionUnitType",
                            Value = XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y",
                            Type = "float",
                            Value = Y + 287f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Units",
                            Type = "PositionUnitType",
                            Value = YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Background.Blue",
                            Type = "int",
                            Value = Background.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Background.Green",
                            Type = "int",
                            Value = Background.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Background.Height",
                            Type = "float",
                            Value = Background.Height + 15f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Background.Red",
                            Type = "int",
                            Value = Background.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Background.Width",
                            Type = "float",
                            Value = Background.Width + 150f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Background.X",
                            Type = "float",
                            Value = Background.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Background.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Background.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Background.Y",
                            Type = "float",
                            Value = Background.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Background.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Background.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Foreground.Blue",
                            Type = "int",
                            Value = Foreground.Blue + 19
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Foreground.Green",
                            Type = "int",
                            Value = Foreground.Green + 102
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Foreground.Height",
                            Type = "float",
                            Value = Foreground.Height + 15f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Foreground.Red",
                            Type = "int",
                            Value = Foreground.Red + 74
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Foreground.Width",
                            Type = "float",
                            Value = Foreground.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Foreground.Width Units",
                            Type = "DimensionUnitType",
                            Value = Foreground.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Foreground.X",
                            Type = "float",
                            Value = Foreground.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Foreground.Y",
                            Type = "float",
                            Value = Foreground.Y + 7.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Foreground.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Foreground.YOrigin
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
            public Bullet_Game_PT1.GumRuntimes.ColoredRectangleRuntime Background { get; set; }
            public Bullet_Game_PT1.GumRuntimes.ColoredRectangleRuntime Foreground { get; set; }
            public HealthBarRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "HealthBar");
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
                Background = this.GetGraphicalUiElementByName("Background") as Bullet_Game_PT1.GumRuntimes.ColoredRectangleRuntime;
                Foreground = this.GetGraphicalUiElementByName("Foreground") as Bullet_Game_PT1.GumRuntimes.ColoredRectangleRuntime;
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
        }
    }
