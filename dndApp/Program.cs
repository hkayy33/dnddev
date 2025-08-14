
class Program
{
    static void Main(string[] args)
    {
        //onsole.WriteLine("_______welcome to the Dungeons and Dragons Simulator______");
        // var gameLobby = new GameLobby();
        // gameLobby.Start();
        // gameLobby.GetTeamNames();

        var lobby = new GameLobby();
lobby.GetTeamNames();

var game = new Game(lobby.GetTeamA(), lobby.GetTeamB());
game.GameRun();



        // //Health and attack values
        // var warrior = new Warrior();
        // warrior.setDefaultAttackValues();
        // warrior.initialiseCharacterHealth();

        // var wizard = new Wizard();
        // wizard.initialiseCharacterHealth();
        // wizard.setDefaultAttackValues();
    }
}


