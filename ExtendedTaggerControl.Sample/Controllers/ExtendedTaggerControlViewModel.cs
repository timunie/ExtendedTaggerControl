﻿using System.Collections.ObjectModel;
using ExtendedTaggerControl.Sample.ViewModels;
using ReactiveUI;

namespace ExtendedTaggerControl.Sample.Controllers
{
    public class ExtendedTaggerControlViewModel : ViewModelBase
    {
        public ExtendedTaggerControlViewModel()
        {
            Tags = new ObservableCollection<string>();
        }
        
        private ObservableCollection<string> _tags;
        public ObservableCollection<string> Tags
        {
            get => _tags;
            set => this.RaiseAndSetIfChanged(ref _tags, value);
        }

        public async void AddTag(string tag)
        {
            if(!Tags.Contains(tag)) Tags.Add(tag);
        }

        public async void RemoveTag(string tag) => Tags.Remove(tag);
    }
}