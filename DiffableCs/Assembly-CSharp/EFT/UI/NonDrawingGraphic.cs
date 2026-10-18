namespace EFT.UI;

[RequireComponent(typeof(CanvasRenderer))]
public sealed class NonDrawingGraphic : Graphic
{

	public NonDrawingGraphic() { }

	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	public virtual void SetMaterialDirty() { }

	public virtual void SetVerticesDirty() { }

}

