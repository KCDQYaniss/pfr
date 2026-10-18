namespace EFT.Settings.Control;

public static class ControlSettingsVersions
{
	private sealed class Version1 : IVersion
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__1_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal EGameKey <RemoveReservedKeys>b__1_0(KeyGroup x) { }

		}


		public Version1() { }

		private static void RemoveReservedKeys(JObject data) { }

		public override void Upgrade(JObject data) { }

	}

	private sealed class Version2 : IVersion
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__1_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal EGameKey <RemoveReservedKeys>b__1_0(KeyGroup x) { }

		}


		public Version2() { }

		private static void RemoveReservedKeys(JObject data) { }

		public override void Upgrade(JObject data) { }

	}

	private sealed class Version3 : IVersion
	{

		public Version3() { }

		private static void RemoveReservedKeys(JObject data) { }

		public override void Upgrade(JObject data) { }

	}

	private sealed class Version4 : IVersion
	{

		public Version4() { }

		private static void RemoveReservedKeys(JObject data) { }

		public override void Upgrade(JObject data) { }

	}

	[CompilerGenerated]
	private static readonly IJsonSerializer <Serializer>k__BackingField; //Field offset: 0x0

	public static IJsonSerializer Serializer
	{
		[CompilerGenerated]
		 get { } //Length: 83
	}

	private static ControlSettingsVersions() { }

	[CompilerGenerated]
	public static IJsonSerializer get_Serializer() { }

}

