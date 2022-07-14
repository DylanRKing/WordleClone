using System.Collections.ObjectModel;
using WordleClone.Models;

namespace WordleClone.ViewModels
{
    public class HistoryViewModel : ViewModelBase
    {
        public ObservableCollection<Attempt> PreviousAttempts { get; set; }

        public HistoryViewModel()
        {
            PreviousAttempts = new ObservableCollection<Attempt>();
            GetAttempts();
        }

        private void GetAttempts()
        {
            // TODO: Add code to fetch previous attempts from sqlite db
        }
    }
}
