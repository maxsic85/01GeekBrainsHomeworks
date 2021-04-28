using GuessTheNumberLib.ViewInterface;
using System;

namespace GuessTheNumberLib
{
    public enum GameState
    {
        NEW,
        LESS,
        MORE,
        WIN
    }

    public class Presenter
    {
        private IView view;
        public Presenter(IView View) => this.view = View;

        Random r = new Random();
        public int CntOperations { get; private set; }
        public int Secret { get; private set; }
        public void UpdateUI()
        {
            switch (state)
            {
                case GameState.NEW:
                    view.LblTxt = $"Угадайте загаданное число за наименьшее кол-во попыток";
                    break;
                case GameState.LESS:
                    view.LblTxt = $"Введенное число меньше загаданного";
                    break;
                case GameState.MORE:
                    view.LblTxt = $"Введенное число больше загаданного";
                    break;
                case GameState.WIN:
                    view.LblTxt = $"Победа, загаданное число {Secret} отгадано с {CntOperations} попытки";
                    break;
                default:
                    break;
            }

        }

        public GameState state = new GameState();
        public int SecretDigit() => r.Next(1, 100);
        public void CheckAnswer()
        {
            int answer;
            if (!Int32.TryParse(view.TextBoxText.ToString(), out answer)) return;
            CntOperations++;
            if (answer == Secret)
            { state = GameState.WIN; }
            else if (answer > Secret)
                state = GameState.MORE;
            else if (answer < Secret)
                state = GameState.LESS;
            else state = GameState.NEW;

            UpdateUI();
        }
        public void Restart()
        {
            Secret = SecretDigit();
            CntOperations = 0;
            state = GameState.NEW;
            UpdateUI();
        }
    }
}
