using CommunityToolkit.Mvvm.ComponentModel;

namespace WordleClone.Models;

public class Letter
{
    [ObservableProperty]
    private char? character;
    [ObservableProperty]
    private LetterStates letterState;

    public Letter(char c)
    {
        character = c;
    }
}
