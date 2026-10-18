namespace EFT.GlobalEvents;

public class BtrFirstPassengerGoInEvent : BaseEvent
{
	[CompilerGenerated]
	private EPlayerSide <PlayerSide>k__BackingField; //Field offset: 0x18

	public private EPlayerSide PlayerSide
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BtrFirstPassengerGoInEvent() { }

	[CompilerGenerated]
	public EPlayerSide get_PlayerSide() { }

	public void Invoke(EPlayerSide playerSide) { }

	public virtual void Reset() { }

	[CompilerGenerated]
	private void set_PlayerSide(EPlayerSide value) { }

}

