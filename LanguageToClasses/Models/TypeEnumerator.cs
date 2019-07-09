using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageToClasses.Models
{
	[Flags]
	public enum IntegralTypeEnumerator
	{
		sbyteType = 1,
		ushortType = 2,
		shortType = 4,
		uintType = 8,
		intType = 16,
		ulongType = 32,
		longType = 64,
		byteType = 128
	}

	[Flags]
	public enum FloatingTypeEnumerator
	{
		doubleType = 1,
		decimalType = 2,
		floatType = 4
	}

	[Flags]
	public enum SpecialTypeEnumerator
	{
		datetime = 1,
		boolean = 2,
		charType = 4
	}
}
