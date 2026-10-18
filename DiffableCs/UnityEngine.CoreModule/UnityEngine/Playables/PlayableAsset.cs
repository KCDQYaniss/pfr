namespace UnityEngine.Playables;

[AssetFileNameExtension("playable", new IL2CPP_TYPE_STRING[] {})]
[RequiredByNativeCode]
public abstract class PlayableAsset : ScriptableObject, IPlayableAsset
{

	public override double duration
	{
		 get { } //Length: 85
	}

	public override IEnumerable outputs
	{
		 get { } //Length: 83
	}

	protected PlayableAsset() { }

	public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	public override double get_duration() { }

	public override IEnumerable get_outputs() { }

	[RequiredByNativeCode]
	internal static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr) { }

	[RequiredByNativeCode]
	internal static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble) { }

}

