namespace EFT.VolumePropagation;

public interface IVolumePropagationSourceReadOnly
{

	public float CurrentReachRadius
	{
		 get { } //Length: 0
	}

	public bool IsAlive
	{
		 get { } //Length: 0
	}

	public float Lifetime
	{
		 get { } //Length: 0
	}

	public Vector3 Position
	{
		 get { } //Length: 0
	}

	public byte PresetId
	{
		 get { } //Length: 0
	}

	public IReadOnlyList RenderableVoxels
	{
		 get { } //Length: 0
	}

	public IVolumePropagationSettings Settings
	{
		 get { } //Length: 0
	}

	public int SourceId
	{
		 get { } //Length: 0
	}

	public float get_CurrentReachRadius() { }

	public bool get_IsAlive() { }

	public float get_Lifetime() { }

	public Vector3 get_Position() { }

	public byte get_PresetId() { }

	public IReadOnlyList get_RenderableVoxels() { }

	public IVolumePropagationSettings get_Settings() { }

	public int get_SourceId() { }

	public bool IsFilled(int x, int y, int z) { }

}

