﻿using KestenApp.Models.Enums;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace KestenApp.Models.Enums.EnumHelpers
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class RangeInt : Attribute
    {
        public int Minimun { get; private set; }
        public int Maximum { get; private set; }
        public IntRangeTypeEnum Type { get; private set; }

        /// <summary>
        /// Fruit weight range in grams
        /// </summary>
        /// <param name="minimum">Minimum weight of fruit</param>
        /// <param name="maximum">Maximum weight of fruit</param>
        /// <param name="type">Range enum type</param>
        /// <exception cref="InvalidOperationException"></exception>
        public RangeInt(int minimum, int maximum, IntRangeTypeEnum type)
        {
            if (minimum >= maximum)
            {
                throw new InvalidOperationException($"Fruit weight minimum {minimum} must be less than the maximum {maximum}");
            }

            Minimun = minimum;
            Maximum = maximum;
            Type = type;
        }
    }
}