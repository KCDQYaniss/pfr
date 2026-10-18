namespace EFT;

public class ComparableHashSet`1
{
	public HashSet Set; //Field offset: 0x0
	private int _hash; //Field offset: 0x0

	public ComparableHashSet`1(IEnumerable values) { }

	private int CalculateHash(object[] fields) { }

	public bool Contains(T field) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public bool IsSupersetOf(IEnumerable other) { }

	public static bool op_Equality(ComparableHashSet set1, ComparableHashSet set2) { }

	public static bool op_Inequality(ComparableHashSet set1, ComparableHashSet set2) { }

}

