using UnityModManagerNet;

namespace CustomResolution {
    internal static class Main {
        internal static UnityModManager.ModEntry Mod;
        internal static bool IsEnabled { get; private set; }
        internal static MainSettings Settings { get; private set; }

        private static void Load(UnityModManager.ModEntry modEntry) {
            Mod = modEntry;
            Mod.OnToggle = OnToggle;
            Settings = UnityModManager.ModSettings.Load<MainSettings>(modEntry);
            Mod.OnGUI = OnGUI;
            Mod.OnSaveGUI = OnSaveGUI;
        }
        
        private static void OnGUI(UnityModManager.ModEntry modEntry) {
            Settings.Draw(modEntry);
        }

        private static void OnSaveGUI(UnityModManager.ModEntry modEntry) {
            Settings.Save(modEntry);
        }

        private static bool OnToggle(UnityModManager.ModEntry modEntry, bool value) {
            IsEnabled = value;

            if (value) Start();

            return true;
        }

        private static void Start() {
            Settings.Save(Mod);
        }
    }
}