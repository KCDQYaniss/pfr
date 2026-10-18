namespace UnityEngine.ProBuilder;

internal struct Triangle : IEquatable
{
	[SerializeField]
	private int m_A; //Field offset: 0x0
	[SerializeField]
	private int m_B; //Field offset: 0x4
	[SerializeField]
	private int m_C; //Field offset: 0x8

	public int a
	{
		 get { } //Length: 3
	}

	public int b
	{
		 get { } //Length: 4
	}

	public int c
	{
		 get { } //Length: 4
	}

	public IEnumerable indices
	{
		 get { } //Length: 116
	}

	public Triangle(int a, int b, int c) { }

	private bool ContainsEdge(Edge edge) { }

	public override bool Equals(Triangle other) { }

	public virtual bool Equals(object obj) { }

	public int get_a() { }

	public int get_b() { }

	public int get_c() { }

	public IEnumerable get_indices() { }

	public virtual int GetHashCode() { }

	public bool IsAdjacent(Triangle other) { }

}

