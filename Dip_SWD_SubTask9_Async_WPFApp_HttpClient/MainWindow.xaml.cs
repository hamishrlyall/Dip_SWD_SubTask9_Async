using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Dip_SWD_SubTask9_Async_WPFApp_HttpClient.Models;
using Newtonsoft.Json;

namespace Dip_SWD_SubTask9_Async_WPFApp_HttpClient
{
      /// <summary>
      /// Interaction logic for MainWindow.xaml
      /// </summary>
      public partial class MainWindow : Window
      {

            HttpClient client = new HttpClient();

            public MainWindow()
            {
                  InitializeComponent();
            }

            private async void jsonbutton_Click(object sender, RoutedEventArgs e)
            {
                  client.BaseAddress = new Uri("http://jsonplaceholder.typicode.com/");

                  HttpResponseMessage httpResponseMessage = await client.GetAsync("posts");

                  var content = await httpResponseMessage.Content.ReadAsStringAsync();

                  var posts = JsonConvert.DeserializeObject<List<Post>>(content);

                  Post p = new Post
                  {
                        postId = 1,
                        id = 1,
                        name = "id labore ex et quam laborum",
                        email = "Eliseo@gardner.biz",
                        body = "laudantium enim quasi est quidem magnam voluptate ipsam eos\ntempora quo necessitatibus\ndolor quam autem quasi\nreiciendis et nam sapiente accusantium"
                  };
                  Post p2 = new Post
                  {
                        postId = 1,
                        id = 2,
                        name = "quo vero reiciendis velit similique earum",
                        email = "Jayne_Kuhic@sydney.com",
                        body = "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et"
                  };

                  string json = JsonConvert.SerializeObject(p);

                  label.Content = json;
            }


      }
}
