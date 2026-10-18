namespace EFT.Visual;

public class ThermalVisionDevice : MonoBehaviour, IDress
{
	[SerializeField]
	private Light _light; //Field offset: 0x20
	private Action _subscription; //Field offset: 0x28
	private ThermalVisionComponent _thermalVision; //Field offset: 0x30

	public ThermalVisionDevice() { }

	[CompilerGenerated]
	private void <Init>b__3_0() { }

	public override void Deinit() { }

	public override void Init(Item item, bool isAnimated) { }

}

