namespace Dissonance;

public class SemanticVersion : IComparable, IEquatable
{
	[SerializeField]
	private int _major; //Field offset: 0x10
	[SerializeField]
	private int _minor; //Field offset: 0x14
	[SerializeField]
	private int _patch; //Field offset: 0x18
	[SerializeField]
	private string _tag; //Field offset: 0x20

	public int Major
	{
		 get { } //Length: 164
	}

	public int Minor
	{
		 get { } //Length: 4
	}

	public int Patch
	{
		 get { } //Length: 4
	}

	public string Tag
	{
		 get { } //Length: 5
	}

	public SemanticVersion() { }

	public SemanticVersion(int major, int minor, int patch, string tag = null) { }

	public override int CompareTo(SemanticVersion other) { }

	public override bool Equals(SemanticVersion other) { }

	public virtual bool Equals(object obj) { }

	public int get_Major() { }

	public int get_Minor() { }

	public int get_Patch() { }

	public string get_Tag() { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

}

