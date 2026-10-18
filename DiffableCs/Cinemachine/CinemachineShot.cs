//Type is in global namespace

public sealed class CinemachineShot : PlayableAsset, IPropertyPreview
{
	public string DisplayName; //Field offset: 0x18
	public ExposedReference VirtualCamera; //Field offset: 0x20

	public CinemachineShot() { }

	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

}

