using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT.LibraryTriangle
{
    public class Triangle
    {
        /// <summary>
        /// Method for calculate the area of a triangle.
        /// Set up the formula: Area = 1/2 * (baseTriangle * heightTriangle)
        /// </summary>
        /// <param name="baseTriangle">Base is a one side of a triangle.</param>
        /// <param name="heightTriangle">The height is the measure of the tallest point on a triangle.</param>
        /// <returns></returns>
        public static double AreaBaseHeight(double baseTriangle, double heightTriangle)
        {
            float temp = 1;
            return temp/2 * (baseTriangle * heightTriangle);
        }
        /// <summary>
        /// Method for calculate the area of a triangle.
        /// Set up Heron's formula: Area = Math.Sqrt(s(s - sideA)(s - sideB)(s - sidec)), where 
        /// s is the semiperimeter of the triangle, and s = 1/2 * (sideA + sideB + sideC)
        /// </summary>
        /// <param name="sideA">First side</param>
        /// <param name="sideB">Second side</param>
        /// <param name="sideC">Third side</param>
        /// <returns></returns>
        public static double AreaSideLengths(double sideA, double sideB, double sideC)
        {
            float temp = 1;
            double s = temp / 2 * (sideA + sideB + sideC);
            return Math.Sqrt(s*(s - sideA)*(s - sideB)*(s - sideC));
        }

        
        /// <summary>
        /// Method for calculate the area of a triangle,
        /// this method is used for equilateral triangle only.
        /// Set up the formula: Area = side^2 * (Math.Sqrt(3)/4)
        /// </summary>
        /// <param name="side">One side</param>
        /// <returns></returns>
        public static double AreaOneSide(double side)
        {
            return (side * side) * (Math.Sqrt(3) / 4);
        }

        /// <summary>
        /// Method for calculate the area of a triangle.
        /// Set up the trigonometry formula: Area = ((sideAdjacentA * sideAdjacentB) / 2) * Math.Sin(angle),
        /// where sideAdjacentA and sideAdjacentB are the adjacent sides of the triangle, and angle is the
        /// angle between them.
        /// </summary>
        /// <param name="sideAdjacentA">Adjacent side A to the angle.</param>
        /// <param name="sideAdjacentB">Adjacent side B to the angle.</param>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static double AreaTrigonometry(double sideAdjacentA, double sideAdjacentB, double angle)
        {            
            return ((sideAdjacentA * sideAdjacentB) / 2) * Math.Sin(Math.PI/180 * angle);
        }
    }
}
