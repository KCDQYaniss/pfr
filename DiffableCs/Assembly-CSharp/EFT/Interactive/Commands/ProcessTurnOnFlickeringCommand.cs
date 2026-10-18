namespace EFT.Interactive.Commands;

public sealed class ProcessTurnOnFlickeringCommand : Command
{
	internal struct Data
	{
		[CompilerGenerated]
		private readonly float <Intensity>k__BackingField; //Field offset: 0x0

		public float Intensity
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
		}

		public Data(float intensity) { }

		[CompilerGenerated]
		[IsReadOnly]
		public float get_Intensity() { }

	}

	private readonly LampSound _lampSound; //Field offset: 0x20

	public ProcessTurnOnFlickeringCommand(LampSound lampSound) { }

	public void Execute() { }

}

