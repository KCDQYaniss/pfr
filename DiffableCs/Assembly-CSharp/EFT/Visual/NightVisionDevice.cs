namespace EFT.Visual;

public class NightVisionDevice : MonoBehaviour, IDress
{
	[SerializeField]
	private Light _light; //Field offset: 0x20
	private Action _subscription; //Field offset: 0x28
	private NightVisionComponent _nightVision; //Field offset: 0x30

	public NightVisionDevice() { }

	[CompilerGenerated]
	private void <Init>b__3_0() { }

	public override void Deinit() { }

	public override void Init(Item item, bool isAnimated) { }

}

