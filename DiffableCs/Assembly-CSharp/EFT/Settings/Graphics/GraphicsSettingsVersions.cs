namespace EFT.Settings.Graphics;

public static class GraphicsSettingsVersions
{
	private sealed class ResetGraphics : IVersion
	{

		public ResetGraphics() { }

		public override void Upgrade(JObject data) { }

		private static void UpgradeDisplaySettings(JObject data) { }

	}

	private sealed class ResetSSR : IVersion
	{

		public ResetSSR() { }

		public override void Upgrade(JObject data) { }

		private static void UpgradeSSRSettings(JObject data) { }

	}

	private sealed class Version1 : IVersion
	{
		private readonly float[] _overallVisibilityVariants; //Field offset: 0x10
		private readonly float[] _shadowsVisibilityVariants; //Field offset: 0x18
		private readonly float[] _lodBiasVariants; //Field offset: 0x20
		private readonly float[] _sharpenVariants; //Field offset: 0x28

		public Version1() { }

		private static void HighTextureQualityWithMipStreaming(JObject data) { }

		private static void MakeMediumGraphicsQualityAsZero(JObject data) { }

		public override void Upgrade(JObject data) { }

	}

	private sealed class Version2 : IVersion
	{

		public Version2() { }

		public override void Upgrade(JObject data) { }

		private static void UpgradeDisplaySettings(JObject data) { }

	}

	private sealed class Version3 : IVersion
	{

		public Version3() { }

		public override void Upgrade(JObject data) { }

		private static void UpgradeDisplaySettings(JObject data) { }

	}

	private sealed class Version6 : IVersion
	{

		public Version6() { }

		public override void Upgrade(JObject data) { }

		private static void UprgadeVolumetricLightSettings(JObject data) { }

	}

	private sealed class Version7MipStreaming : IVersion
	{

		public Version7MipStreaming() { }

		public override void Upgrade(JObject data) { }

		private static void UpgradeMipStreaming(JObject data) { }

	}

	private sealed class Version8ResetFPSLobby : IVersion
	{

		public Version8ResetFPSLobby() { }

		public override void Upgrade(JObject data) { }

		private static void UpgradeMipStreaming(JObject data) { }

	}

	private sealed class Version9MipStreaming : IVersion
	{

		public Version9MipStreaming() { }

		private static void RemoveMipStreaming(JObject data) { }

		public override void Upgrade(JObject data) { }

	}

	[CompilerGenerated]
	private static readonly IJsonSerializer <Serializer>k__BackingField; //Field offset: 0x0
	private const string STORED = "Stored"; //Field offset: 0x0

	public static IJsonSerializer Serializer
	{
		[CompilerGenerated]
		 get { } //Length: 83
	}

	private static GraphicsSettingsVersions() { }

	[CompilerGenerated]
	public static IJsonSerializer get_Serializer() { }

}

