using System;
using System.Collections.Generic;

// Memento
public class GameCheckpoint
{
    public int Level { get; }
    public int Score { get; }

    public GameCheckpoint(int level, int score)
    {
        Level = level;
        Score = score;
    }
}

public class GamePlayer
{
    private int level;
    private int score;

    public int Level
    {
        get { return level; }
        set { level = value; }
    }

    public int Score
    {
        get { return score; }
        set { score = value; }
    }

    public GameCheckpoint CreateCheckpoint()
    {
        return new GameCheckpoint(level, score);
    }

    public void RestoreCheckpoint(GameCheckpoint checkpoint)
    {
        level = checkpoint.Level;
        score = checkpoint.Score;
    }

    public void PrintStatus()
    {
        Console.WriteLine($"Level: {level}, Score: {score}");
    }
}

// Caretaker
public class GameHistory
{
    private List<GameCheckpoint> checkpoints = new List<GameCheckpoint>();

    public void SaveCheckpoint(GameCheckpoint checkpoint)
    {
        checkpoints.Add(checkpoint);
    }

    public GameCheckpoint GetCheckpoint(int index)
    {
        return checkpoints[index];
    }
}

public class GamePlayerClient
{
    public static void Main(string[] args)
    {
        // Creating a game player and history
        GamePlayer gamePlayer = new GamePlayer();
        GameHistory gameHistory = new GameHistory();

        // Playing and saving checkpoints
        gamePlayer.Level = 1;
        gamePlayer.Score = 100;
        gameHistory.SaveCheckpoint(gamePlayer.CreateCheckpoint());
        gamePlayer.PrintStatus();

        gamePlayer.Level = 2;
        gamePlayer.Score = 200;
        gameHistory.SaveCheckpoint(gamePlayer.CreateCheckpoint());
        gamePlayer.PrintStatus();

        // Restoring to previous checkpoint
        gamePlayer.RestoreCheckpoint(gameHistory.GetCheckpoint(0));
        gamePlayer.PrintStatus();

        // Continuing from the latest checkpoint
        gamePlayer.RestoreCheckpoint(gameHistory.GetCheckpoint(1));
        gamePlayer.PrintStatus();
    }
}
