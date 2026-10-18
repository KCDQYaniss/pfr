namespace EFT;

public class PhraseSounds : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public string voice; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <GetVoice>b__0(Voice x) { }

	}

	public Voice[] Voices; //Field offset: 0x18

	public PhraseSounds() { }

	public TagBank[] GetVoice(string voice, EPlayerSide side) { }

	[CanBeNull]
	private TagBank[] GetVoice(string voice) { }

	public bool TryGetVoice(string voice, out TagBank[] result) { }

}

