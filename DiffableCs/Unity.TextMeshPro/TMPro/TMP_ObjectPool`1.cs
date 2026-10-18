namespace TMPro;

internal class TMP_ObjectPool`1
{
	private readonly Stack m_Stack; //Field offset: 0x0
	private readonly UnityAction m_ActionOnGet; //Field offset: 0x0
	private readonly UnityAction m_ActionOnRelease; //Field offset: 0x0
	[CompilerGenerated]
	private int <countAll>k__BackingField; //Field offset: 0x0

	public int countActive
	{
		 get { } //Length: 29
	}

	public private int countAll
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public int countInactive
	{
		 get { } //Length: 26
	}

	public TMP_ObjectPool`1(UnityAction actionOnGet, UnityAction actionOnRelease) { }

	public T Get() { }

	public int get_countActive() { }

	[CompilerGenerated]
	public int get_countAll() { }

	public int get_countInactive() { }

	public void Release(T element) { }

	[CompilerGenerated]
	private void set_countAll(int value) { }

}

