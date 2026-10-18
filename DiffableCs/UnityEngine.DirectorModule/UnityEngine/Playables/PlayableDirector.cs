namespace UnityEngine.Playables;

[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[NativeHeader("Modules/Director/PlayableDirector.h")]
[RequiredByNativeCode]
public class PlayableDirector : Behaviour, IExposedPropertyTable
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action played; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action paused; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action stopped; //Field offset: 0x28

	public event Action stopped
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public double duration
	{
		 get { } //Length: 78
	}

	public DirectorWrapMode extrapolationMode
	{
		 get { } //Length: 78
	}

	public double initialTime
	{
		 set { } //Length: 94
	}

	public PlayableAsset playableAsset
	{
		 get { } //Length: 181
		 set { } //Length: 93
	}

	public PlayableGraph playableGraph
	{
		 get { } //Length: 117
	}

	public bool playOnAwake
	{
		 set { } //Length: 93
	}

	public PlayState state
	{
		 get { } //Length: 78
	}

	public double time
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public DirectorUpdateMode timeUpdateMode
	{
		 set { } //Length: 91
	}

	[CompilerGenerated]
	public void add_stopped(Action value) { }

	[NativeThrows]
	public void Evaluate() { }

	public double get_duration() { }

	public DirectorWrapMode get_extrapolationMode() { }

	public PlayableAsset get_playableAsset() { }

	public PlayableGraph get_playableGraph() { }

	public PlayState get_state() { }

	public double get_time() { }

	[NativeMethod("GetBindingFor")]
	public Object GetGenericBinding(Object key) { }

	private PlayableGraph GetGraphHandle() { }

	private void GetGraphHandle_Injected(out PlayableGraph ret) { }

	private PlayState GetPlayState() { }

	public override Object GetReferenceValue(PropertyName id, out bool idValid) { }

	private override Object GetReferenceValue_Injected(ref PropertyName id, out bool idValid) { }

	private DirectorWrapMode GetWrapMode() { }

	private ScriptableObject Internal_GetPlayableAsset() { }

	[NativeThrows]
	private void Internal_SetGenericBinding(Object key, Object value) { }

	public void Pause() { }

	[NativeThrows]
	public void Play() { }

	internal void Play(FrameRate frameRate) { }

	[NativeThrows]
	private void PlayOnFrame(FrameRate frameRate) { }

	private void PlayOnFrame_Injected(ref FrameRate frameRate) { }

	[NativeThrows]
	public void RebuildGraph() { }

	[CompilerGenerated]
	public void remove_stopped(Action value) { }

	[RequiredByNativeCode]
	private void SendOnPlayableDirectorPause() { }

	[RequiredByNativeCode]
	private void SendOnPlayableDirectorPlay() { }

	[RequiredByNativeCode]
	private void SendOnPlayableDirectorStop() { }

	public void set_initialTime(double value) { }

	public void set_playableAsset(PlayableAsset value) { }

	public void set_playOnAwake(bool value) { }

	public void set_time(double value) { }

	public void set_timeUpdateMode(DirectorUpdateMode value) { }

	public void SetGenericBinding(Object key, Object value) { }

	private void SetPlayableAsset(ScriptableObject asset) { }

	private void SetPlayOnAwake(bool on) { }

	public void Stop() { }

}

