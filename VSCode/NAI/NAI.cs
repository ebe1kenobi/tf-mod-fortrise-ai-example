using TowerFall;

namespace TFModFortRiseAiExample
{
  internal class NAI
  {
    public static bool isAgentReady = false;
    private static NAIAgent[] agents = new NAIAgent[8];
    public static PlayerInput[] AgentInputs = new PlayerInput[8];

    public static void CreateAgent()
    {
      if (isAgentReady) return;
      //detect first player slot free
      for (int i = 0; i < TFGame.Players.Length; i++)
      {
        // create an agent for each player
        AgentInputs[i] = new TFModFortRiseLoaderAI.Input(i);
        agents[i] = new NAIAgent(i, "NAI", AgentInputs[i]);
        Logger.Info("Agent " + i + " Created");
        if (null != TFGame.PlayerInputs[i]) continue;
      }

      isAgentReady = true;
      LoaderAIImport.addAgent("NAI", agents);
    }
  }
}
