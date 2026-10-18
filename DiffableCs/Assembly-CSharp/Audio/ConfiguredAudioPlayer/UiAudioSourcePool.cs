namespace Audio.ConfiguredAudioPlayer;

public sealed class UiAudioSourcePool
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public UiAudioSourcePool <>4__this; //Field offset: 0x10
		public AudioSource source; //Field offset: 0x18
		public Action onReturned; //Field offset: 0x20

		public <>c__DisplayClass6_0() { }

		internal void <StopAndReturn>b__0() { }

	}

	private readonly GameObject _owner; //Field offset: 0x10
	private readonly AudioMixerGroup _mixerGroup; //Field offset: 0x18
	private readonly List _availableSources; //Field offset: 0x20
	private readonly HashSet _ownedSources; //Field offset: 0x28

	public UiAudioSourcePool(GameObject owner, AudioMixerGroup mixerGroup) { }

	private AudioSource CreateSource() { }

	private void PrepareForRent(AudioSource source) { }

	public void Release() { }

	public AudioSource Rent() { }

	private void ResetSource(AudioSource source) { }

	public void Return(AudioSource source) { }

	public void StopAndReturn(AudioSource source, float fadeOutTime = 0, Action onReturned = null) { }

}

