using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

namespace RFG
{
  public class PlatformerEditorWindow : EditorWindow
  {
    [MenuItem("RFG/Platformer Editor Window")]
    public static void ShowWindow()
    {
      GetWindow<PlatformerEditorWindow>("PlatformerEditorWindow");
    }

    public virtual void CreateGUI()
    {
      VisualElement root = rootVisualElement;

      VisualTreeAsset visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/RFG/Platformer/Editor/PlatformerEditor/PlatformerEditorWindow.uxml");
      visualTree.CloneTree(root);

      StyleSheet styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>("Assets/RFG/Platformer/Editor/PlatformerEditor/PlatformerEditorWindow.uss");
      root.styleSheets.Add(styleSheet);

      VisualElement mainContainer = root.Q<VisualElement>("container");

      mainContainer.Add(CreateManager());
    }

    private VisualElement CreateManager()
    {
      VisualElement platformerManager = CreateContainer("platformer-manager");

      VisualElement platformerManagerButtons = platformerManager.Q<VisualElement>("platformer-manager-buttons");

      Button addTagsButton = new Button(() =>
      {
        EditorUtils.AddTags(new string[] { "Player" });
      })
      {
        name = "tags-button",
        text = "Add Platformer Tags"
      };

      Button addLayersButton = new Button(() =>
      {
        EditorUtils.AddLayers(new string[] { "Player", "Platforms", "OneWayPlatforms", "MovingPlatforms", "OneWayMovingPlatforms", "Stairs" });
      })
      {
        name = "layers-button",
        text = "Add Platformer Layers"
      };

      platformerManagerButtons.Add(addTagsButton);
      platformerManagerButtons.Add(addLayersButton);

      return platformerManager;
    }

    protected VisualElement CreateContainer(string name)
    {
      VisualElement container = new VisualElement();
      container.name = name;
      container.AddToClassList("container");

      Label label = new Label();
      label.name = $"{name}-label";
      label.AddToClassList("container-label");

      VisualElement buttons = new VisualElement();
      buttons.name = $"{name}-buttons";
      buttons.AddToClassList("buttons");

      container.Add(label);
      container.Add(buttons);

      return container;
    }

  }
}