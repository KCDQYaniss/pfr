namespace UnityEngine.UIElements;

public class UxmlEnumeration : UxmlTypeRestriction
{
	private List m_Values; //Field offset: 0x10

	public IEnumerable values
	{
		 get { } //Length: 7
		 set { } //Length: 274
	}

	public UxmlEnumeration() { }

	public virtual bool Equals(UxmlTypeRestriction other) { }

	public IEnumerable get_values() { }

	public void set_values(IEnumerable value) { }

}

