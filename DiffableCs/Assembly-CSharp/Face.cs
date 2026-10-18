//Type is in global namespace

public class Face
{
	public static Vector3[] Points; //Field offset: 0x0
	public int I0; //Field offset: 0x10
	public int I1; //Field offset: 0x14
	public int I2; //Field offset: 0x18
	public float A; //Field offset: 0x1C
	public float B; //Field offset: 0x20
	public float C; //Field offset: 0x24
	public float D; //Field offset: 0x28

	public Vector3 Centroid
	{
		 get { } //Length: 314
	}

	public Face(int i0, int i1, int i2) { }

	private void ComputePlane() { }

	public void Flip() { }

	public Vector3 get_Centroid() { }

	public bool IsVisible(Vector3 p) { }

}

