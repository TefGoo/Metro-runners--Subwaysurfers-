using UnityEngine;

namespace Beamable.Editor.ToolbarExtender
{
	/// <summary>
	/// Scriptable object that gets loaded from <see cref="CoreConfiguration.BeamableAssistantMenuItemsPath"/>s when the <see cref="BeamableToolbarExtender"/> initializes
	/// or one of these is re-imported.
	///
	/// <para/>
	///
	/// These can be used to add items to our Beamable Assistant button that lives in our <see cref="BeamableToolbarExtender"/>. 
	/// </summary>
	public abstract class BeamableAssistantMenuItem : ScriptableObject
	{
		/// <summary>
		/// A sorting value to position this menu item.
		/// </summary>
		public int Order;

		/// <summary>
		/// The text for the menu item. This follows the same rules as <see cref="UnityEditor.GenericMenu"/>'s menu items.
		/// </summary>
		public string Text;

		public virtual GUIContent RenderLabel(BeamEditorContext beamableApi) => new GUIContent(Text);

		/// <summary>
		/// Called when the Menu item generated by this <see cref="BeamableAssistantMenuItem"/> is clicked.
		/// </summary>
		public abstract void OnItemClicked(BeamEditorContext beamableApi);

		protected internal const int BeamableMenuItemScriptableObjectCreationOrder = 9999;
	}
}
