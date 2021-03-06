﻿namespace Math.Algebra.Structures.Fields
{
	/// <summary>
	/// For classes that support a conversion to string with specified parameters, like double
	/// </summary>
	public interface INumerical
	{
		string ToString();

		string ToString(string format);

		INumerical Round();

		INumerical Log10();

		/**
		 * For instances with mutiple values, like Complex and Rational, the value
		 * that is longest when converted to a string
		 */
		INumerical LongestValue();
	}
}
