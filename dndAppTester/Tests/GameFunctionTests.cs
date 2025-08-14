using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit.Framework;



public class GameFunctionTests
{
    // A list of team players 
    private TeamGenerator teamgenerator;
    private Warrior warrior;
    private Cleric cleric;
    private Wizard wizard;
    private Game game;
     private StringWriter _consoleOutput;
    private TextWriter _originalOutput;


    [SetUp]
    public void setup()
    {
        warrior = new Warrior();
        cleric = new Cleric();
        wizard = new Wizard();
        game = new Game(new TeamGenerator("A"), new TeamGenerator("B"));
         _consoleOutput = new StringWriter();
        _originalOutput = Console.Out;
        Console.SetOut(_consoleOutput);


    }

    // Team Creation
    [Test]
    public void Check_If_Three_Characters_Are_Stored_In_A_List()
    {
        teamgenerator = new TeamGenerator("tester");
        Assert.That(teamgenerator.TeamChoice, Is.EqualTo(3));
    }


    // Character initialisation

    //warrior
    [Test]
    public void Check_that_Random_health_value_is_generated_between_1_and_15_for_Warrior()
    {
        Assert.That(warrior.initialiseCharacterHealth, Is.GreaterThanOrEqualTo(1));
        Assert.That(warrior.initialiseCharacterHealth, Is.LessThanOrEqualTo(15));
    }
    [Test]
    public void Check_that_Random_Attack_value_is_generated_between_1_and_10_for_Warrior()
    {
        Assert.That(warrior.setDefaultAttackValues, Is.GreaterThanOrEqualTo(1));
        Assert.That(warrior.setDefaultAttackValues, Is.LessThanOrEqualTo(10));
    }

    // Cleric
    [Test]
    public void Check_that_Random_health_value_is_generated_between_1_and_10_for_Cleric()
    {
        Assert.That(cleric.initialiseCharacterHealth, Is.GreaterThanOrEqualTo(1));
        Assert.That(cleric.initialiseCharacterHealth, Is.LessThanOrEqualTo(10));
    }
    [Test]
    public void Check_that_Random_Attack_value_is_generated_between_1_and_10_for_Cleric()
    {
        Assert.That(cleric.setDefaultAttackValues, Is.GreaterThanOrEqualTo(1));
        Assert.That(cleric.setDefaultAttackValues, Is.LessThanOrEqualTo(10));
    }

    // Wizard
    [Test]
    public void Check_that_Random_health_value_is_generated_between_1_and_10_for_Wizard()
    {
        Assert.That(wizard.initialiseCharacterHealth, Is.GreaterThanOrEqualTo(1));
        Assert.That(wizard.initialiseCharacterHealth, Is.LessThanOrEqualTo(10));
    }
    [Test]
    public void Check_that_Random_Attack_value_is_generated_between_1_and_10_for_Wizard()
    {
        Assert.That(wizard.setDefaultAttackValues, Is.GreaterThanOrEqualTo(1));
        Assert.That(wizard.setDefaultAttackValues, Is.LessThanOrEqualTo(20));
    }

    [Test]
    public void BattleRound_Should_End_When_Fighter_Dies()
    {

        (int remainingA, int remainingB) = game.BattleRound(warrior, wizard);

        Assert.That(remainingA <= 0 || remainingB <= 0);
    }

    [Test]
    public void BattleRound_Should_Reduce_At_Least_One_Fighters_Health()
    {
        int initialHealthA = warrior.DefaultHealth;
        int initialHealthB = wizard.DefaultHealth;

        (int remainingA, int remainingB) = game.BattleRound(warrior, wizard);

        Assert.That(remainingA < initialHealthA || remainingB < initialHealthB);

    }

    [Test]
    public void Check_That_BattleRound_Should_End_With_At_Least_One_Fighter_Dead()
    {

        (int remainingA, int remainingB) = game.BattleRound(warrior, wizard);

        Assert.That(remainingA <= 0 || remainingB <= 0);
    }

    [Test]
    public void BattleRound_Should_Return_Valid_Health_Values()
    {
        (int remainingA, int remainingB) = game.BattleRound(wizard, warrior);

        Assert.That(remainingA, Is.InRange(0, wizard.DefaultHealth));
        Assert.That(remainingB, Is.InRange(0, warrior.DefaultHealth));
    }
    [Test]
    public void Fight_Should_Handle_Multiple_Rounds()
    {
        var teamA = new TeamGenerator("TeamA");
        var teamB = new TeamGenerator("TeamB");
        teamA.team.Add(new Warrior());
        teamA.team.Add(new Wizard());
        teamB.team.Add(new Wizard());
        teamB.team.Add(new Warrior());
        game = new Game(teamA, teamB);

        game.Fight();
        string output = _consoleOutput.ToString();

        Assert.That(output.Contains("Warrior wins this round!") || output.Contains("Cleric wins this round!")|| output.Contains("Warrior wins this round!"));
    }

    // game funciton
    /*
        We want to alternate between Team A and B
    */




}