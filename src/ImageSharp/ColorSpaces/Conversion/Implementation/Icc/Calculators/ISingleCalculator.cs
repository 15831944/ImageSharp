﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

namespace SixLabors.ImageSharp.ColorSpaces.Conversion.Implementation.Icc.Calculators
{
    /// <summary>
    /// Represents an ICC calculator with a single floating point value and result
    /// </summary>
    internal interface ISingleCalculator
    {
        /// <summary>
        /// Calculates a result from the given value
        /// </summary>
        /// <param name="value">The input value</param>
        /// <returns>The calculated result</returns>
        float Calculate(float value);
    }
}