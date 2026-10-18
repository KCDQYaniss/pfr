namespace EFT.Settings.Game;

public static class GameSettingsVersions
{
	private sealed class Version1 : IVersion
	{

		private static bool LabAlreadyShown
		{
			private get { } //Length: 417
		}

		public Version1() { }

		private static bool get_LabAlreadyShown() { }

		public override void Upgrade(JObject data) { }

	}

	[CompilerGenerated]
	private static readonly IJsonSerializer <Serializer>k__BackingField; //Field offset: 0x0

	public static IJsonSerializer Serializer
	{
		[CompilerGenerated]
		 get { } //Length: 83
	}

	private static GameSettingsVersions() { }

	[CompilerGenerated]
	public static IJsonSerializer get_Serializer() { }

}

