using ReactiveUI;

namespace RxCrash
{
    public class RxCrashViewModel : ReactiveObject
    {
        private string _someText;

        public string SomeText
        {
            get => _someText;
            set => this.RaiseAndSetIfChanged(ref _someText, value);
        }
    }
}

