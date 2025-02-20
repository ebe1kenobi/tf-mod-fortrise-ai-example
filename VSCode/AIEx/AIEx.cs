using TFModFortRiseLoaderAI;
using TowerFall;

namespace TFModFortRiseAiExample
{
  internal class AIEx
  {
    public const string AINAME = "AIEx";
    public static bool isAgentReady = false;
    private static AIExAgent[] agents;// = new NAIAgent[8];
    public static PlayerInput[] AgentInputs;// = new PlayerInput[8];

    public static void CreateAgent()
    {
      if (isAgentReady) return;
      //detect first player slot free
      int max = TFModFortRiseAiExampleModule.EightPlayerMod ? 8 : 4;
      agents = new AIExAgent[max];
      AgentInputs = new PlayerInput[max];

      for (int i = 0; i < max; i++)
      {
        // create an agent for each player
        AgentInputs[i] = new TFModFortRiseLoaderAI.Input(i);
        agents[i] = new AIExAgent(i, AINAME, AgentInputs[i]);
        //Logger.Info("Agent " + AINAME  + " " + i + " Created");
        //if (null != TFGame.PlayerInputs[i]) continue;
      }

      isAgentReady = true;
      LoaderAIImport.addAgent(AINAME, agents);
    }
  }
}
