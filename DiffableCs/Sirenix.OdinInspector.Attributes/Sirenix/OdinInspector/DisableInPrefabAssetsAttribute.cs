namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767))]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
[EditorBrowsable(EditorBrowsableState::Never (1))]
[Obsolete("Use [DisableIn(PrefabKind.PrefabAsset)] instead.", False)]
public class DisableInPrefabAssetsAttribute : Attribute
{

	public DisableInPrefabAssetsAttribute() { }

}

