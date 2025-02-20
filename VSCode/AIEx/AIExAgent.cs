using TowerFall;
using System;

namespace TFModFortRiseAiExample
{
  public class AIExAgent : TFModFortRiseLoaderAI.Agent
  {

    public AIExAgent(int index, String type, PlayerInput input) : base(index, type, input)
    {
    }

    protected override void Move()
    {
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
