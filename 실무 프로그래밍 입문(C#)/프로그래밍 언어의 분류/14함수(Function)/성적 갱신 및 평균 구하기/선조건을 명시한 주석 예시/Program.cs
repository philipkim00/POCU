using System;

namespace 선조건을_명시한_주석_예시
{
    internal class Program
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="neumerator"></param>
        /// <param name="denominator">no zero</param>
        /// <returns></returns>
        static float Divide(float numerator, float denominator)
        {
            return numerator / denominator;
        }
    }
}
