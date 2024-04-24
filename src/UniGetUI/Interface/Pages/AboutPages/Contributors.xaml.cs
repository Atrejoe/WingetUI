using System;
using Microsoft.UI.Xaml.Controls;
using UniGetUI.Core.Data;
using System.Collections.ObjectModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace UniGetUI.Interface.Pages.AboutPages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    public class Person
    {
        public string Name { get; set; }
        public Uri? ProfilePicture;
        public Uri? GitHubUrl;
        public bool HasPicture = false;
        public bool HasGitHubProfile = false;
        public string Language = "";
    }

    public sealed partial class Contributors : Page
    {
        public ObservableCollection<Person> ContributorList = [];
        public Contributors()
        {
            this.InitializeComponent();
            foreach (string contributor in ContributorsData.Contributors)
            {
                Person person = new()
                {
                    Name = "@" + contributor,
                    ProfilePicture = new Uri("https://github.com/" + contributor + ".png"),
                    GitHubUrl = new Uri("https://github.com/" + contributor),
                    HasPicture = true,
                    HasGitHubProfile = true,
                };
                ContributorList.Add(person);
            }
        }
    }
}
