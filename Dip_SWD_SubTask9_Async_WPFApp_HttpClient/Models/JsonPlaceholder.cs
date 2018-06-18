using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip_SWD_SubTask9_Async_WPFApp_HttpClient.Models
{
      class Post
      {
            public int postId { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string body { get; set; }
      }

      class Posts
      {
            public List<Post> PostsList { get; set; }
      }
}
