using TowerFall;
using System;

namespace TFModFortRiseAiExample
{
  public class NAIAgent : TFModFortRiseLoaderAI.Agent
  {

    public NAIAgent(int index, String type, PlayerInput input) : base(index, type, input)
    {
    }

    public override void Play()
    {
      if (level.Paused) return;
      if (level.Frozen) return;
      if (level.Ending) return;

      this.input.inputState = new InputState();
      this.input.inputState.AimAxis.X = 0;
      this.input.inputState.MoveX = 0;
      this.input.inputState.AimAxis.Y = 0;
      this.input.inputState.MoveY = 0;

      if (shoot.Count == 0 && 0 == random.Next(0, 19))
      //if (0 == random.Next(0, 19))
      {
        this.input.inputState.JumpCheck = true;
        this.input.inputState.JumpPressed = !this.input.prevInputState.JumpCheck;
      }

      this.input.prevInputState = this.input.GetCopy(this.input.inputState);

    }
  }
}
