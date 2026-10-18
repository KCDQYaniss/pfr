namespace EFT.UI;

public sealed class HealingLimbSelector : UIInputNode
{
	private struct LimpViewKVP
	{
		public EBodyPart Key; //Field offset: 0x0
		public HealingLimbView View; //Field offset: 0x8

	}

	private static readonly Type[] _medKitValidEffectTypes; //Field offset: 0x0
	[SerializeField]
	private LimpViewKVP[] _views; //Field offset: 0x80
	[SerializeField]
	private GameObject _cancelView; //Field offset: 0x88
	[SerializeField]
	private Image _cancelBackground; //Field offset: 0x90
	[SerializeField]
	private Vector2 _quickUseButtonOffset; //Field offset: 0x98
	[SerializeField]
	private Color _normalElementColor; //Field offset: 0xA0
	[SerializeField]
	private Color _selectedElementColor; //Field offset: 0xB0
	private int _index; //Field offset: 0xC0
	private int _modalCount; //Field offset: 0xC4
	private SimpleTooltip _tooltip; //Field offset: 0xC8
	private TaskCompletionSource _taskSource; //Field offset: 0xD0
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"bodyPart", "view"})]
	private readonly List _activeBodyPartViews; //Field offset: 0xD8

	public bool IsActive
	{
		 get { } //Length: 12
	}

	private static HealingLimbSelector() { }

	public HealingLimbSelector() { }

	[CompilerGenerated]
	internal static bool <TryGetLimbsToHealByItem>g__IsValidEffect|16_0(Type effectType) { }

	public virtual void Close() { }

	public bool get_IsActive() { }

	private Color GetElementColor(bool selected) { }

	[CanBeNull]
	public Nullable GetSelectedLimb() { }

	private void SelectNext() { }

	private void SelectPrev() { }

	private void SetIndex(int value) { }

	private void SetResult(Nullable result) { }

	private void SetSelection(int index, bool isSelected) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public Task Show(Item item, IHealthController healthController, List bodyParts, Vector2 sourcePosition, DamageHistory damageHistory = null) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	public static bool TryGetLimbsToHealByItem(Item item, IHealthController healthController, out List result) { }

}

