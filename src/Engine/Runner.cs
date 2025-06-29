namespace Engine
{
    using Application.Service;
    using Domain.Service;

    class Runner
    {
        private readonly IBackend _game;
        private readonly EventBus _eventBus;
        private readonly IUserInput _input;
        private readonly IDisplayOutput _output;
        private readonly int framesPerSecond = 30;

        public Runner(
            EventBus eventBus
        // IBackend game,
        // IUserInput input,
        // IDisplayOutput output
        )
        {
            _eventBus = eventBus;
            // _game = game;
            // _input = input;
            // _output = output;
        }

        public void Run()
        {
            
        }
    }
}