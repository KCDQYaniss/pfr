namespace EFT;

[ExecuteInEditMode]
public class StaticManager : MonoBehaviour
{
	private static StaticManager _instance; //Field offset: 0x0
	private static bool _isInitialized; //Field offset: 0x8
	[CompilerGenerated]
	private Action StaticUpdate; //Field offset: 0x20
	public TimerManager TimerManager; //Field offset: 0x28

	public event Action StaticUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public static StaticManager Instance
	{
		 get { } //Length: 895
	}

	public StaticManager() { }

	[CompilerGenerated]
	public void add_StaticUpdate(Action value) { }

	private void Awake() { }

	public static Coroutine BeginCoroutine(IEnumerator routine) { }

	public static StaticManager get_Instance() { }

	public static void KillCoroutine(Coroutine routine) { }

	public static void KillCoroutine(ref Coroutine routine) { }

	private void OnDestroy() { }

	[CompilerGenerated]
	public void remove_StaticUpdate(Action value) { }

	private void Update() { }

}

