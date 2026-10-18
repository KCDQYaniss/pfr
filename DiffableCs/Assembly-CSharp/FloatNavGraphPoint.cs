//Type is in global namespace

public class FloatNavGraphPoint : IComparable
{
	public FloatNavGraphPoint PrevPoint; //Field offset: 0x10
	public NavGraphEditorPoint Owner; //Field offset: 0x18
	public float Val; //Field offset: 0x20
	public float Dist; //Field offset: 0x24

	public Vector3 Position
	{
		 get { } //Length: 41
	}

	public FloatNavGraphPoint(float val, FloatNavGraphPoint prevPoint, NavGraphEditorPoint owner) { }

	public override int CompareTo(FloatNavGraphPoint other) { }

	public Vector3 get_Position() { }

}

