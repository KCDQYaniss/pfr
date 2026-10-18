namespace UnityEngine;

[UsedByNativeCode]
public sealed class TreePrototype
{
	internal GameObject m_Prefab; //Field offset: 0x10
	internal float m_BendFactor; //Field offset: 0x18
	internal int m_NavMeshLod; //Field offset: 0x1C

	public float bendFactor
	{
		 get { } //Length: 8
	}

	public int navMeshLod
	{
		 get { } //Length: 6
	}

	public GameObject prefab
	{
		 get { } //Length: 7
	}

	public TreePrototype() { }

	public virtual bool Equals(object obj) { }

	private bool Equals(TreePrototype other) { }

	public float get_bendFactor() { }

	public int get_navMeshLod() { }

	public GameObject get_prefab() { }

	public virtual int GetHashCode() { }

}

