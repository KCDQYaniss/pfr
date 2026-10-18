namespace UnityEngine.UIElements;

public interface ICustomStyle
{

	public bool TryGetValue(CustomStyleProperty property, out float value) { }

	public bool TryGetValue(CustomStyleProperty property, out int value) { }

	public bool TryGetValue(CustomStyleProperty property, out Color value) { }

	public bool TryGetValue(CustomStyleProperty property, out Texture2D value) { }

	public bool TryGetValue(CustomStyleProperty property, out Sprite value) { }

	public bool TryGetValue(CustomStyleProperty property, out VectorImage value) { }

	public bool TryGetValue(CustomStyleProperty property, out string value) { }

}

