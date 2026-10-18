namespace Audio.SpatialSystem;

public class EmptyAudioRoom : ISpatialAudioRoom, ISpatialRoom
{
	private static readonly List _fakePortalsList; //Field offset: 0x0
	[CompilerGenerated]
	private readonly BoxCollider[] <Colliders>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly RoomAmbientData <RoomAmbientData>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Bounds <Bounds>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly AudioRoomAreaColliderCache[] <ColliderCache>k__BackingField; //Field offset: 0x38

	public override Bounds Bounds
	{
		[CompilerGenerated]
		 get { } //Length: 21
	}

	public override AudioRoomAreaColliderCache[] ColliderCache
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override BoxCollider[] Colliders
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override short ID
	{
		 get { } //Length: 6
	}

	public override bool IsIsolated
	{
		 get { } //Length: 3
	}

	public override bool IsOutdoor
	{
		 get { } //Length: 3
	}

	public override bool IsValid
	{
		 get { } //Length: 3
	}

	public override string Name
	{
		 get { } //Length: 49
	}

	public override RoomAmbientData RoomAmbientData
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override float RoomSize
	{
		 get { } //Length: 4
	}

	public override EAudioRoomTypeMask Type
	{
		 get { } //Length: 6
	}

	private static EmptyAudioRoom() { }

	public EmptyAudioRoom() { }

	public override bool CheckIsolationRelation(ISpatialAudioRoom roomToCheck) { }

	[CompilerGenerated]
	public override Bounds get_Bounds() { }

	[CompilerGenerated]
	public override AudioRoomAreaColliderCache[] get_ColliderCache() { }

	[CompilerGenerated]
	public override BoxCollider[] get_Colliders() { }

	public override short get_ID() { }

	public override bool get_IsIsolated() { }

	public override bool get_IsOutdoor() { }

	public override bool get_IsValid() { }

	public override string get_Name() { }

	[CompilerGenerated]
	public override RoomAmbientData get_RoomAmbientData() { }

	public override float get_RoomSize() { }

	public override EAudioRoomTypeMask get_Type() { }

	public override List GetPortals() { }

	public override void PlayRoomToneSound() { }

	public override void StopRoomToneSound() { }

}

