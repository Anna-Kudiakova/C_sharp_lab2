using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using CSharp.Lab02.Models;
using CSharp.Lab02.Tools;
using CSharp.Lab02.Tools.Exceptions;

namespace CSharp.Lab02.ViewModels
{
    class PersonViewModel : INotifyPropertyChanged
    {

        private bool _isAdult;
        private string _sunSign;
        private string _chineseSign;
        private bool _isBirthday;
        private bool _isEnabled = true;

        private Person _person = new();

        private RelayCommand<object> _getInformationCommand;

        public event PropertyChangedEventHandler PropertyChanged;
       

        public string Name
        {
            get
            {
                return _person.Name;
            }
            set
            {
                _person.Name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _person.Surname;
            }
            set
            {
                _person.Surname = value;
            }
        }
        public string Mail
        {
            get
            {
                return _person.Mail;
            }
            set
            {
                _person.Mail = value;
            }
        }
        public DateTime? BirthDate
        {
            get
            {
                return _person.BirthDate;
            }
            set
            {
                _person.BirthDate = value;
            }
        }

        public bool IsAdult
        {
            get
            {
                return _isAdult;
            }
            private set
            {
                _isAdult = value;
                OnPropertyChanged("IsAdult");
            }
        }

        public string SunSign
        {
            get
            {
                return _sunSign;
            }
            private set
            {
                _sunSign = value;
                OnPropertyChanged("SunSign");
            }
        }

        public string ChineseSign
        {
            get
            {
                return _chineseSign;
            }
            private set
            {
                _chineseSign = value;
                OnPropertyChanged("ChineseSign");
            }
        }

        public bool IsBirthday
        {
            get
            {
                return _isBirthday;
            }
            private set
            {
                _isBirthday = value;
                OnPropertyChanged("IsBirthday");
            }
        }



        public RelayCommand<object> ProceedCommand
        {
            get
            {

                return _getInformationCommand ??= new RelayCommand<object>(_ => Proceed(), CanExecute);
            }

        }

        private bool CanExecute(object obj)
        {
            return !string.IsNullOrWhiteSpace(BirthDate.ToString()) && !string.IsNullOrWhiteSpace(Name) &&
                     !string.IsNullOrWhiteSpace(Surname) && !string.IsNullOrWhiteSpace(Mail);
        }

        private async void Proceed()
        {
            try
            {
                _person = new Person(Name, Surname, Mail, BirthDate);
            }
            catch (IncorrectNameException e)
            {
                MessageBox.Show(e.Message);
                return;
            }
            catch (IncorrectSurnameException e)
            {
                MessageBox.Show(e.Message);
                return;
            }
            catch (IncorrectEmailException e)
            {
                MessageBox.Show(e.Message);
                return;
            }
            catch (UnbornPersonException e)
            {
                MessageBox.Show(e.Message);
                return;
            }
            catch (OveragedPersonException e)
            {
                MessageBox.Show(e.Message);
                return;
            }

            IsEnabled = false;
            await Task.Run(() => GetInformation());
            IsEnabled = true;
        }

        private void GetInformation()
        {
            IsAdult = _person.IsAduld;
            SunSign = _person.SunSign;
            ChineseSign = _person.ChineseSign;
            OnPropertyChanged("Name");
            OnPropertyChanged("Surname");
            OnPropertyChanged("Mail");
            OnPropertyChanged("BirthDate");
            if (IsBirthday = _person.HaveBirthday)
            {
                MessageBox.Show("Happy Birthday!!!!! You’re one step closer to diapers being mandatory!");
            }
        }

        public bool IsEnabled
        {
            get
            {
                return _isEnabled;
            }

            set
            {
                _isEnabled = value;
                OnPropertyChanged();
            }

        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
