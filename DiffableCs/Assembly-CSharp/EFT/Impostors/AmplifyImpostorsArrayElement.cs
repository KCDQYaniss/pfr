namespace EFT.Impostors;

[DisallowMultipleComponent]
[ExecuteInEditMode]
[RequireComponent(typeof(TreeWind))]
public sealed class AmplifyImpostorsArrayElement : MonoBehaviour
{
	[CompilerGenerated]
	private static Action AddedEvent; //Field offset: 0x0
	[CompilerGenerated]
	private static Action RemovedEvent; //Field offset: 0x8
	[CompilerGenerated]
	private static Action EnableChangedEvent; //Field offset: 0x10
	private TreeWind _treeWind; //Field offset: 0x20
	public uint TypeId; //Field offset: 0x28

	public static event Action AddedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 293
		[CompilerGenerated]
		 remove { } //Length: 293
	}

	public static event Action EnableChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 304
		[CompilerGenerated]
		 remove { } //Length: 304
	}

	public static event Action RemovedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 304
		[CompilerGenerated]
		 remove { } //Length: 304
	}

	public ImpostorWind ImpostorWind
	{
		 get { } //Length: 575
	}

	public AmplifyImpostorsArrayElement() { }

	[CompilerGenerated]
	public static void add_AddedEvent(Action value) { }

	[CompilerGenerated]
	public static void add_EnableChangedEvent(Action value) { }

	[CompilerGenerated]
	public static void add_RemovedEvent(Action value) { }

	private void Awake() { }

	public static bool FilterTreeImposter(Renderer renderer) { }

	public ImpostorWind get_ImpostorWind() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	[CompilerGenerated]
	public static void remove_AddedEvent(Action value) { }

	[CompilerGenerated]
	public static void remove_EnableChangedEvent(Action value) { }

	[CompilerGenerated]
	public static void remove_RemovedEvent(Action value) { }

}

