namespace EFT.Network;

public static class SnapshotInterpolator
{
	internal struct SnapshotInterpolatorOptions
	{
		public float DynamicAdjustmentTolerance; //Field offset: 0x0
		public int DeliveryTimeEmaDuration; //Field offset: 0x4
		public float CatchupNegativeThreshold; //Field offset: 0x8
		public float CatchupPositiveThreshold; //Field offset: 0xC
		public double CatchupSpeed; //Field offset: 0x10
		public double SlowdownSpeed; //Field offset: 0x18

	}

	public static SnapshotInterpolatorOptions DefaultOptions; //Field offset: 0x0
	public static readonly int DefaultRemoteFramerate; //Field offset: 0x20

	private static SnapshotInterpolator() { }

}

