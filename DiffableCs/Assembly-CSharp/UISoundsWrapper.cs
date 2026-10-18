//Type is in global namespace

public class UISoundsWrapper : ScriptableObject
{
	internal class EndGameSound : SoundElement
	{

		public EndGameSound() { }

	}

	internal class SotialNetworkSound : SoundElement
	{

		public SotialNetworkSound() { }

	}

	internal abstract class SoundElement`1
	{
		[SerializeField]
		private TSoundTypeEnum _soundType; //Field offset: 0x0
		[SerializeField]
		private AudioClip _sound; //Field offset: 0x0

		public AudioClip TSound
		{
			 get { } //Length: 5
		}

		public TSoundTypeEnum TSoundType
		{
			 get { } //Length: 164
		}

		protected SoundElement`1() { }

		public AudioClip get_TSound() { }

		public TSoundTypeEnum get_TSoundType() { }

	}

	internal class UIClipSounds
	{
		[SerializeField]
		private AudioClip[] _audioClips; //Field offset: 0x10

		public UIClipSounds() { }

		public AudioClip GetRandomClip() { }

	}

	internal class UISound : SoundElement
	{

		public UISound() { }

	}

	private class UISoundsLogger : AbstractLogger
	{
		private static UISoundsLogger _instance; //Field offset: 0x0

		public static UISoundsLogger Instance
		{
			 get { } //Length: 311
		}

		private UISoundsLogger() { }

		public static UISoundsLogger get_Instance() { }

		public void LogMissingSound(Enum soundType) { }

	}

	[SerializeField]
	private UISound[] _UIAudioClips; //Field offset: 0x18
	[SerializeField]
	private SotialNetworkSound[] _socialNetworkAudioClips; //Field offset: 0x20
	[SerializeField]
	private EndGameSound[] _endGameAudioClips; //Field offset: 0x28
	[SerializeField]
	private UIClipSounds _loadSounds; //Field offset: 0x30
	[SerializeField]
	private UIClipSounds _unloadSounds; //Field offset: 0x38
	[SerializeField]
	public AudioClip _karmaPositiveSound; //Field offset: 0x40
	[SerializeField]
	public AudioClip _karmaNegativeSound; //Field offset: 0x48
	private readonly Dictionary _UIClipsIndex; //Field offset: 0x50
	private readonly Dictionary _socialNetworkClipsIndex; //Field offset: 0x58
	private readonly Dictionary _endGameClipsIndex; //Field offset: 0x60

	public UIClipSounds LoadSounds
	{
		 get { } //Length: 76
	}

	private UISoundsLogger Logger
	{
		private get { } //Length: 311
	}

	public UIClipSounds UnloadSounds
	{
		 get { } //Length: 5
	}

	public UISoundsWrapper() { }

	public UIClipSounds get_LoadSounds() { }

	private UISoundsLogger get_Logger() { }

	public UIClipSounds get_UnloadSounds() { }

	[CanBeNull]
	public AudioClip GetEndGameClip(EEndGameSoundType soundType) { }

	[CanBeNull]
	public AudioClip GetSocialNetworkClip(ESocialNetworkSoundType soundType) { }

	[CanBeNull]
	public AudioClip GetUIClip(EUISoundType soundType) { }

	private static void IndexClipList(SoundElement[] clipList, Dictionary clipsIndex) { }

	protected void OnEnable() { }

}

