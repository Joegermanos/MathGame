namespace MathGame.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public GameStats MathGameStats { get; set; }
        public GameStats GuessGameStats { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            MathGameStats = new GameStats();
            GuessGameStats = new GameStats();
        }
    }

    public class GameStats
    {
        public int TotalScore { get; set; }
        public int TotalAttempts { get; set; }
        public int CorrectAnswers { get; set; }
        public int WrongAnswers { get; set; }
        public Dictionary<string, int> OperationScores { get; set; }
        public Dictionary<string, int> DifficultyBestScores { get; set; }

        public GameStats()
        {
            TotalScore = 0;
            TotalAttempts = 0;
            CorrectAnswers = 0;
            WrongAnswers = 0;
            OperationScores = new Dictionary<string, int>
            {
                { "Addition", 0 },
                { "Subtraction", 0 },
                { "Multiplication", 0 },
                { "Division", 0 }
            };
            DifficultyBestScores = new Dictionary<string, int>
            {
                { "Easy", 0 },
                { "Medium", 0 },
                { "Hard", 0 }
            };
        }
    }
}
