﻿namespace _WorldGenStateCapture
{
	internal class STRINGS
	{
		public static LocString STARTPARSING = "Start Collecting Worlds";
		public class MNI_STATISTICS
		{
			public static LocString TITLE = "MNI Statistics";

            public static LocString TOTAL_SHORT = "Seeds Total: {0}";
            public static LocString DAILY_SHORT = "Seeds Today: {0}";
            public static LocString SESSION_SHORT = "Seeds this session: {0}";
            public static LocString SESSION_TIME_SHORT = "Session Runtime: {0} m";
            public static LocString LASTTIME_SHORT = "Last generation time: {0} s";

			//these are todo/wip:

            public static LocString SEEDS_HIGHSCORE = "The most contributions happened on {0} with a total of {1} seeds.";
			public static LocString SEEDS_LAST_DATE = "The last time the mod collected seed on {0} with a total of {1} seeds.";


			public static LocString SEEDS_TOTAL = "You have collected a total of {0} seeds";
			public static LocString SEEDS_TODAY = "Today you have collected {0} seeds so far";
			public static LocString SESSION_TIME = "The current session has run for {0} minutes.";
			public static LocString SEEDS_SESSION = "The current session has collected {0} seeds so far.";
			public static LocString SEED_AVG_TIME = "The average time for per seed was {0} seconds.";
			public static LocString LAST_SEED_TIME = "The last seed took {0} seconds to generate.";

			public static LocString SEED_FAILED_GERMINATING = "This seed failed to germinate!";
		}
		public class WORLDPARSERMODCONFIG
		{
			public class RANDOMIZEDGEN
			{
				public static LocString NAME = "Generate random Clusters";
				public static LocString DESC = "Selects the cluster to generate at random.";
			}
			public class TARGETCLUSTERBASE
			{
				public static LocString NAME = "Target World (Basegame)";
				public static LocString DESC = "Coordinate prefix of the world to parse seeds from.";
			}
			public class TARGETCLUSTERDLC
			{
				public static LocString NAME = "Target Cluster (DLC)";
				public static LocString DESC = "Coordinate prefix of the cluster to parse seeds from.";
            }
            public class TARGETNUMBER
			{
				public static LocString NAME = "Seeds per Session";
				public static LocString DESC = "Total number of seeds the mod collects before doing a restart.";
			}
			public class RANDOMMIXING
			{
				public static LocString NAME = "Mixing Percentage";
				public static LocString DESC = "Percentage of worlds that will be generated with DLC Remixing enabled";
			}
		}
		public class AUTOPARSING
		{
			public class INPROGRESSDIALOG
			{
				public static LocString TITLE = "World collecting in progress";
				public static LocString DESC = "World parsing is in progress and will start in 10 seconds.\nclick below to cancel";
				public static LocString STARTNOW = "Skip timer";
			}
			public class MODSDETECTED
			{
				public static LocString TITLE = "Warning: active mods detected";
				public static LocString DESC = "There are currently other mods enabled that might invalidate the integrity of the collected world data.\nMap collection will proceed after you have disabled them.";				
			}
		}
	}
}
