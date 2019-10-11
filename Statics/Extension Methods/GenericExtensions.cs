﻿using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class GenericExtensions
{
	public static bool IsBetween <T>(this T figure, T lower, T upper) where T : IComparable<T>
	{
		return figure.CompareTo(lower) >= 0 && figure.CompareTo(upper) <= 0;
	}

	public static int ClosestValueUpper(this int[] collection, int targetValue)
	{
		collection.OrderBy(x => x);
		int closestValue = collection[0];
		int minDiff = int.MaxValue;
		for(int i = 0; i < collection.Length; i++)
		{
			int diff = Math.Abs(collection[i] - targetValue);
			if(minDiff > diff)
			{
				minDiff = diff;
			}
			else
			{
				if(minDiff == diff)
				{
					closestValue = collection[i];
				}
				else
				{
					closestValue = collection[i - 1];
				}
				break;
			}
		}
		return closestValue;
	}
}