namespace EFT.Interactive.Commands;

public sealed class PlaySoundCommand : Command
{
	[IsReadOnly]
	internal struct Data
	{
		[CompilerGenerated]
		private readonly AudioClip <Clip>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly bool <IsLoop>k__BackingField; //Field offset: 0x8

		public AudioClip Clip
		{
			[CompilerGenerated]
			 get { } //Length: 4
		}

		public bool IsLoop
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public Data(AudioClip clip, bool isLoop) { }

		[CompilerGenerated]
		public AudioClip get_Clip() { }

		[CompilerGenerated]
		public bool get_IsLoop() { }

	}

	private readonly LampSound _lampSound; //Field offset: 0x30

	public PlaySoundCommand(LampSound lampSound) { }

	public void Execute(float time) { }

}

