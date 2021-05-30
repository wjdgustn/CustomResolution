using UnityEngine;
using UnityModManagerNet;

namespace CustomResolution {
    public class MainSettings : UnityModManager.ModSettings, IDrawable {
        [Draw("가로(Width)")] public int ScreenWidth = 1920;
        [Draw("세로(Height)")] public int ScreenHeight = 1080;
        [Draw("전체화면(Fullscreen)")] public bool Fullscreen = true;

        public override void Save(UnityModManager.ModEntry modEntry) {
            Screen.SetResolution(ScreenWidth, ScreenHeight, Fullscreen);
            
            Save(this, modEntry);
        }
        
        public void OnChange() {
            
        }
    }
}