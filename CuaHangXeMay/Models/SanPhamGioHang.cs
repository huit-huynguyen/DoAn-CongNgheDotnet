using System.Collections.Generic;
using System.ComponentModel;

namespace CuaHangXeMay.Models
{
    public class SanPhamGioHang : INotifyPropertyChanged
    {
        private Xe _xe;
        public Xe Xe
        {
            get { return _xe; }
            set { SetField(ref _xe, value, "Xe"); }
        }

        private int _soLuong;
        public int SoLuong
        {
            get { return _soLuong; }
            set { SetField(ref _soLuong, value, "SoLuong"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private bool SetField<T>(ref T field, T value, string propertyName)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return false;
            }
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
