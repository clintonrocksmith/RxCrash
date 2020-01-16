using ReactiveUI;

namespace RxCrash
{
    public class RxCrashViewModel : ReactiveObject
    {
        public RxCrashViewModel()
        {
            SomeText = "It works!";
        }
        
        private string _someText;

        public string SomeText
        {
            get => _someText;
            set => this.RaiseAndSetIfChanged(ref _someText, value);
        }
    }
}

