namespace Audio.SpatialSystem;

public interface ISpatialAudioRoom : ISpatialRoom
{

	public Bounds Bounds
	{
		 get { } //Length: 0
	}

	public AudioRoomAreaColliderCache[] ColliderCache
	{
		 get { } //Length: 0
	}

	public BoxCollider[] Colliders
	{
		 get { } //Length: 0
	}

	public bool IsIsolated
	{
		 get { } //Length: 0
	}

	public bool IsOutdoor
	{
		 get { } //Length: 0
	}

	public bool IsValid
	{
		 get { } //Length: 0
	}

	public string Name
	{
		 get { } //Length: 0
	}

	public RoomAmbientData RoomAmbientData
	{
		 get { } //Length: 0
	}

	public float RoomSize
	{
		 get { } //Length: 0
	}

	public EAudioRoomTypeMask Type
	{
		 get { } //Length: 0
	}

	public bool CheckIsolationRelation(ISpatialAudioRoom roomToCheck) { }

	public Bounds get_Bounds() { }

	public AudioRoomAreaColliderCache[] get_ColliderCache() { }

	public BoxCollider[] get_Colliders() { }

	public bool get_IsIsolated() { }

	public bool get_IsOutdoor() { }

	public bool get_IsValid() { }

	public string get_Name() { }

	public RoomAmbientData get_RoomAmbientData() { }

	public float get_RoomSize() { }

	public EAudioRoomTypeMask get_Type() { }

	public void PlayRoomToneSound() { }

	public void StopRoomToneSound() { }

}

