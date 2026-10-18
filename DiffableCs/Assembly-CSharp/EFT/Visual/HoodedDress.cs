namespace EFT.Visual;

public sealed class HoodedDress : MonoBehaviour
{
	[SerializeField]
	private GameObject[] _hooded; //Field offset: 0x20
	[SerializeField]
	private GameObject[] _notHooded; //Field offset: 0x28
	[CompilerGenerated]
	private bool <IsHooded>k__BackingField; //Field offset: 0x30

	public private bool IsHooded
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public HoodedDress() { }

	[CompilerGenerated]
	public bool get_IsHooded() { }

	[CompilerGenerated]
	private void set_IsHooded(bool value) { }

	public void SetHooded(bool hooded) { }

}

