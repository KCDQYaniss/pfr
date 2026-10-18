namespace EFT.Settings.Sound;

public sealed class SoundSettingsController : BaseSettingsController
{
	public const string VOIP_INIT_FAILED = "Voip/InitializationFailed"; //Field offset: 0x0
	private static AudioMixer _masterMixer; //Field offset: 0x0
	private string _voipDisabledReason; //Field offset: 0x28

	public private static bool IsVoipFirstMessageShown
	{
		 get { } //Length: 3
		private set { } //Length: 114
	}

	private static AudioMixer MasterMixer
	{
		private get { } //Length: 395
	}

	public private string VoipDisabledReason
	{
		 get { } //Length: 5
		private set { } //Length: 396
	}

	public SoundSettingsController() { }

	[CompilerGenerated]
	private void <CreateBindings>b__17_0(int x) { }

	[CompilerGenerated]
	private void <CreateBindings>b__17_1(int x) { }

	[CompilerGenerated]
	private void <CreateBindings>b__17_2(int x) { }

	[CompilerGenerated]
	private void <CreateBindings>b__17_3(int x) { }

	[CompilerGenerated]
	private void <CreateBindings>b__17_4(int x) { }

	private void AdjustSoundValue(string mixerChannel, int index) { }

	private void ChangeDenoiseAmount(NoiseSuppressionLevels value) { }

	private void ChangeMicrophoneSensitivity(int value) { }

	public void CheckVoipInitialization() { }

	protected virtual void CreateBindings() { }

	public static bool get_IsVoipFirstMessageShown() { }

	private static AudioMixer get_MasterMixer() { }

	public string get_VoipDisabledReason() { }

	public void ResetVoipDisabledReason() { }

	private static void set_IsVoipFirstMessageShown(bool value) { }

	private void set_VoipDisabledReason(string value) { }

	public virtual SoundSettingsGroup SettingsGroupFactory() { }

	private void ShowVoipEnabled(bool value) { }

	public void VoipDisabledByInitializationFail() { }

	public void VoipDisabledByServer() { }

	public void VoipDisabledInLocalGame() { }

}

