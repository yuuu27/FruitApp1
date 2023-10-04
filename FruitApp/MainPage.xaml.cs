namespace FruitApp
{
    public partial class MainPage : ContentPage
    {
        //List<string> list =new List<string>() { "Apple","Banana","Orange","Guava","Peach","Melon"};



        public MainPage()
        {
            InitializeComponent();


            List<Fruit> list = new List<Fruit>()
            {
            new Fruit(){ Name="Apple" , Image="apple.png" , Description="This is apple" },
            new Fruit(){ Name="Orange" , Image="orange.png" , Description="This is orange " },
            new Fruit(){ Name="Banana" , Image="banana.png" , Description="This is banana " },
            new Fruit(){ Name="Kiwi" , Image="kiwi.png " , Description="This is kiwi " },
            new Fruit(){ Name="Strawberry" , Image="strawberry.png" , Description="This is strawberry " },
            new Fruit(){ Name="Pineapple" , Image="pineapple.png " , Description="This is  pineapple" },
            new Fruit(){ Name="Watermelon" , Image="watermelon.png " , Description="This is watermelon " },
            new Fruit(){ Name="Grapes" , Image="grape.png " , Description="This is  grapes" },
            };

            FruitListView.ItemsSource = list;
        }






        private void FruitListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var selectedItem = e.SelectedItem as Fruit;
            Navigation.PushAsync(new FruitDetailed(selectedItem.Name, selectedItem.Image, selectedItem.Description));

            ((ListView)sender).SelectedItem = null;
        }


    }
}
