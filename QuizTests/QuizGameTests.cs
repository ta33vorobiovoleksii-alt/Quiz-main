  [Fact]
        public void CorrectAnswerPercentage_When1Of2_ShouldBe50()
        {
            var game = new QuizGame();

            game.GiveAnswer(true, 10);
            game.GiveAnswer(false, 10);

            Assert.Equal(50.0, game.CorrectAnswerPercentage, 2);
        }
