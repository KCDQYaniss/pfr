namespace EFT.UI;

public sealed class BodyPartImage : UIElement
{
	private const float BODY_PART_SATURATION = 0.5; //Field offset: 0x0
	[SerializeField]
	private Image _bodyPartImage; //Field offset: 0x70
	private IHealthController _healthController; //Field offset: 0x78
	private EBodyPart _bodyPart; //Field offset: 0x80
	private float _healthPercent; //Field offset: 0x84
	private bool _isBroken; //Field offset: 0x88
	private EHealthColorScheme _colorScheme; //Field offset: 0x8C

	public BodyPartImage() { }

	[CompilerGenerated]
	private void <Show>b__7_0() { }

	private void OnBodyPartDestroyed(EBodyPart bodyPart, EDamageType damageType) { }

	private void OnBodyPartRestored(EBodyPart bodyPart, ValueStruct valueStruct) { }

	private void OnHealthChanged(EBodyPart bodyPart, float diff, DamageInfo damageInfo) { }

	public void Show(IHealthController healthController, EBodyPart bodyPart) { }

	private void UpdateVisual() { }

}

