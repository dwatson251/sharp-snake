namespace Engine;

class Runner
{
    private readonly SnakeGameBackendInterface game;
    private readonly UserInputInterface input;
    private readonly DisplayOutputInterface output;
    private readonly int framesPerSecond = 30;

    public Runner(
       SnakeGameBackendInterface game,
       UserInputInterface input,
       DisplayOutputInterface output
   )
    {
        this.game = game;
        this.input = input;
        this.output = output;
    }

    public void Run()
    {
        while (!_game.IsGameOver)
        {
            var direction = _input.GetNextDirection();
            _game.Update(direction);
            _output.Render(_game.GetState());
            Thread.Sleep(_frameRate);
        }

        Console.WriteLine("Game Over!");
    }
}