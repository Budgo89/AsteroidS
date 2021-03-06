namespace AsteroidS
{
    class GameInitializer
    {
        public GameInitializer(ControllersProxy controllers, GameData gameData)
        {
            var inputInitialiser = new InputInitializer();
            var playerInitializer = new PlayerInitializer(gameData);

            controllers.Add(new InputController(inputInitialiser.GetInput()));
            controllers.Add(new PlayerMovementController(gameData, playerInitializer.Player, inputInitialiser.GetInput()));
        }
    }
}
