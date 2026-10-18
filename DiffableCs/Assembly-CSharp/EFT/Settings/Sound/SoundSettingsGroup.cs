namespace EFT.Settings.Sound;

public sealed class SoundSettingsGroup : SettingsGroup
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__29_0; //Field offset: 0x8
		public static Func <>9__29_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <.ctor>b__29_0(int x) { }

		internal int <.ctor>b__29_1(int x) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__ClampIndex; //Field offset: 0x0
		public static Func <1>__ValidateMicrophone; //Field offset: 0x8

	}

	public const string NOTHING_DEVICE = "Settings/UnavailablePressType"; //Field offset: 0x0
	public const string DEFAULT_DEVICE = "Default"; //Field offset: 0x0
	public const string MASTER_VOLUME_KEY = "MasterVolume"; //Field offset: 0x0
	public const string MUSIC_VOLUME_KEY = "MusicVolume"; //Field offset: 0x0
	public const string INTERFACE_VOLUME_VOLUME_KEY = "UIVolume"; //Field offset: 0x0
	public const string CHAT_VOLUME_KEY = "ChatVolume"; //Field offset: 0x0
	public const string HIDEOUT_VOLUME_KEY = "HideoutVolume"; //Field offset: 0x0
	private static Nullable _checkMicrophone; //Field offset: 0x0
	private static readonly int[] _realSoundValues; //Field offset: 0x8
	private static readonly string[] _noDevicesArray; //Field offset: 0x10
	public readonly GameSetting OverallVolume; //Field offset: 0x18
	public readonly GameSetting InterfaceVolume; //Field offset: 0x20
	public readonly GameSetting ChatVolume; //Field offset: 0x28
	public readonly GameSetting MusicVolume; //Field offset: 0x30
	public readonly GameSetting HideoutVolume; //Field offset: 0x38
	public readonly GameSetting MusicOnRaidEnd; //Field offset: 0x40
	public readonly GameSetting VoipEnabled; //Field offset: 0x48
	public readonly GameSetting VoipDevice; //Field offset: 0x50
	public readonly GameSetting VoiceChatVolume; //Field offset: 0x58
	public readonly GameSetting MicrophoneSensitivity; //Field offset: 0x60
	public readonly GameSetting DenoiseAmount; //Field offset: 0x68

	public static string DefaultMicrophone
	{
		 get { } //Length: 116
	}

	[JsonIgnore]
	public float HideoutVolumeValue
	{
		 get { } //Length: 192
	}

	[JsonIgnore]
	public float InterfaceVolumeValue
	{
		 get { } //Length: 192
	}

	[JsonIgnore]
	public bool IsMicrophoneValid
	{
		 get { } //Length: 167
	}

	[JsonIgnore]
	public float MusicVolumeValue
	{
		 get { } //Length: 192
	}

	private static SoundSettingsGroup() { }

	public SoundSettingsGroup() { }

	public static bool CheckMicrophone() { }

	private static bool CheckVoipEnable(bool voipEnabled) { }

	private static int ClampIndex(int value) { }

	public virtual SoundSettingsGroup Clone() { }

	public void ForceApplyVolumeSettings() { }

	public static string get_DefaultMicrophone() { }

	public float get_HideoutVolumeValue() { }

	public float get_InterfaceVolumeValue() { }

	public bool get_IsMicrophoneValid() { }

	public float get_MusicVolumeValue() { }

	private float GetBackendVolumeMultiplier(string mixerChannel) { }

	public static ReadOnlyCollection GetMicrophones() { }

	public float GetRealSoundValue(int index, string mixerChannel) { }

	public int GetRealSoundValue(int index) { }

	public static bool IsCurrentMicrophoneValid() { }

	public static bool IsValidMicrophone(string device) { }

	public void UpdateMicrophoneDevice() { }

	public static string ValidateMicrophone(string device) { }

}

