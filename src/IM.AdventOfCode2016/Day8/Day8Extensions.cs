﻿using System.Linq;

namespace IM.AdventOfCode2016.Day8
{
	public static class Day8Extensions
	{
		public static string AsString(this Pixel[] line)
		{
			return line.Select(x => x.Value).AsString();
		}
	}
}