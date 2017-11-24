using Sitecore.Data;

namespace Sitecore.Feature.Events
{
	public struct Templates
	{
		public struct Event
		{
			public static readonly ID ID = new ID("{320F6008-6AA5-4179-BD13-CC601228BB6F}");

			public struct Fields
			{
				public static readonly ID Title = new ID("{21E5E8A8-3997-4964-8372-7DCF663A3B8C}");
				public static readonly ID Description = new ID("{CE955C15-C4A1-4B22-B57C-B5AE817584E6}");
				public static readonly ID Date = new ID("{3E892AC6-43C1-4BF0-AFC0-704E17527A61}");
				public static readonly ID Venue = new ID("{F84A6D73-10C8-4AA1-942C-2E12DE9968C7}");
				public static readonly ID VenueAddress = new ID("{2CA0E264-E90D-4FCF-9712-9546B5640A6B}");
			}
		}
	}
}