using System;
using FortRise;
using MonoMod.ModInterop;
using TFModFortRiseLoaderAI;

namespace TFModFortRiseAiExample
{
  [Fort("com.ebe1.kenobi.TFModFortRiseAiExample", "TFModFortRiseAiExample")]
  public class TFModFortRiseAiExampleModule : FortModule
  {
    public static TFModFortRiseAiExampleModule Instance;

    public override Type SettingsType => typeof(TFModFortRiseAiExampleSettings);
    public static TFModFortRiseAiExampleSettings Settings => (TFModFortRiseAiExampleSettings)Instance.InternalSettings;

    public TFModFortRiseAiExampleModule()
    {
      Instance = this;
      Logger.Init("TFModFortRiseAiExampleLOG");
    }

    public override void LoadContent()
    {
    }

    public override void Load()
    {
      MyTFGame.Load();
      typeof(LoaderAIImport).ModInterop();
    }

    public override void Unload()
    {
      MyTFGame.Unload();
    }
  }

  [ModImportName("com.fortrise.TFModFortRiseLoaderAI")]
  public static class LoaderAIImport
  {
    public static Func<String, Agent[], bool> addAgent;
  }
}
