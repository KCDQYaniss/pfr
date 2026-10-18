//Type is in global namespace

public sealed class LocationInGrid
{
	public int x; //Field offset: 0x10
	public int y; //Field offset: 0x14
	public ItemRotation r; //Field offset: 0x18

	public LocationInGrid() { }

	public LocationInGrid(int x, int y, ItemRotation r) { }

	public LocationInGrid Clone() { }

	private bool Equals(LocationInGrid other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(LocationInGrid from, LocationInGrid to) { }

	public static bool op_Inequality(LocationInGrid from, LocationInGrid to) { }

	public virtual string ToString() { }

}

