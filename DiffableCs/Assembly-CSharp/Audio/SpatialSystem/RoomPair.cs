namespace Audio.SpatialSystem;

public class RoomPair : IEquatable, IBinarySerializable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__7_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <.ctor>b__7_0(Route x) { }

	}

	internal struct AudioPortalData
	{
		public float closureLevel; //Field offset: 0x0
		public float3 center; //Field offset: 0x4
		public float traversalMaxCost; //Field offset: 0x10
		public float depth; //Field offset: 0x14
		public float frontRoomWallOcclusion; //Field offset: 0x18
		public float backRoomWallOcclusion; //Field offset: 0x1C
		public bool isFrontRoomOutdoor; //Field offset: 0x20
		public bool isBackRoomOutdoor; //Field offset: 0x21
		public float3 portalNormal; //Field offset: 0x24
		public float3 portalRight; //Field offset: 0x30
		public float3 portalUp; //Field offset: 0x3C
		public float2 portalHalfSize; //Field offset: 0x48

	}

	internal struct Route : IBinarySerializable
	{
		public short[] PortalIDs; //Field offset: 0x0
		public float HeuristicCost; //Field offset: 0x8
		public float TraverseDistance; //Field offset: 0xC

		public override void Read(BinaryReader reader) { }

		public override void Write(BinaryWriter writer) { }

	}

	public uint ID; //Field offset: 0x10
	public short FirstRoomID; //Field offset: 0x14
	public short SecondRoomID; //Field offset: 0x16
	public Route[] Routes; //Field offset: 0x18
	public int TotalPortalsCount; //Field offset: 0x20
	public byte ShortestRouteLength; //Field offset: 0x24

	public RoomPair() { }

	public RoomPair(uint id, SpatialAudioRoom firstRoom, SpatialAudioRoom secondRoom, Route[] routes, int totalPortalsCount) { }

	public override bool Equals(RoomPair other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public bool IsMatch(ISpatialAudioRoom firstRoom, ISpatialAudioRoom secondRoom, out bool isReversed) { }

	public override void Read(BinaryReader reader) { }

	public override void Write(BinaryWriter writer) { }

}

