namespace EFT.Interactive.Commands;

public sealed class PlayEffectCommand : Command
{
	[IsReadOnly]
	internal struct Data
	{
		[CompilerGenerated]
		private readonly string <Key>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly Vector3 <Direction>k__BackingField; //Field offset: 0x8

		public Vector3 Direction
		{
			[CompilerGenerated]
			 get { } //Length: 19
		}

		public string Key
		{
			[CompilerGenerated]
			 get { } //Length: 4
		}

		public Data(string key, Vector3 direction) { }

		[CompilerGenerated]
		public Vector3 get_Direction() { }

		[CompilerGenerated]
		public string get_Key() { }

	}

	private readonly LampController _lampController; //Field offset: 0x38

	public PlayEffectCommand(LampController lampController) { }

	public void Execute(float time) { }

}

