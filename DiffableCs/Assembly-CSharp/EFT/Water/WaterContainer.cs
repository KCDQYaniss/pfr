namespace EFT.Water;

[ExecuteInEditMode]
[ScriptOrder(20001)]
public class WaterContainer : MonoBehaviour
{
	[CompilerGenerated]
	private static Action OnAdd; //Field offset: 0x0
	[CompilerGenerated]
	private static Action OnRemove; //Field offset: 0x8
	[SerializeField]
	private WaterSettings _settings; //Field offset: 0x20
	[SerializeField]
	[Space(5)]
	private List _targets; //Field offset: 0x28
	private MaterialPropertyBlock _block; //Field offset: 0x30

	public static event Action OnAdd
	{
		[CompilerGenerated]
		 add { } //Length: 293
		[CompilerGenerated]
		 remove { } //Length: 293
	}

	public static event Action OnRemove
	{
		[CompilerGenerated]
		 add { } //Length: 304
		[CompilerGenerated]
		 remove { } //Length: 304
	}

	public MaterialPropertyBlock Block
	{
		 get { } //Length: 371
	}

	public IReadOnlyList Targets
	{
		 get { } //Length: 5
	}

	public WaterContainer() { }

	[CompilerGenerated]
	public static void add_OnAdd(Action value) { }

	[CompilerGenerated]
	public static void add_OnRemove(Action value) { }

	private void Awake() { }

	public MaterialPropertyBlock get_Block() { }

	public IReadOnlyList get_Targets() { }

	private MaterialPropertyBlock GetSettingsBlock() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnValidate() { }

	[CompilerGenerated]
	public static void remove_OnAdd(Action value) { }

	[CompilerGenerated]
	public static void remove_OnRemove(Action value) { }

}

