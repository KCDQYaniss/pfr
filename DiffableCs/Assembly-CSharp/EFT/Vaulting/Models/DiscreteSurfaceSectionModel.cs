namespace EFT.Vaulting.Models;

public struct DiscreteSurfaceSectionModel
{
	private float _length; //Field offset: 0x0
	private float _height; //Field offset: 0x4
	private float _distance; //Field offset: 0x8
	private int _pointsCount; //Field offset: 0xC
	private float _sumHeights; //Field offset: 0x10
	private SurfaceType _surfaceType; //Field offset: 0x14

	public float Distance
	{
		 get { } //Length: 6
	}

	public float Height
	{
		 get { } //Length: 6
	}

	public float Length
	{
		 get { } //Length: 5
	}

	public SurfaceType Type
	{
		 get { } //Length: 4
	}

	public DiscreteSurfaceSectionModel(SurfaceType surfaceType) { }

	public void AddPoints(Vector3 p1, Vector3 p0) { }

	private float CalculateDistance(ref Vector3 p0) { }

	private float CalculateHeight(ref Vector3 p1, ref Vector3 p0) { }

	private float CalculateLength(ref Vector3 p1, ref Vector3 p0) { }

	public float get_Distance() { }

	public float get_Height() { }

	public float get_Length() { }

	public SurfaceType get_Type() { }

}

