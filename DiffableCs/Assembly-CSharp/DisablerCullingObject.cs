//Type is in global namespace

[ExecuteInEditMode]
public class DisablerCullingObject : DisablerCullingObjectBase
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Comparison <0>__Comparison; //Field offset: 0x0

	}

	internal class ComponentState
	{
		public Component component; //Field offset: 0x10
		public bool isEnabled; //Field offset: 0x18

		public ComponentState() { }

	}

	private static Dictionary _cachedComponents; //Field offset: 0x0
	private static Type[] _sortOrder; //Field offset: 0x8
	private static Dictionary _boundsCacheTemp; //Field offset: 0x10
	[SerializeField]
	protected List _componentsToTurnOff; //Field offset: 0x58
	[SerializeField]
	protected List _compsToTurnOffWhoIgnoreInversedColliders; //Field offset: 0x60
	[HideInInspector]
	[SerializeField]
	private List _componentsToTurnOffDefaultState; //Field offset: 0x68
	[SerializeField]
	protected List _gameObjectsToTurnOff; //Field offset: 0x70
	[SerializeField]
	protected Bounds _componentsBounds; //Field offset: 0x78
	[SerializeField]
	public bool AllowLootCulling; //Field offset: 0x90
	[Header("Performance:")]
	[SerializeField]
	private int _componentsSwitchPerFrameOnEnable; //Field offset: 0x94
	[SerializeField]
	private int _objectsSwitchPerFrameOnEnable; //Field offset: 0x98
	[SerializeField]
	private int _componentsSwitchPerFrameOnDisable; //Field offset: 0x9C
	[SerializeField]
	private int _objectsSwitchPerFrameOnDisable; //Field offset: 0xA0
	[HideInInspector]
	public bool ExcludeLowPolyColliderLayer; //Field offset: 0xA4
	[HideInInspector]
	public bool ExcludeDefaultLayerWithCollider; //Field offset: 0xA5
	[HideInInspector]
	public bool ExcludeBallisticCollider; //Field offset: 0xA6
	[HideInInspector]
	public bool IncludeInactive; //Field offset: 0xA7
	[Header("View:")]
	public Color GizmosColor; //Field offset: 0xA8
	public Color GizmosInverseColor; //Field offset: 0xB8
	[SerializeField]
	private Color _unselectedGizmosColor; //Field offset: 0xC8
	private Stopwatch _stopwatch; //Field offset: 0xD8
	private IEnumerator _setComponentsEnabledWorker; //Field offset: 0xE0
	private IEnumerator _setComponentsEnabledWorker2; //Field offset: 0xE8
	private bool _lockState; //Field offset: 0xF0

	public int ComponentsSwitchPerFrameOnDisable
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public int ComponentsSwitchPerFrameOnEnable
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public List ComponentsToTurnOff
	{
		 get { } //Length: 5
	}

	private static DisablerCullingObject() { }

	public DisablerCullingObject() { }

	private void CalculateComponentsBounds() { }

	private static int Comparison(Component x, Component y) { }

	public void ForceEnable(bool value) { }

	public void ForceUpdate() { }

	public int get_ComponentsSwitchPerFrameOnDisable() { }

	public int get_ComponentsSwitchPerFrameOnEnable() { }

	public List get_ComponentsToTurnOff() { }

	public Bounds GetBounds() { }

	private static int GetComponentSortIndex(Component component) { }

	public void LockState(bool value) { }

	public virtual void ManualUpdate(float dt) { }

	public override void NullClean() { }

	public static void NullClean(List componentsToTurnOff, List gameObjectsToTurnOff) { }

	protected virtual void OnDestroy() { }

	public virtual void PrepareCullingObject() { }

	public void RegisterComponents(IEnumerable components, bool ignoreInverseColliders = false) { }

	public void set_ComponentsSwitchPerFrameOnDisable(int value) { }

	public void set_ComponentsSwitchPerFrameOnEnable(int value) { }

	protected virtual void SetComponentsEnabled(bool isVisible) { }

	public static void SortComponentsToTurnOff(List componentsToTurnOff, Dictionary cache = null) { }

	public void SortComponentsToTurnOff() { }

	public void UnregisterComponents(IEnumerable components, bool ignoreInverseColliders = false) { }

}

