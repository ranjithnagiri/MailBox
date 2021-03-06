﻿using MailBox.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MailBox.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ObservableCollection<EmailBox> Emails { get; } = new ObservableCollection<EmailBox>();

        private EmailBox _emailBoxSelected;
        public EmailBox EmailBoxSelected
        {
            get { return _emailBoxSelected; }
            set
            {
                if (value != null)
                    ShowEmail = true;

                SetProperty(ref _emailBoxSelected, value);
            }
        }

        private bool _showEmail;
        public bool ShowEmail
        {
            get { return _showEmail; }
            set { SetProperty(ref _showEmail, value); }
        }


        public MainPageViewModel()
        {   
            LoadEmails();
        }


        void LoadEmails()
        {
            var content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum fermentum facilisis libero, venenatis mattis orci hendrerit eget. Etiam ultrices mollis justo, nec fermentum elit viverra eu. Cras at cursus turpis. Nullam magna sem, vulputate quis massa nec, mollis sollicitudin dui. Sed eu massa in arcu pharetra posuere. Phasellus maximus neque non ex dapibus fringilla. Praesent nec lacinia enim. Curabitur a dui nisl.";
            Emails.Add(new EmailBox { Img = "Assets/user02.png", Name = "Sam Miller", Subject = "Portifolio", EmailDate = "Today", EmailHour = "08:45 PM", Attachments = 4, AttachmentsItems = LoadAttachments(), Email = "sammiller@gmail.com", Content = content });
            Emails.Add(new EmailBox { Img = "Assets/user03.png", Name = "Lily Jones", Subject = "Invitations", EmailDate = "Yesterday", EmailHour = "01:11 PM", Attachments = 0, Email = "lilyjones@gmail.com", Content = content });
            Emails.Add(new EmailBox { Img = "Assets/user04.png", Name = "Smith", Subject = "Assigment Submission", EmailDate = "Monday", EmailHour = "06:45 PM", Attachments = 0, Email = "smith@gmail.com", Content = content });
            Emails.Add(new EmailBox { Img = "Assets/user05.png", Name = "Patrick", Subject = "Interview Scheduled", EmailDate = "Monday", EmailHour = "05:15 PM", Attachments = 0, Email = "patrick@gmail.com", Content = content });
        }

        List<string> LoadAttachments()
        {
            return new List<string> { "Assets/img01.png", "Assets/img02.png", "Assets/img03.png", "Assets/img04.png" };
        }
    }
}
