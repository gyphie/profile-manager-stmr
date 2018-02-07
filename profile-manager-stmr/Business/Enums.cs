using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net.glympz.ProfileManagerSTMR.Business
{
	public enum ModType
	{
		Unknown = 0,
		Map = 1,
		Vehicle = 2,
		Other = 3
	}

	public enum Rating
	{
		None = 0,
		ThumbsUp = 1,
		ThumbsDown = 2
	}

	public static class Enums
	{
		public static string ModTypeToString(ModType modType)
		{
			switch (modType)
			{
				case ModType.Map:
					return "Map";
				case ModType.Vehicle:
					return "Vehicle";
				default:
					return "Other";
			}
		}
		public static ModType StringToModType(string modType)
		{
			if (modType == "Map")
			{
				return ModType.Map;
			}
			else if (modType == "Vehicle")
			{
				return ModType.Vehicle;
			}
			else if (modType == "Autodetect")
			{
				return ModType.Unknown;
			}
			else
			{
				return ModType.Other;
			}
		}

		public static ModType IntToModType(int typeID)
		{
			try
			{
				return (ModType)typeID;
			}
			catch { }

			return ModType.Unknown;
		}


		public static string RatingToString(Rating rating)
		{
			switch (rating)
			{
				case Rating.ThumbsUp:
					return "Thumbs Up";
				case Rating.ThumbsDown:
					return "Thumbs Down";
				default:
					return "None";
			}
		}

		public static string RatingToEmoji(Rating rating)
		{
			switch (rating)
			{
				case Rating.ThumbsUp:
					return "👍";
				case Rating.ThumbsDown:
					return "👎";
				default:
					return "";
			}
		}
		public static Rating StringToRating(string rating)
		{
			if (rating == "Thumbs Up")
			{
				return Rating.ThumbsUp;
			}
			else if (rating == "Thumbs Down")
			{
				return Rating.ThumbsDown;
			}
			else
			{
				return Rating.None;
			}
		}
		public static Rating IntToRating(int ratingID)
		{
			try
			{
				return (Rating)ratingID;
			}
			catch { }

			return Rating.None;
		}
	}
}
