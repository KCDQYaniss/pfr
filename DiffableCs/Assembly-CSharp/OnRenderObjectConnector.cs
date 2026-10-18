//Type is in global namespace

public class OnRenderObjectConnector : MonoBehaviour
{
	[CompilerGenerated]
	private static Action OnRenderObjectConnectorAdd; //Field offset: 0x0
	[CompilerGenerated]
	private static Action OnRenderObjectConnectorRemove; //Field offset: 0x8

	public static event Action OnRenderObjectConnectorAdd
	{
		[CompilerGenerated]
		 add { } //Length: 293
		[CompilerGenerated]
		 remove { } //Length: 293
	}

	public static event Action OnRenderObjectConnectorRemove
	{
		[CompilerGenerated]
		 add { } //Length: 304
		[CompilerGenerated]
		 remove { } //Length: 304
	}

	public OnRenderObjectConnector() { }

	[CompilerGenerated]
	public static void add_OnRenderObjectConnectorAdd(Action value) { }

	[CompilerGenerated]
	public static void add_OnRenderObjectConnectorRemove(Action value) { }

	public override void ManualOnRenderObject(Camera currentCamera) { }

	protected override void OnDestroy() { }

	[CompilerGenerated]
	public static void remove_OnRenderObjectConnectorAdd(Action value) { }

	[CompilerGenerated]
	public static void remove_OnRenderObjectConnectorRemove(Action value) { }

	protected override void Start() { }

}

