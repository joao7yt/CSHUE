﻿namespace CSHUE.Components.NumericUpDown
{
    public class DecimalUpDown : CommonNumericUpDown<decimal>
    {
        #region Constructors

        static DecimalUpDown()
        {
            UpdateMetadata(typeof(DecimalUpDown), 1m, decimal.MinValue, decimal.MaxValue);
        }

        public DecimalUpDown() : base(decimal.TryParse, d => d, (v1, v2) => v1 < v2, (v1, v2) => v1 > v2)
        {
            // ignored
        }

        #endregion

        #region Base Class Overrides

        protected override decimal IncrementValue(decimal value, decimal increment)
        {
            return value + increment;
        }

        protected override decimal DecrementValue(decimal value, decimal increment)
        {
            return value - increment;
        }

        #endregion
    }
}