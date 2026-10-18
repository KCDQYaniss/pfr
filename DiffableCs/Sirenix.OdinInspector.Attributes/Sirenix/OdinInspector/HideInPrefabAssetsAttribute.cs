namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767))]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
[EditorBrowsable(EditorBrowsableState::Never (1))]
[Obsolete("Use [HideIn(PrefabKind.PrefabAsset)] instead.", False)]
public class HideInPrefabAssetsAttribute : Attribute
{

	public HideInPrefabAssetsAttribute() { }

}

