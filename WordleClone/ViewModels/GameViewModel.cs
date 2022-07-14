using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordleClone.Views.Controls;

namespace WordleClone.ViewModels
{
    public class GameViewModel : ViewModelBase
    {
        private string Answer { get; set; } = "Adieu";
        private int Letters { get; set; } = 5;
        private int Attempts { get; set; } = 6;

        private List<string> Guesses { get; set; }
        public ObservableCollection<GuessItem> GuessItems{ get; set; }
        
        private string userInput;

        public string UserInput
        {
            get { return userInput; }
            set
            {
                userInput = value.ToUpper();
                OnPropertyChanged("UserInput");
                OnPropertyChanged("Option1");
                OnPropertyChanged("Option2");
                OnPropertyChanged("Option3");
                OnPropertyChanged("Option4");
                OnPropertyChanged("Option5");
            }
        }

        private GuessItem currentGuess;

        public GuessItem CurrentGuess
        {
            get { return currentGuess; }
            set
            {
                currentGuess = value;
                OnPropertyChanged("CurrentGuess");
            }
        }

        public string Option1
        {
            get 
            { 
                if(!string.IsNullOrEmpty(UserInput))
                    if(UserInput.Length >= 1)
                        return UserInput[0].ToString();
                return string.Empty;
            }
        }

        public string Option2
        {
            get
            {
                if (!string.IsNullOrEmpty(UserInput))
                    if (UserInput.Length >= 2)
                    return UserInput[1].ToString();
                return string.Empty;
            }
        }

        public string Option3
        {
            get
            {
                if (!string.IsNullOrEmpty(UserInput))
                    if (UserInput.Length >= 3)
                    return UserInput[2].ToString();
                return string.Empty;
            }
        }

        public string Option4
        {
            get
            {
                if (!string.IsNullOrEmpty(UserInput))
                    if (UserInput.Length >= 4)
                    return UserInput[3].ToString();
                return string.Empty;
            }
        }

        public string Option5
        {
            get
            {
                if (!string.IsNullOrEmpty(UserInput))
                    if (UserInput.Length >= 5)
                    return UserInput[4].ToString();
                return string.Empty;
            }
        }

        public GameViewModel()
        {
            Guesses = new List<string>();
            GuessItems = new ObservableCollection<GuessItem>();

            for (int i = 0; i < Attempts; i++)
            {
                GuessItems.Add(new GuessItem());
            }
        }

    }
}
