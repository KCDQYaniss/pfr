namespace Coffee.UISoftMask;

internal sealed class TmpProxy : GraphicProxy
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__UpdateMeshUI; //Field offset: 0x0

	}


	public TmpProxy() { }

	public virtual float GetAlpha(Graphic graphic) { }

	public virtual Texture GetMainTexture(Graphic graphic) { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void InitializeOnLoad() { }

	protected virtual bool IsValid(Graphic graphic) { }

	public virtual void SetMaterialDirty(Graphic graphic) { }

	private static void UpdateMeshUI(Object obj) { }

	private static void UpdateSubMeshUI(TextMeshProUGUI text, ISoftMasking parent) { }

}

