using System;
using FortRise;
using MonoMod.ModInterop;

namespace TFModFortRiseAiExample
{
  [Fort("com.ebe1.kenobi.TFModFortRiseAiExample", "TFModFortRiseAiExample")]
  public class TFModFortRiseAiExampleModule : FortModule
  {
    public static TFModFortRiseAiExampleModule Instance;
    public static bool EightPlayerMod;
    public static bool PlayTagMod;

    public override Type SettingsType => typeof(TFModFortRiseAiExampleSettings);
    public static TFModFortRiseAiExampleSettings Settings => (TFModFortRiseAiExampleSettings)Instance.InternalSettings;

    public TFModFortRiseAiExampleModule()
    {
      Instance = this;
      //Logger.Init("TFModFortRiseAiExampleLOG");
    }

    public override void LoadContent()
    {
    }

    public override void Load()
    {
      MyTFGame.Load();
      typeof(LoaderAIImport).ModInterop();
      EightPlayerMod = IsModExists("WiderSetMod");
      PlayTagMod = IsModExists("PlayTag");
    }

    public override void Unload()
    {
      MyTFGame.Unload();
    }
  }
}
