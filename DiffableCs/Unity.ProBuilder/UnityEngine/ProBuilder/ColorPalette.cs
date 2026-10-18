namespace UnityEngine.ProBuilder;

[DefaultMember("Item")]
internal sealed class ColorPalette : ScriptableObject, IHasDefault
{
	[CompilerGenerated]
	private Color <current>k__BackingField; //Field offset: 0x18
	[FormerlySerializedAs("colors")]
	[SerializeField]
	private List m_Colors; //Field offset: 0x28

	public ReadOnlyCollection colors
	{
		 get { } //Length: 182
	}

	public int Count
	{
		 get { } //Length: 65
	}

	public Color current
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Color Item
	{
		 get { } //Length: 137
		 set { } //Length: 137
	}

	public ColorPalette() { }

	public ReadOnlyCollection get_colors() { }

	public int get_Count() { }

	[CompilerGenerated]
	public Color get_current() { }

	public Color get_Item(int i) { }

	[CompilerGenerated]
	public void set_current(Color value) { }

	public void set_Item(int i, Color value) { }

	public void SetColors(IEnumerable colors) { }

	public override void SetDefaultValues() { }

}

