using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fancyGaem.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpgradesView : ContentPage
    {
        public ICommand BackToGameCommand => new Command(() => BackToGame());
        private void BackToGame()
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }
        public UpgradesView()
        {
            InitializeComponent();
            this.BindingContext = this;
            List<UpgradePerClick> upgradeList = new List<UpgradePerClick>();
            upgradeList.Add(new UpgradePerClick
            {
                Name = "Shopping", Id = 1,
                PlusPoints = 1,Cost = 15,Description = "New hardware"
            });
            upgradeList.Add(new UpgradePerClick
            {
                Name = "Update scenarios",
                Id = 2,
                PlusPoints = 2,Cost = 15,Description = "Upgrade testing scenario"
            });
            upgradeList.Add(new UpgradePerClick
            {
                Name = "Gojira",
                Id = 3,
                PlusPoints = 5, Cost = 50,Description = "Integrate bug tracking workspace"
            });
            listPPCUpgrades.ItemsSource = upgradeList;

            List<UpgradePerSecond> upgradeList2 = new List<UpgradePerSecond>();
            upgradeList2.Add(new UpgradePerSecond
            {
                Name = "PestAPI",
                Id = 1,
                PlusPoints = 1,
                Cost = 15,
                Description = "Automate scenarios preparing"
            });
            upgradeList2.Add(new UpgradePerSecond
            {
                Name = "Cypross",
                Id = 2,
                PlusPoints = 2,
                Cost = 15,
                Description = "End 2 End tests!"
            });
            upgradeList2.Add(new UpgradePerSecond
            {
                Name = "Pythonidae",
                Id = 3,
                PlusPoints = 5,
                Cost = 50,
                Description = "Automate regression tests"
            });
            listPPSUpgrades.ItemsSource = upgradeList2;
        }
    }
    
        class UpgradePerClick
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Cost { get; set; }
            public int PlusPoints { get; set; }
            public string Description { get; set; }
        }
    class UpgradePerSecond
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int PlusPoints { get; set; }
        public string Description { get; set; }
    }
}