using System;
using System.Collections.Generic;

public class Game
{
    private TeamGenerator teamA;
    private TeamGenerator teamB;
    private Random rand;

    public Game(TeamGenerator a, TeamGenerator b)
    {
        teamA = a;
        teamB = b;
        rand = new Random();
    }

    public void GameRun()
    {
        Console.WriteLine("\n____ Battle Start! ____");
        Fight();
    }

    private void Fight()
    {
        int indexA = 0;
        int indexB = 0;

        while (indexA < teamA.team.Count && indexB < teamB.team.Count)
        {
            var fighterA = teamA.team[indexA];
            var fighterB = teamB.team[indexB];

            Console.WriteLine($"\n{fighterA.GetType().Name} (HP: {fighterA.DefaultHealth}) VS {fighterB.GetType().Name} (HP: {fighterB.DefaultHealth})");

            (int remainingA, int remainingB) = BattleRound(fighterA, fighterB);

            if (remainingA <= 0 && remainingB <= 0)
            {
                Console.WriteLine("Both fighters are eliminated");
                indexA++;
                indexB++;
            }
            else if (remainingA <= 0)
            {
                Console.WriteLine($"{fighterB.GetType().Name} wins this round!");
                indexA++;
            }
            else
            {
                Console.WriteLine($"{fighterA.GetType().Name} wins this round!");
                indexB++;
            }

            Console.WriteLine($"Remaining fighters: {teamA.team.Count - indexA} vs {teamB.team.Count - indexB}");
        }

        if (indexA >= teamA.team.Count && indexB >= teamB.team.Count)
            Console.WriteLine("\nIt's a draw!");
        else if (indexA >= teamA.team.Count)
            Console.WriteLine($"\n{teamB.teamName} Wins!");
        else
            Console.WriteLine($"\n{teamA.teamName} Wins!");
    }

    private (int, int) BattleRound(BaseCharacter fighterA, BaseCharacter fighterB)
    {
        int healthA = fighterA.DefaultHealth;
        int healthB = fighterB.DefaultHealth;

        while (healthA > 0 && healthB > 0)
        {
            bool aAttacksFirst = rand.Next(2) == 0;

            if (aAttacksFirst)
            {
                healthB -= CalculateDamage(fighterA);
                Console.WriteLine($"{fighterA.GetType().Name} hits {fighterB.GetType().Name} (HP left: {Math.Max(healthB, 0)})");

                if (healthB <= 0) break;

                healthA -= CalculateDamage(fighterB);
                Console.WriteLine($"{fighterB.GetType().Name} hits {fighterA.GetType().Name} (HP left: {Math.Max(healthA, 0)})");
            }
            else
            {
                healthA -= CalculateDamage(fighterB);
                Console.WriteLine($"{fighterB.GetType().Name} hits {fighterA.GetType().Name} (HP left: {Math.Max(healthA, 0)})");

                if (healthA <= 0) break;

                healthB -= CalculateDamage(fighterA);
                Console.WriteLine($"{fighterA.GetType().Name} hits {fighterB.GetType().Name} (HP left: {Math.Max(healthB, 0)})");
            }
        }

        return (healthA, healthB);
    }

    private int CalculateDamage(BaseCharacter fighter)
    {
        return fighter.Attack + rand.Next(-2, 3);
    }
}
