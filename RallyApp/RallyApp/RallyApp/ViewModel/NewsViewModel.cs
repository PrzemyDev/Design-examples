using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RallyApp.ViewModel
{
    public class NewsViewModel
    {

            public ObservableCollection<Article> News { get; set; }
            public NewsViewModel()
            {
            News = new ObservableCollection<Article>();
            News.Add(new Article
                {
                    Title = "Zwycięzcy 78 Rajdu Polski!",
                    Date = "12.05.2022",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur? At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat",
                    Image = "https://www.motocaina.pl/thumbor_image/1920/864/1/0/!2F2021!2F03!2Fc0c61f4e04e125823e7a003a70603d4df35b484b.jpg"

            });
            News.Add(new Article
            {
                Title = "Kajetan K. wraz z Maciejem S. wygrywają Rajd Safari!",
                Date = "12.05.2022",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat",
                Image = "https://rallypl.com/wp-content/uploads/2022/06/IMG_5387-scaled-1-e1656336070404.jpg"
            });
            News.Add(new Article
            {
                Title = "Opublikowano harmonogram Rajdu Polski",
                Date = "12.05.2022",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Image = "https://rallypl.com/wp-content/uploads/2022/03/5FC76307-87B6-410A-B310-D069BB64951B.jpeg"
            });
        }
    }

        public class Article
        {
            public string Title { get; set; }
            public string Date { get; set; }
            public string Description { get; set; }
            public string Image { get; set; }
        }
    
}
