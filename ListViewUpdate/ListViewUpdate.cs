using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace ListViewUpdate
{
    public class App : Application
    {

        int _newGroupIndex = 0;


        public App()
        {

            var group1 = new Group("group A");
            var group2 = new Group("group C")
            {
                "item 1", "item 2"
            };
            var source = new ObservableCollection<Group>
            {
                group1, group2
            };

            var button = new Button
            {
                Text = "Add Group between A & C"
            };

            // The root page of your application
            var content = new ContentPage
            {
                Title = "ListViewUpdate",
                Content = new StackLayout
                {
                    Children =
                    {
                        button,
                        new ListView
                        {
                            ItemsSource = source,
                            GroupDisplayBinding = new Binding("Title"),
                            IsGroupingEnabled = true
                        }
                    }
                }
            };

            MainPage = new NavigationPage(content);

            button.Clicked += (sender, e) =>
            {
                var group = new Group("New Group " + _newGroupIndex)
                {
                    "new Group["+_newGroupIndex+" ].A", "new Group["+_newGroupIndex+" ].B",
                };
                _newGroupIndex++;
                source.Insert(1, group);
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
