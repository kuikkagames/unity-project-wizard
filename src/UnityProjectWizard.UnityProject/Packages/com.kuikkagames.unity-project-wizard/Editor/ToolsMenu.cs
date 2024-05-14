using UnityEditor;
using UnityEngine;
using static System.IO.Path;
using static UnityEditor.AssetDatabase;
using static UnityEngine.Application;
using static UnityEngine.Windows.Directory;

namespace KuikkaGames.UnityProjectWizard.Editor
{
    public static class ToolsMenu
    {
        [MenuItem("Tools/Setup/Create Default Folders")]
        public static void CreateDefaultFolders()
        {
            Debug.Log(dataPath);
            CreateDirectories("_Game", "Art", "Prefabs", "Scripts", "Scenes");
            Refresh();
        }

        private static void CreateDirectories(string root, params string[] dir)
        {
            var fullPath = Combine(dataPath, root);

            foreach (var newDirectory in dir)
            {
                CreateDirectory(Combine(fullPath, newDirectory));
            }
        }
    }
}
