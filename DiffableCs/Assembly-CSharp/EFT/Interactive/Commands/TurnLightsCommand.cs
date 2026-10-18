namespace EFT.Interactive.Commands;

public sealed class TurnLightsCommand : Command
{
	internal struct Data
	{
		[CompilerGenerated]
		private readonly bool <IsOn>k__BackingField; //Field offset: 0x0

		public bool IsOn
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
		}

		public Data(bool isOn) { }

		[CompilerGenerated]
		[IsReadOnly]
		public bool get_IsOn() { }

	}

	private readonly LampLights _lampLights; //Field offset: 0x18

	public TurnLightsCommand(LampLights lampLights) { }

	public void Execute() { }

}

