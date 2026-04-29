using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows;

namespace AbrViewer
{
    [DataContract]
    public class Config : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool _exitOnEsc = true;
        [DataMember]
        public bool ExitOnEsc {
            get => _exitOnEsc;
            set { if (_exitOnEsc != value) { _exitOnEsc = value; OnPropertyChanged(); } }
        }

        private int _thumbnailSize = 120;
        [DataMember]
        public int ThumbnailSize {
            get => _thumbnailSize;
            set { if (_thumbnailSize != value) { _thumbnailSize = value; OnPropertyChanged(); } }
        }

        private int _windowWidth = 800;
        [DataMember]
        public int WindowWidth {
            get => _windowWidth;
            set { if (_windowWidth != value) { _windowWidth = value; OnPropertyChanged(); } }
        }

        private int _windowHeight = 600;
        [DataMember]
        public int WindowHeight {
            get => _windowHeight;
            set { if (_windowHeight != value) { _windowHeight = value; OnPropertyChanged(); } }
        }

        private WindowState _windowState = WindowState.Normal;
        [DataMember]
        public WindowState WindowState {
            get => _windowState;
            set { if (_windowState != value) { _windowState = value; OnPropertyChanged(); } }
        }
    }
}
