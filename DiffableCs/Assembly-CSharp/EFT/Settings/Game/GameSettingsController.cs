namespace EFT.Settings.Game;

public sealed class GameSettingsController : BaseSettingsController
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__ChangeCulture; //Field offset: 0x0
		public static Action <1>__ChangeConnectionType; //Field offset: 0x8
		public static Action <2>__ChangeNotificationType; //Field offset: 0x10
		public static Action <3>__ChangeProcessAffinity; //Field offset: 0x18

	}

	private const string STREAMER_NICKNAME = "<Streamer>"; //Field offset: 0x0
	private string _streamerProfileId; //Field offset: 0x28

	public bool IsStreamerModeActive
	{
		 get { } //Length: 203
	}

	public GameSettingsController() { }

	private static void ChangeConnectionType(EConnectionType value) { }

	private static void ChangeCulture(string value) { }

	private static void ChangeNotificationType(ENotificationTransportType value) { }

	private static void ChangeProcessAffinity(bool value) { }

	private void ChangeStreamerModeEnabled(bool value) { }

	protected virtual void CreateBindings() { }

	public bool get_IsStreamerModeActive() { }

	public string GetCorrectedLocalNickname(string originalNickname) { }

	public string GetCorrectedProfileNickname(string id, string originalNickname) { }

	public bool IsLocalStreamer(string profileId) { }

	public void SetLocalProfile(Profile profile) { }

	public virtual GameSettingsGroup SettingsGroupFactory() { }

}

