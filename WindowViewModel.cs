using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ListViewColumnsInColumns
{
    public class WindowViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Dummy> _datas;

        public ObservableCollection<Dummy> Datas
        {
            get => _datas;
            set
            {
                _datas = value;
                SetProperty(nameof(Datas));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void SetProperty(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public WindowViewModel()
        {
            Datas = new ObservableCollection<Dummy>
            {
                new Dummy
                {
                    No = 1,
                    Link = "http://www.naver.com",
                    Title = "네이버",
                    Url = "http://www.naver.com"
                },
                new Dummy
                {
                    No = 2,
                    Link = "http://www.kakao.com",
                    Title = "카카오",
                    Url = "http://www.kakao.com"
                },
            };
        }
    }

    public class Dummy
    {
        public int No { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Link { get; set; }
    }
}
