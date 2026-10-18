namespace EFT.UI.Health;

public class DamagePanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__7_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Show>b__7_0(BodyPartDamageList dmg, DamageIcon view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public IHealthController healthController; //Field offset: 0x10
		public DamagePanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal void <Show>b__1() { }

	}

	private sealed class BodyPartDamageList : List
	{
		public readonly EDamageResult ResultType; //Field offset: 0x28

		public BodyPartDamageList(EDamageResult resultType) { }

	}

	[SerializeField]
	private DamageIcon _damageIconTemplate; //Field offset: 0x70
	private BindableList _bindableDamages; //Field offset: 0x78
	private IHealthController _healthController; //Field offset: 0x80
	private EBodyPart _bodyPart; //Field offset: 0x88

	private bool HealthIsAtMaximum
	{
		private get { } //Length: 188
	}

	public DamagePanel() { }

	private void CleanUp() { }

	private BodyPartDamageList CreateDamageList(EDamageResult resultType, List damageHistory) { }

	private bool get_HealthIsAtMaximum() { }

	private void OnHealthChanged(EBodyPart bodyPart, float diff, DamageInfo damageInfo) { }

	public void Show(IHealthController healthController, EBodyPart bodyPart, DamageHistory damage) { }

}

