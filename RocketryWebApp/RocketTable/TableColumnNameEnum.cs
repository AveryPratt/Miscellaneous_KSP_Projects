﻿namespace RocketryWebApp.Calculator
{
    public partial class CalculatorWebForm
    {
        public enum InputValue
        {
            WetMass,
            DryMass,
            Isp,
            DeltaV,
            Thrust,
            MinTWR,
            MaxTWR,
        }
        public enum ColumnName
        {
            StageName,
            WetMass,
            DryMass,
            Isp,
            DeltaV,
            Thrust,
            MinTWR,
            MaxTWR,
            Buttons
        }
    }
}