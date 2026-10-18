namespace Dissonance;

internal class PacketLossMonitor
{
	private readonly ReadOnlyCollection _players; //Field offset: 0x10
	private DateTime _lastUpdatedPacketLoss; //Field offset: 0x18
	private int _lastUpdatedPlayerCount; //Field offset: 0x20
	private readonly List _tmpLossValues; //Field offset: 0x28
	[CompilerGenerated]
	private float <PacketLoss>k__BackingField; //Field offset: 0x30

	public private float PacketLoss
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public PacketLossMonitor(ReadOnlyCollection players) { }

	private Nullable CalculatePacketLoss() { }

	private bool CheckCount() { }

	private bool CheckTime(DateTime now) { }

	[CompilerGenerated]
	public float get_PacketLoss() { }

	[CompilerGenerated]
	private void set_PacketLoss(float value) { }

	public void Update(Nullable utcNow = null) { }

}

