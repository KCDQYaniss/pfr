namespace EFT.GlobalEvents.AudioEvents;

public class AudioPortalStateChangedEvent : BaseEvent
{
	[CompilerGenerated]
	private PortalState <PortalState>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private float <ClosureLevel>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private float <Depth>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private float <TraversalCost>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private short <PortalID>k__BackingField; //Field offset: 0x28

	public private float ClosureLevel
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float Depth
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private short PortalID
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private PortalState PortalState
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private float TraversalCost
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public AudioPortalStateChangedEvent() { }

	[CompilerGenerated]
	public float get_ClosureLevel() { }

	[CompilerGenerated]
	public float get_Depth() { }

	[CompilerGenerated]
	public short get_PortalID() { }

	[CompilerGenerated]
	public PortalState get_PortalState() { }

	[CompilerGenerated]
	public float get_TraversalCost() { }

	public void Invoke(short id, PortalState newState, float closureLevel, float depth, float traversalCost) { }

	public virtual void Reset() { }

	[CompilerGenerated]
	private void set_ClosureLevel(float value) { }

	[CompilerGenerated]
	private void set_Depth(float value) { }

	[CompilerGenerated]
	private void set_PortalID(short value) { }

	[CompilerGenerated]
	private void set_PortalState(PortalState value) { }

	[CompilerGenerated]
	private void set_TraversalCost(float value) { }

}

