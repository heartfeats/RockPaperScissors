namespace RockPaperScissors.Models {
    public class PlayerChoices {
        private string _inputOne;
        private string _inputTwo;

        public PlayerChoices (string inputOne, string inputTwo) {
            _inputOne = inputOne;
            _inputTwo = inputTwo;
        }

        public string GetInputOne () {
            return _inputOne;
        }

        public string GetInputTwo () {
            return _inputTwo;
        }

        public string ComparePlayerChoices () {
            if ((_inputOne == "rock" && _inputTwo == "scissors") ||
                (_inputOne == "scissors" && _inputTwo == "paper") ||
                (_inputOne == "paper" && _inputTwo == "rock")) {
                return "Player One Wins!";
            } else if ((_inputTwo == "rock" && _inputOne == "scissors") ||
                (_inputTwo == "scissors" && _inputOne == "paper") ||
                (_inputTwo == "paper" && _inputOne == "rock")) {

                return "Player Two Wins!";
            } else {
                return "It's a Draw!";
            }
        }
    }
}