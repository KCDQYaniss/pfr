namespace EFT.UI;

public sealed class DynamicScrollElement : UIElement
{
	[SerializeField]
	private CustomTextMeshProUGUI _one; //Field offset: 0x70
	[CompilerGenerated]
	private int <ScrollIndex>k__BackingField; //Field offset: 0x78

	public float Height
	{
		 get { } //Length: 9
	}

	public int ScrollIndex
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public RectTransform Transform
	{
		 get { } //Length: 141
	}

	public DynamicScrollElement() { }

	public float get_Height() { }

	[CompilerGenerated]
	public int get_ScrollIndex() { }

	public RectTransform get_Transform() { }

	public void Perform(int index) { }

	[CompilerGenerated]
	public void set_ScrollIndex(int value) { }

}

